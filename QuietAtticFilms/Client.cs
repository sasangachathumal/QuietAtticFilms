using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace QuietAtticFilms
{
    public partial class Client : Form
    {
        private const string connectionString = "Data Source=.;Initial Catalog=Quiet_Attic_Films;Integrated Security=True";

        int selectedClientId = -1;
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            loadClientDataGrid();
            getNextEid();
        }

        private void loadClientDataGrid()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT cid as 'Client ID', name as 'Name', contact as 'Contact'," +
                        " cAddress as 'Address' FROM Client";
                    DataTable dt = new DataTable();
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    dgClient.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void checkSearch_CheckedChanged(object sender, EventArgs e)
        {
            combClientId.Items.Clear();
            txtClientId.Visible = !checkSearch.Checked;
            combClientId.Visible = checkSearch.Checked;
            btnSave.Text = checkSearch.Checked ? "Update" : "Register";
            locadClientIdCombo();
            combClientId.Focus();
        }

        private void locadClientIdCombo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT cid FROM Client";
                    DataTable dt = new DataTable();
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }

                    combClientId.Items.Clear();
                    combClientId.Items.Add("--SELECT--");
                    foreach (DataRow Dr in dt.Rows)
                    {
                        combClientId.Items.Add(Dr["cid"]);
                    }
                    combClientId.SelectedIndex = 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            txtAddress.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtName.Text = string.Empty;
            if (checkSearch.Checked)
            {
                combClientId.SelectedIndex = 0;
            }
            else
            {
                combClientId.Items.Clear();
            }
        }
        private void getNextEid()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT TOP 1 ID FROM Client ORDER BY id DESC";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int lastID = reader.GetInt32(0);
                                if (lastID < 10)
                                {
                                    txtClientId.Text = "C-0" + (lastID += 1);
                                }
                                else
                                {
                                    txtClientId.Text = "C-" + (lastID += 1);
                                }
                            }
                            else
                            {
                                txtClientId.Text = "C-01";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkSearch.Checked)
            {
                updateClient();
            }
            else
            {
                registerClient();
            }
        }

        private void updateClient()
        {
            if (txtName.Text == string.Empty ||
                txtContact.Text == string.Empty ||
                txtAddress.Text == string.Empty)
            {
                MessageBox.Show("Please fill all the inputs", "Invalid Values",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create an SQL command to update data
                    string updateQuery = "UPDATE Client SET name = @name, " +
                                         "contact = @contact, cAddress = @address " +
                                         "WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@name", txtName.Text);
                        command.Parameters.AddWithValue("@contact", txtContact.Text);
                        command.Parameters.AddWithValue("@address", txtAddress.Text);
                        command.Parameters.AddWithValue("@id", selectedClientId);

                        // Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Client Update is successful.");
                        }
                        else
                        {
                            MessageBox.Show("Client Update fail.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                }
            }
            clear();
            loadClientDataGrid();
        }

        private void registerClient()
        {
            if (txtName.Text == string.Empty ||
                txtContact.Text == string.Empty ||
                txtAddress.Text == string.Empty)
            {
                MessageBox.Show("Please fill all the inputs", "Invalid Values",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create an SQL command to insert data into a table
                    string insertQuery = "INSERT INTO Client (cId, name, contact, cAddress) " +
                                         "VALUES (@cid, @name, @contact, @address)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@cid", txtClientId.Text);
                        command.Parameters.AddWithValue("@name", txtName.Text);
                        command.Parameters.AddWithValue("@contact", txtContact.Text);
                        command.Parameters.AddWithValue("@address", txtAddress.Text);

                        // Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Client Registration is successful.");
                        }
                        else
                        {
                            MessageBox.Show("Client Registration fail.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                }
            }
            clear();
            loadClientDataGrid();
            getNextEid();
        }

        private void combClientId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combClientId.SelectedIndex > 0)
            {
                string? selectedEid = combClientId.SelectedItem.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create an SQL command to insert data into a table
                        string selectQuery = "SELECT * FROM Client WHERE cid=@cid";

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@cid", selectedEid);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    selectedClientId = reader.GetInt32(0);
                                    txtName.Text = reader.GetString(2);
                                    txtContact.Text = reader.GetString(3);
                                    txtAddress.Text = reader.GetString(4);
                                }
                                else
                                {
                                    MessageBox.Show("No data found in the database.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else { clear(); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult diaRes = MessageBox.Show("Are you sure, You want to Delete Client ID: " +
                combClientId.Text + " record from the Database? ", "Confirm to DELETE!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes == DialogResult.Yes)
            {
                //string? selectedEid = combClientId.SelectedItem.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create an SQL command to insert data into a table
                        string selectQuery = "DELETE FROM Client WHERE id=@id";

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@id", selectedClientId);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Client Delete is successful.");
                            }
                            else
                            {
                                MessageBox.Show("Client Delete fail.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                clear();
                loadClientDataGrid();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuietAtticFilms
{
    public partial class Staff : Form
    {
        public Form? homePage { get; set; }

        private const string connectionString = "Data Source=.;Initial Catalog=Quiet_Attic_Films;Integrated Security=True";

        int selectedStaffId = -1;
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            loadStaffDataGrid();
            getNextStid();
        }

        private void getNextStid()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT TOP 1 ID FROM Staff ORDER BY id DESC";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int lastID = reader.GetInt32(0);
                                if (lastID < 10)
                                {
                                    txtStaffId.Text = "ST-0" + (lastID += 1);
                                }
                                else
                                {
                                    txtStaffId.Text = "ST-" + (lastID += 1);
                                }
                            }
                            else
                            {
                                txtStaffId.Text = "ST-01";
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

        private void loadStaffDataGrid()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT stId as 'Staff ID', name as 'Name', nic as 'NIC', contact as 'Contact'" +
                        " FROM Staff";
                    DataTable dt = new DataTable();
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    dgStaff.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            txtName.Text = string.Empty;
            txtNic.Text = string.Empty;
            txtContact.Text = string.Empty;
            if (checkSearch.Checked)
            {
                combStaffId.SelectedIndex = 0;
            }
            else
            {
                combStaffId.Items.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult diaRes = MessageBox.Show("Are you sure, You want to Delete Staff Member ID: " +
                combStaffId.Text + " record from the Database? ", "Confirm to DELETE!",
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
                        string selectQuery = "DELETE FROM Staff WHERE id=@id";

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@id", selectedStaffId);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Staff member delete is successful.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Staff member Delete fail.", "Fail !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                clearForm();
                loadStaffDataGrid();
            }
        }

        private void checkSearch_CheckedChanged(object sender, EventArgs e)
        {
            combStaffId.Items.Clear();
            txtStaffId.Visible = !checkSearch.Checked;
            combStaffId.Visible = checkSearch.Checked;
            btnSave.Text = checkSearch.Checked ? "Update" : "Save";
            loadStaffMemberData();
            combStaffId.Focus();
        }

        private void loadStaffMemberData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT stId FROM Staff";
                    DataTable dt = new DataTable();
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }

                    combStaffId.Items.Clear();
                    combStaffId.Items.Add("--SELECT--");
                    foreach (DataRow Dr in dt.Rows)
                    {
                        combStaffId.Items.Add(Dr["stId"]);
                    }
                    combStaffId.SelectedIndex = 0;

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
                updateStaff();
            }
            else
            {
                saveStaff();
            }
        }

        private void updateStaff()
        {
            if (txtName.Text == string.Empty ||
                txtNic.Text == string.Empty ||
                txtContact.Text == string.Empty)
            {
                MessageBox.Show("Fill all required data", "Invalid Values",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create an SQL command to update data
                    string updateQuery = "UPDATE Staff SET name = @name, nic = @nic, contact = @contact " +
                        " WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@name", txtName.Text);
                        command.Parameters.AddWithValue("@nic", txtNic.Text);
                        command.Parameters.AddWithValue("@contact", txtContact.Text);
                        command.Parameters.AddWithValue("@id", selectedStaffId);

                        // Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff member Update is successful.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Staff member Update fail.", "Fail !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                }
            }
            clearForm();
            loadStaffDataGrid();
        }

        private void saveStaff()
        {
            if (txtName.Text == string.Empty ||
                txtNic.Text == string.Empty ||
                txtContact.Text == string.Empty)
            {
                MessageBox.Show("Fill all required data", "Invalid Values",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create an SQL command to insert data into a table
                    string insertQuery = "INSERT INTO Staff (stId, name, nic, contact) " +
                                         "VALUES (@stId, @name, @nic, @contact)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@stId", txtStaffId.Text);
                        command.Parameters.AddWithValue("@name", txtName.Text);
                        command.Parameters.AddWithValue("@nic", txtNic.Text);
                        command.Parameters.AddWithValue("@contact", txtContact.Text);

                        // Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff member Save is successful.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Staff member Save fail.", "Fail !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                }
            }
            clearForm();
            loadStaffDataGrid();
            getNextStid();
        }

        private void combStaffId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combStaffId.SelectedIndex > 0)
            {
                string? selectedEid = combStaffId.SelectedItem.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create an SQL command to insert data into a table
                        string selectQuery = "SELECT * FROM Staff WHERE stId=@stid";

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@stid", selectedEid);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    selectedStaffId = reader.GetInt32(0);
                                    txtName.Text = reader.GetString(2);
                                    txtNic.Text = reader.GetString(3);
                                    txtContact.Text = reader.GetString(4);
                                }
                                else
                                {
                                    MessageBox.Show("No data found in the database.", "Fail !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else { clearForm(); }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
            homePage?.Show();
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            if (txtContact.TextLength == 10)
            {
                txtContact.ForeColor = Color.Green;
            }
            else
            {
                txtContact.ForeColor = Color.Red;
            }
        }

        private void txtNic_TextChanged(object sender, EventArgs e)
        {
            if (txtNic.TextLength == 10 || txtNic.TextLength == 18)
            {
                txtNic.ForeColor = Color.Green;
            }
            else
            {
                txtNic.ForeColor = Color.Red;
            }
        }
    }
}

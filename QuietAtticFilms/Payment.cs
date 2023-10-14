using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuietAtticFilms
{
    public partial class Payment : Form
    {
        public Form? homePage { get; set; }

        private const string connectionString = "Data Source=.;Initial Catalog=Quiet_Attic_Films;Integrated Security=True";

        int selectedProductionId = -1;
        int selectedPaymentId = -1;
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            LoadProductionIdCombo();
            loadPaymentDataGrid();
            getNextPaymentId();
        }

        private void getNextPaymentId()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT TOP 1 ID FROM Payment ORDER BY id DESC";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int lastID = reader.GetInt32(0);
                                if (lastID < 10)
                                {
                                    txtPaymentId.Text = "P-0" + (lastID += 1);
                                }
                                else
                                {
                                    txtPaymentId.Text = "P-" + (lastID += 1);
                                }
                            }
                            else
                            {
                                txtPaymentId.Text = "P-01";
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

        private void loadPaymentDataGrid()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT proId as 'Production ID', amount as 'Pay Amount', payDate as 'Payment Date'" +
                        " FROM Payment";
                    DataTable dt = new DataTable();
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    dgPayment.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadProductionIdCombo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT proId FROM Production";
                    DataTable dt = new DataTable();
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }

                    combProductionId.Items.Clear();
                    combProductionId.Items.Add("--SELECT--");
                    foreach (DataRow Dr in dt.Rows)
                    {
                        combProductionId.Items.Add(Dr["proId"]);
                    }
                    combProductionId.SelectedIndex = 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void combProductionId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combProductionId.SelectedIndex > 0)
            {
                string? selectedProid = combProductionId.SelectedItem.ToString();

                getProductionData(selectedProid);

                getPaymentDataForProduction();
            }
            else { clear(); }
        }

        private void getPaymentDataForProduction()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT proId as 'Production ID', amount as 'Pay Amount', payDate as 'Payment Date'" +
                        " FROM Payment WHERE proId=@proId";
                    DataTable dt = new DataTable();
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@proId", selectedProductionId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    dgPayment.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void getProductionData(string? selectedProid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create an SQL command to insert data into a table
                    string selectQuery = "SELECT Production.id, Production.proType as 'Production Type', " +
                        "Client.name as 'Client Name' FROM Production " +
                        "LEFT JOIN Client ON Client.id = Production.cId " +
                        "WHERE Production.proId = @proId";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@proId", selectedProid);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                selectedProductionId = reader.GetInt32(0);
                                txtProductionType.Text = reader.GetString(1);
                                txtClientName.Text = reader.GetString(2);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            loadPaymentDataGrid();
        }

        private void clear()
        {
            txtClientName.Text = string.Empty;
            combProductionId.SelectedIndex = 0;
            txtPaymentAmount.Text = string.Empty;
            txtProductionType.Text = string.Empty;
            if (checkSearch.Checked)
            {
                combPaymentId.SelectedIndex = 0;
            }
            else
            {
                combPaymentId.Items.Clear();
            }
        }

        private void clearPayment()
        {
            txtPaymentAmount.Text = string.Empty;
            if (checkSearch.Checked)
            {
                combPaymentId.SelectedIndex = 0;
            }
            else
            {
                combPaymentId.Items.Clear();
            }
        }

        private void checkSearch_CheckedChanged(object sender, EventArgs e)
        {
            combPaymentId.Items.Clear();
            txtPaymentId.Visible = !checkSearch.Checked;
            combPaymentId.Visible = checkSearch.Checked;
            btnSave.Text = checkSearch.Checked ? "Update" : "Save";
            locadPaymentCombo();
            combPaymentId.Focus();
        }

        private void locadPaymentCombo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT pId FROM Payment";
                    DataTable dt = new DataTable();
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }

                    combPaymentId.Items.Clear();
                    combPaymentId.Items.Add("--SELECT--");
                    foreach (DataRow Dr in dt.Rows)
                    {
                        combPaymentId.Items.Add(Dr["pId"]);
                    }
                    combPaymentId.SelectedIndex = 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult diaRes = MessageBox.Show("Are you sure, You want to Delete Payment ID: " +
                combPaymentId.Text + " record from the Database? ", "Confirm to DELETE!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create an SQL command to insert data into a table
                        string selectQuery = "DELETE FROM Payment WHERE id=@id";

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@id", selectedPaymentId);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Payment Delete is successful.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Payment Delete fail.", "Fail !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                clearPayment();
                getPaymentDataForProduction();
            }
        }

        private void combPaymentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combPaymentId.SelectedIndex > 0)
            {
                string? selectedPid = combPaymentId.SelectedItem.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create an SQL command to insert data into a table
                        string selectQuery = "SELECT * FROM Payment WHERE pId=@pid";

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@pid", selectedPid);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    selectedPaymentId = reader.GetInt32(0);
                                    txtPaymentAmount.Text = reader.GetDecimal(3).ToString("F");
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
            else { clearPayment(); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkSearch.Checked)
            {
                updatePayment();
            }
            else
            {
                savePayment();
            }
        }

        private void savePayment()
        {
            if (txtPaymentAmount.Text == string.Empty)
            {
                MessageBox.Show("Pay amount is required", "Invalid Values",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create an SQL command to insert data into a table
                    string insertQuery = "INSERT INTO Payment (proId, pId, amount, payDate) " +
                                         "VALUES (@proid, @pid, @amount, @paydate)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@proid", selectedProductionId);
                        command.Parameters.AddWithValue("@pid", txtPaymentId.Text);
                        command.Parameters.AddWithValue("@amount", txtPaymentAmount.Text);
                        command.Parameters.AddWithValue("@paydate", DateTime.Now.Date);

                        // Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payment Save is successful.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Payment Save fail.", "Fail !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                }
            }
            clearPayment();
            getPaymentDataForProduction();
            getNextPaymentId();
        }

        private void updatePayment()
        {
            if (txtPaymentAmount.Text == string.Empty)
            {
                MessageBox.Show("Pay amount is required", "Invalid Values",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create an SQL command to update data
                    string updateQuery = "UPDATE Payment SET amount = @amount " +
                                         "WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@amount", txtPaymentAmount.Text);
                        command.Parameters.AddWithValue("@id", selectedPaymentId);

                        // Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payment Update is successful.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Payment Update fail.", "Fail !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                }
            }
            clearPayment();
            getPaymentDataForProduction();
        }
    }
}

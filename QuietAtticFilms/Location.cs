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

namespace QuietAtticFilms
{
    public partial class Location : Form
    {
        private const string connectionString = "Data Source=.;Initial Catalog=Quiet_Attic_Films;Integrated Security=True";

        int selectedLocationId = -1;
        public Location()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtName.Text = string.Empty;
            combLoId.SelectedIndex = 0;
        }

        private void Location_Load(object sender, EventArgs e)
        {
            loadLocationDataGrid();
            combLoId.Items.Clear();
            loadLocationIdCombo();
            combLoId.Focus();
        }

        private void loadLocationDataGrid()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT lid as 'Location ID', name as 'Name' FROM Location";
                    DataTable dt = new DataTable();
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    dgLocation.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void loadLocationIdCombo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT lid FROM Location";
                    DataTable dt = new DataTable();
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }

                    combLoId.Items.Clear();
                    combLoId.Items.Add("--SELECT--");
                    foreach (DataRow Dr in dt.Rows)
                    {
                        combLoId.Items.Add(Dr["lId"]);
                    }
                    combLoId.SelectedIndex = 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            updateLocation();
        }

        private void updateLocation()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Location name is required", "Invalid Values",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create an SQL command to update data
                    string updateQuery = "UPDATE Location SET name = @name " +
                                         "WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@name", txtName.Text);
                        command.Parameters.AddWithValue("@id", selectedLocationId);

                        // Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Location Update is successful.");
                        }
                        else
                        {
                            MessageBox.Show("Location Update fail.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                }
            }
            clear();
            loadLocationDataGrid();
        }

        private void combLoId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combLoId.SelectedIndex > 0)
            {
                string? selectedEid = combLoId.SelectedItem.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create an SQL command to insert data into a table
                        string selectQuery = "SELECT * FROM Location WHERE lId=@lId";

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@lId", selectedEid);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    selectedLocationId = reader.GetInt32(0);
                                    txtName.Text = reader.GetString(2);
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
            DialogResult diaRes = MessageBox.Show("Are you sure, You want to Delete Location ID: " +
                combLoId.Text + " record from the Database? ", "Confirm to DELETE!",
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
                        string selectQuery = "DELETE FROM Location WHERE id=@id";

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@id", selectedLocationId);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Location Delete is successful.");
                            }
                            else
                            {
                                MessageBox.Show("Location Delete fail.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                clear();
                loadLocationDataGrid();
            }
        }
    }
}

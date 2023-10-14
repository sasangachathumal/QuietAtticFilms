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
    public partial class User : Form
    {
        public Form? homePage { get; set; }

        private const string connectionString = "Data Source=.;Initial Catalog=Quiet_Attic_Films;Integrated Security=True";

        int selectedUserId = -1;
        public User()
        {
            InitializeComponent();
        }

        private void checkSearch_CheckedChanged(object sender, EventArgs e)
        {
            combUsername.Items.Clear();
            txtUsername.Visible = !checkSearch.Checked;
            combUsername.Visible = checkSearch.Checked;
            btnSave.Text = checkSearch.Checked ? "Update" : "Save";
            locadUsernameCombo();
            combUsername.Focus();
        }

        private void locadUsernameCombo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT username FROM systemUsers";
                    DataTable dt = new DataTable();
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }

                    combUsername.Items.Clear();
                    combUsername.Items.Add("--SELECT--");
                    foreach (DataRow Dr in dt.Rows)
                    {
                        combUsername.Items.Add(Dr["username"]);
                    }
                    combUsername.SelectedIndex = 0;

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
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPWconfirm.Text = string.Empty;
            if (checkSearch.Checked)
            {
                combUsername.SelectedIndex = 0;
            }
            else
            {
                combUsername.Items.Clear();
            }
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult diaRes = MessageBox.Show("Are you sure, You want to Delete User : " +
                combUsername.SelectedText + " record from the Database? ", "Confirm to DELETE!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create an SQL command to insert data into a table
                        string selectQuery = "DELETE FROM systemUsers WHERE id=@id";

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@id", selectedUserId);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User Delete is successful.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("User Delete fail.", "Fail !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                clear();
            }
        }

        private void combUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combUsername.SelectedIndex > 0)
            {
                string? selectedUser = combUsername.SelectedItem.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create an SQL command to insert data into a table
                        string selectQuery = "SELECT * FROM systemUsers WHERE username=@username";

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@username", selectedUser);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    selectedUserId = reader.GetInt32(0);
                                    txtPassword.Text = reader.GetString(2);
                                    txtPWconfirm.Text = reader.GetString(2);
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
            else { clear(); }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkSearch.Checked)
            {
                updateUser();
            }
            else
            {
                registerUser();
            }
        }

        private void registerUser()
        {
            if (txtUsername.Text == string.Empty ||
                txtPassword.Text == string.Empty ||
                txtPWconfirm.Text == string.Empty)
            {
                MessageBox.Show("Please fill username and passowrd", "Invalid Values",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtPWconfirm.Text)
            {
                MessageBox.Show("input passwords are not matching", "Invalid Values",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create an SQL command to insert data into a table
                    string insertQuery = "INSERT INTO systemUsers (username, userPassword) " +
                                         "VALUES (@username, @password)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@username", txtUsername.Text);
                        command.Parameters.AddWithValue("@password", txtPassword.Text);

                        // Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User save is successful.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("User save fail.", "Fail !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                }
            }
            clear();
        }

        private void updateUser()
        {
            if (combUsername.SelectedIndex > 0)
            {
                string? selectedUser = combUsername.SelectedItem.ToString();
                if (txtPWconfirm.Text == string.Empty ||
                txtPassword.Text == string.Empty)
                {
                    MessageBox.Show("Please fill password and confirm passowrd", "Invalid Values",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtPassword.Text != txtPWconfirm.Text)
                {
                    MessageBox.Show("input passwords are not matching", "Invalid Values",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create an SQL command to update data
                        string updateQuery = "UPDATE systemUsers SET username = @username, " +
                                             "userPassword = @password " +
                                             "WHERE id = @id";

                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            // Add parameters to the SQL command
                            command.Parameters.AddWithValue("@username", selectedUser);
                            command.Parameters.AddWithValue("@password", txtPassword.Text);
                            command.Parameters.AddWithValue("@id", selectedUserId);

                            // Execute the SQL command
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User Update is successful.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("User Update fail.", "Fail !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);

                    }
                }
                clear();
            }
            else
            {
                MessageBox.Show("Please select a user to update", "Invalid Values",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.TextLength >= 6 && txtPassword.TextLength <= 12)
            {
                txtPassword.ForeColor = Color.Green;
            }
            else
            {
                txtPassword.ForeColor = Color.Red;
            }
        }

        private void txtPWconfirm_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPWconfirm.Text)
            {
                txtPWconfirm.ForeColor = Color.Green;
            }
            else
            {
                txtPWconfirm.ForeColor = Color.Red;
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
            homePage?.Show();
        }
    }
}

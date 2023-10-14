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
    public partial class Settings : Form
    {
        public Form? homePage { get; set; }

        private const string connectionString = "Data Source=.;Initial Catalog=Quiet_Attic_Films;Integrated Security=True";
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            loadSettingsData();
        }

        private void loadSettingsData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM Settings";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCcRate.Text = reader.GetDecimal(0).ToString("F");
                                txtRuRate.Text = reader.GetDecimal(1).ToString("F");
                                txtAcRate.Text = reader.GetDecimal(2).ToString("F");
                                txtVaRate.Text = reader.GetDecimal(3).ToString("F");
                                txtPRate.Text = reader.GetDecimal(4).ToString("F");
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCcRate.Text == string.Empty ||
                txtRuRate.Text == string.Empty ||
                txtAcRate.Text == string.Empty ||
                txtVaRate.Text == string.Empty ||
                txtPRate.Text == string.Empty)
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
                    string updateQuery = "UPDATE Settings SET cameraRate = @cRate, runnerRate = @rRate, actorRate = @aRate, " +
                                         "voiceARate = @vaRate, ProdRate = @pRate";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@cRate", txtCcRate.Text);
                        command.Parameters.AddWithValue("@rRate", txtRuRate.Text);
                        command.Parameters.AddWithValue("@aRate", txtAcRate.Text);
                        command.Parameters.AddWithValue("@vaRate", txtVaRate.Text);
                        command.Parameters.AddWithValue("@pRate", txtPRate.Text);

                        // Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Settings Update is successful.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Settings Update fail.", "Fail !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                }
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
            homePage?.Show();
        }
    }
}

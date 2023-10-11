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
    public partial class Property : Form
    {
        private const string connectionString = "Data Source=.;Initial Catalog=Quiet_Attic_Films;Integrated Security=True";

        int selectedPropertyId = -1;
        public Property()
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
            combPropType.SelectedIndex = 0;
            if (checkSearch.Checked)
            {
                combPropId.SelectedIndex = 0;
            }
            else
            {
                combPropId.Items.Clear();
            }
        }

        private void Property_Load(object sender, EventArgs e)
        {
            loadPropertyDataGrid();
            getNextPropid();
        }

        private void getNextPropid()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT TOP 1 ID FROM Property ORDER BY id DESC";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int lastID = reader.GetInt32(0);
                                if (lastID < 10)
                                {
                                    txtPropId.Text = "PROP-0" + (lastID += 1);
                                }
                                else
                                {
                                    txtPropId.Text = "PROP-" + (lastID += 1);
                                }
                            }
                            else
                            {
                                txtPropId.Text = "PROP-01";
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

        private void loadPropertyDataGrid()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT propId as 'Property ID', name as 'Name', propType as 'Property type'," +
                        "addedDate as 'Added date' FROM Property";
                    DataTable dt = new DataTable();
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    dgProp.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}

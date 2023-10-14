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
using System.Xml.Linq;

namespace QuietAtticFilms
{
    public partial class Production : Form
    {
        public Form? homePage { get; set; }

        private const string connectionString = "Data Source=.;Initial Catalog=Quiet_Attic_Films;Integrated Security=True";

        // variable hold selected Ids that selected from combo
        private int selectedProductionId;
        private int selectedLocationId;
        private int selectedPropertyId;
        private int selectedClientId;
        private int selectedStaffMemberId;

        //Object to hold selected items
        private PropertyModel selectedProperty = new PropertyModel();
        private LocationModel selectedLocation = new LocationModel();
        private StaffModel selectedStaffMember = new StaffModel();

        // list to hold add locations, properties and staff members
        private List<LocationModel> locationList = new List<LocationModel>();
        private List<PropertyModel> propertyList = new List<PropertyModel>();
        private List<StaffModel> staffMemberList = new List<StaffModel>();

        public Production()
        {
            InitializeComponent();
        }

        private void Production_Load(object sender, EventArgs e)
        {
            initDataGridViews();
            getNextProductionId();
            loadLocationCombo();
            loadClientCombo();
            loadStaffCombo();
        }

        private void initDataGridViews()
        {
            // location bind
            BindingList<LocationModel> bindingLocationList = new BindingList<LocationModel>(locationList);
            BindingSource locationSource = new BindingSource(bindingLocationList, null);
            dgLocation.DataSource = locationSource;

            // property bind
            BindingList<PropertyModel> bindingPropertyList = new BindingList<PropertyModel>(propertyList);
            BindingSource propertySource = new BindingSource(bindingPropertyList, null);
            dgProperty.DataSource = propertySource;

            // staff bind
            BindingList<StaffModel> bindingStaffList = new BindingList<StaffModel>(staffMemberList);
            BindingSource staffSource = new BindingSource(bindingStaffList, null);
            dgStaff.DataSource = staffSource;
        }

        private void loadStaffCombo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT stId FROM staff";
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

        private void getNextProductionId()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT TOP 1 ID FROM Production ORDER BY id DESC";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int lastID = reader.GetInt32(0);
                                if (lastID < 10)
                                {
                                    txtProId.Text = "Pro-0" + (lastID += 1);
                                }
                                else
                                {
                                    txtProId.Text = "Pro-" + (lastID += 1);
                                }
                            }
                            else
                            {
                                txtProId.Text = "Pro-01";
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

        private void loadClientCombo()
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

        private void loadLocationCombo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT lId FROM Location";
                    DataTable dt = new DataTable();
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }

                    combLocationId.Items.Clear();
                    combLocationId.Items.Add("--SELECT--");
                    foreach (DataRow Dr in dt.Rows)
                    {
                        combLocationId.Items.Add(Dr["lId"]);
                    }
                    combLocationId.SelectedIndex = 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void checkNeedProperty_CheckedChanged(object sender, EventArgs e)
        {
            combPropertyId.Enabled = checkNeedProperty.Checked;
            btnRemoveProperty.Enabled = checkNeedProperty.Checked;
            btnAddProperty.Enabled = checkNeedProperty.Checked;
            dgProperty.Enabled = checkNeedProperty.Checked;
            if (checkNeedProperty.Checked)
            {
                loadPropertyIdCombo();
            }
        }

        private void loadPropertyIdCombo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT propId FROM Property";
                    DataTable dt = new DataTable();
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }

                    combPropertyId.Items.Clear();
                    combPropertyId.Items.Add("--SELECT--");
                    foreach (DataRow Dr in dt.Rows)
                    {
                        combPropertyId.Items.Add(Dr["propId"]);
                    }
                    combPropertyId.SelectedIndex = 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void combPropertyId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combPropertyId.SelectedIndex > 0)
            {
                string? selectedEid = combPropertyId.SelectedItem.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create an SQL command to insert data into a table
                        string selectQuery = "SELECT * FROM Property WHERE propId=@propid";

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@propid", selectedEid);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    selectedPropertyId = reader.GetInt32(0);
                                    txtPropertyName.Text = reader.GetString(2);

                                    selectedProperty.id = reader.GetInt32(0);
                                    selectedProperty.propId = reader.GetString(1);
                                    selectedProperty.name = reader.GetString(2);
                                    selectedProperty.propType = reader.GetString(3);
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
            else
            {
                //Add clear
            }
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            if (selectedPropertyId > 0 && selectedProperty.propId != string.Empty)
            {
                propertyList.Add(selectedProperty);
                dgProperty.DataSource = propertyList;
            }
            else
            {
                MessageBox.Show("Select property to add", "invalid input!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

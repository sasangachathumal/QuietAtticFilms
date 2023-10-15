using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
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

        private int savedProductionId;

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
            getNextProductionId();
            loadLocationCombo();
            loadClientCombo();
            loadStaffCombo();
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

                    string selectQuery = "SELECT name FROM Client";
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
                        combClientId.Items.Add(Dr["name"]);
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

                                    selectedProperty = new PropertyModel();
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
                txtPropertyName.Text = string.Empty;
                combPropertyId.SelectedIndex = 0;
            }
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            if (selectedPropertyId > 0 && selectedProperty.propId != string.Empty)
            {
                propertyList.Add(selectedProperty);
                MessageBox.Show("Selected property added to the list", "Property Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Plese select property to add", "invalid input!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveProperty_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveProduction();
        }

        private void saveProduction()
        {
            if (txtProductionType.Text == string.Empty ||
                txtNoOfDays.Text == string.Empty ||
                combClientId.SelectedIndex == 0 ||
                staffMemberList.Count == 0 ||
                locationList.Count == 0)
            {
                MessageBox.Show("Please input all the required data", "Invalid Values",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create an SQL command to insert data into a table
                    string insertQuery = "INSERT INTO Production (cid, proId, proType, noOfDays, startDate, endDate) " +
                                         "VALUES (@cid, @proid, @protype, @noofdays, @startdate, @enddate)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@cid", selectedClientId);
                        command.Parameters.AddWithValue("@proid", txtProId.Text);
                        command.Parameters.AddWithValue("@protype", txtProductionType.Text);
                        command.Parameters.AddWithValue("@noofdays", txtNoOfDays.Text);
                        DateTime startDate = pickPropStartDate.Value;
                        command.Parameters.AddWithValue("@startdate", startDate.Date);
                        DateTime endDate = startDate.AddDays(int.Parse(txtNoOfDays.Text)); ;
                        command.Parameters.AddWithValue("@enddate", endDate);

                        // Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            getSaveProduction();
                            saveProductionStaff();
                            if (locationList.Count > 0)
                            {
                                saveLocation();
                            }
                            MessageBox.Show("Production Save is successful.", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Production Save fail.", "Fail !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                }
            }
            clear();
            getNextProductionId();
        }

        private void saveLocation()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    int locationIndex = -1;
                    int propertyIndex = -1;

                    foreach (LocationModel location in locationList)
                    {
                        locationIndex++;

                        if (location.PropertyList?.Count > 0)
                        {
                            // Create an SQL command to insert data into a table
                            string insertQuery = "INSERT INTO Property_Location (propId, lId) " +
                                                 "VALUES (@propId, @lId)";
                            foreach (PropertyModel property in location.PropertyList)
                            {
                                propertyIndex++;
                                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                                {
                                    // Add parameters to the SQL command
                                    command.Parameters.AddWithValue("@propId", property.id);
                                    command.Parameters.AddWithValue("@lId", location.id);

                                    // Execute the SQL command
                                    int rowsAffected = command.ExecuteNonQuery();
                                }

                                string updateQuery = "UPDATE Location SET proId = @proId " +
                                         "WHERE id = @id";

                                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                                {
                                    // Add parameters to the SQL command
                                    command.Parameters.AddWithValue("@proId", savedProductionId);
                                    command.Parameters.AddWithValue("@id", location.id);

                                    // Execute the SQL command
                                    int rowsAffected = command.ExecuteNonQuery();
                                }
                            }
                        }
                        else
                        {
                            string updateQuery = "UPDATE Location SET proId = @proId " +
                                         "WHERE id = @id";

                            using (SqlCommand command = new SqlCommand(updateQuery, connection))
                            {
                                // Add parameters to the SQL command
                                command.Parameters.AddWithValue("@proId", savedProductionId);
                                command.Parameters.AddWithValue("@id", location.id);

                                // Execute the SQL command
                                int rowsAffected = command.ExecuteNonQuery();
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

        private void getSaveProduction()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create an SQL command to insert data into a table
                    string selectQuery = "SELECT * FROM Production WHERE proId=@proid";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@proid", txtProId.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                savedProductionId = reader.GetInt32(0);
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

        private void saveProductionStaff()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create an SQL command to insert data into a table
                    string insertQuery = "INSERT INTO Production_Staff (proId, stId, roleName) " +
                                         "VALUES (@proId, @stId, @roleName)";

                    int index = -1;

                    foreach (StaffModel member in staffMemberList)
                    {
                        index++;
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            // Add parameters to the SQL command
                            command.Parameters.AddWithValue("@proId", savedProductionId);
                            command.Parameters.AddWithValue("@stId", member.id);
                            command.Parameters.AddWithValue("@roleName", member.role);

                            // Execute the SQL command
                            int rowsAffected = command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                }
            }
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            if (selectedLocationId > 0 && selectedLocation.lId != string.Empty)
            {
                selectedLocation.PropertyList = propertyList;
                locationList.Add(selectedLocation);
                MessageBox.Show("Selected location added to the list", "Property Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedPropertyId = 0;
                selectedProperty = new PropertyModel();
                propertyList = new List<PropertyModel>();
            }
            else
            {
                MessageBox.Show("Plese select location to add", "invalid input!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void combLocationId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combLocationId.SelectedIndex > 0)
            {
                string? selectedId = combLocationId.SelectedItem.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create an SQL command to insert data into a table
                        string selectQuery = "SELECT * FROM Location WHERE lId=@lid";

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@lid", selectedId);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    selectedLocationId = reader.GetInt32(0);
                                    txtLocationName.Text = reader.GetString(3);

                                    selectedLocation = new LocationModel();
                                    selectedLocation.id = reader.GetInt32(0);
                                    selectedLocation.proId = reader.GetInt32(1);
                                    selectedLocation.lId = reader.GetString(2);
                                    selectedLocation.name = reader.GetString(3);
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
                txtLocationName.Text = string.Empty;
                combLocationId.SelectedIndex = 0;
            }
        }

        private void combClientId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combClientId.SelectedIndex > 0)
            {
                string? selectedName = combClientId.SelectedItem.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create an SQL command to insert data into a table
                        string selectQuery = "SELECT * FROM Client WHERE name=@name";

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@name", selectedName);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    selectedClientId = reader.GetInt32(0);
                                    txtClientAddress.Text = reader.GetString(4);
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
                txtClientAddress.Text = string.Empty;
                combClientId.SelectedIndex = 0;
            }
        }

        private void combStaffId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combStaffId.SelectedIndex > 0)
            {
                string? selectedId = combStaffId.SelectedItem.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create an SQL command to insert data into a table
                        string selectQuery = "SELECT * FROM Staff WHERE stId=@stid";

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@stid", selectedId);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    selectedStaffMemberId = reader.GetInt32(0);
                                    txtStaffName.Text = reader.GetString(2);

                                    selectedStaffMember = new StaffModel();
                                    selectedStaffMember.id = reader.GetInt32(0);
                                    selectedStaffMember.stId = reader.GetString(1);
                                    selectedStaffMember.name = reader.GetString(2);
                                    selectedStaffMember.nic = reader.GetString(3);
                                    selectedStaffMember.contact = reader.GetString(3);
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
                txtStaffName.Text = string.Empty;
                combStaffRole.SelectedIndex = 0;
                combStaffId.SelectedIndex = 0;
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (selectedStaffMemberId > 0 && selectedStaffMember.id != 0 && combStaffRole.SelectedIndex > 0)
            {
                selectedStaffMember.role = combStaffRole.SelectedItem.ToString();
                staffMemberList.Add(selectedStaffMember);
                MessageBox.Show("Selected staff member added to the list", "Property Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Plese select staff member and role to add", "invalid input!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clear()
        {
            txtClientAddress.Text = string.Empty;
            txtLocationName.Text = string.Empty;
            txtNoOfDays.Text = string.Empty;
            txtProductionType.Text = string.Empty;
            txtPropertyName.Text = string.Empty;
            txtStaffName.Text = string.Empty;

            combClientId.SelectedIndex = 0;
            combStaffRole.SelectedIndex = 0;
            combLocationId.SelectedIndex = 0;
            combPropertyId.SelectedIndex = 0;
            combStaffId.SelectedIndex = 0;

            locationList = new List<LocationModel>();
            propertyList = new List<PropertyModel>();
            staffMemberList = new List<StaffModel>();

            selectedClientId = 0;
            selectedLocationId = 0;
            selectedProductionId = 0;
            selectedPropertyId = 0;
            selectedStaffMemberId = 0;

            savedProductionId = 0;

            selectedStaffMember = new StaffModel();
            selectedLocation = new LocationModel();
            selectedProperty = new PropertyModel();

            if (checkLocationSearch.Checked)
            {
                loadLocationCombo();
                checkLocationSearch.Checked = false;
            }

            if (checkNeedProperty.Checked)
            {
                checkNeedProperty.Checked = false;
            }

            if (checkStaffSearch.Checked)
            {
                loadStaffCombo();
                checkStaffSearch.Checked = false;
            }
            loadClientCombo();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void checkLocationSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLocationSearch.Checked)
            {
                combLocationId.Items.Clear();
                combLocationId.Items.Add("--SELECT--");
                foreach (LocationModel location in locationList)
                {
                    combLocationId.Items.Add(location.lId);
                }
                combLocationId.SelectedIndex = 0;
            }
            else
            {
                loadLocationCombo();
            }
        }
    }
}

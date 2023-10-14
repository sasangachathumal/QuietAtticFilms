namespace QuietAtticFilms
{
    partial class Production
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label6 = new Label();
            label5 = new Label();
            btnRemoveProperty = new Button();
            combClientId = new ComboBox();
            checkProSearch = new CheckBox();
            label1 = new Label();
            pickPropStartDate = new DateTimePicker();
            groupBox1 = new GroupBox();
            txtClientAddress = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtProductionType = new TextBox();
            label8 = new Label();
            txtNoOfDays = new TextBox();
            label7 = new Label();
            label4 = new Label();
            txtProId = new TextBox();
            label3 = new Label();
            combProId = new ComboBox();
            checkNeedProperty = new CheckBox();
            groupBox3 = new GroupBox();
            btnRemoveLocation = new Button();
            btnAddLocation = new Button();
            dgLocation = new DataGridView();
            combLocationId = new ComboBox();
            groupBox4 = new GroupBox();
            btnAddProperty = new Button();
            label12 = new Label();
            dgProperty = new DataGridView();
            txtPropertyName = new TextBox();
            label13 = new Label();
            combPropertyId = new ComboBox();
            txtLocationName = new TextBox();
            label9 = new Label();
            label10 = new Label();
            btnDelete = new Button();
            btnSave = new Button();
            btnClear = new Button();
            groupBox5 = new GroupBox();
            btnRemoveStaff = new Button();
            dgStaff = new DataGridView();
            btnAddStaff = new Button();
            label15 = new Label();
            combStaffRole = new ComboBox();
            txtStaffName = new TextBox();
            label14 = new Label();
            label11 = new Label();
            combStaffId = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLocation).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProperty).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgStaff).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Righteous", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(301, 10);
            label6.Name = "label6";
            label6.Size = new Size(405, 41);
            label6.TabIndex = 15;
            label6.Text = "Production Management";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Image = Properties.Resources.back;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Padding = new Padding(8);
            label5.Size = new Size(32, 34);
            label5.TabIndex = 14;
            label5.Text = "  ";
            // 
            // btnRemoveProperty
            // 
            btnRemoveProperty.Cursor = Cursors.Hand;
            btnRemoveProperty.Enabled = false;
            btnRemoveProperty.FlatStyle = FlatStyle.Flat;
            btnRemoveProperty.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveProperty.ForeColor = Color.Firebrick;
            btnRemoveProperty.Location = new Point(272, 93);
            btnRemoveProperty.Name = "btnRemoveProperty";
            btnRemoveProperty.Size = new Size(84, 31);
            btnRemoveProperty.TabIndex = 16;
            btnRemoveProperty.Text = "Remove";
            btnRemoveProperty.UseVisualStyleBackColor = true;
            // 
            // combClientId
            // 
            combClientId.DropDownStyle = ComboBoxStyle.DropDownList;
            combClientId.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            combClientId.FormattingEnabled = true;
            combClientId.Location = new Point(168, 29);
            combClientId.Name = "combClientId";
            combClientId.Size = new Size(276, 26);
            combClientId.TabIndex = 17;
            // 
            // checkProSearch
            // 
            checkProSearch.AutoSize = true;
            checkProSearch.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkProSearch.Location = new Point(253, 34);
            checkProSearch.Name = "checkProSearch";
            checkProSearch.Size = new Size(77, 22);
            checkProSearch.TabIndex = 18;
            checkProSearch.Text = "Search";
            checkProSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(102, 18);
            label1.TabIndex = 19;
            label1.Text = "Client Name :";
            // 
            // pickPropStartDate
            // 
            pickPropStartDate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pickPropStartDate.Format = DateTimePickerFormat.Short;
            pickPropStartDate.Location = new Point(114, 128);
            pickPropStartDate.Name = "pickPropStartDate";
            pickPropStartDate.Size = new Size(215, 26);
            pickPropStartDate.TabIndex = 20;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtClientAddress);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(combClientId);
            groupBox1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(491, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 168);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Client Info";
            // 
            // txtClientAddress
            // 
            txtClientAddress.Enabled = false;
            txtClientAddress.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtClientAddress.Location = new Point(168, 64);
            txtClientAddress.Name = "txtClientAddress";
            txtClientAddress.Size = new Size(276, 26);
            txtClientAddress.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 67);
            label2.Name = "label2";
            label2.Size = new Size(118, 18);
            label2.TabIndex = 20;
            label2.Text = "Client Address :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(txtProductionType);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtNoOfDays);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(checkProSearch);
            groupBox2.Controls.Add(pickPropStartDate);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtProId);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 67);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(473, 168);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Production Info";
            // 
            // txtProductionType
            // 
            txtProductionType.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductionType.Location = new Point(115, 64);
            txtProductionType.Name = "txtProductionType";
            txtProductionType.Size = new Size(215, 26);
            txtProductionType.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 134);
            label8.Name = "label8";
            label8.Size = new Size(87, 18);
            label8.TabIndex = 28;
            label8.Text = "Start Date :";
            // 
            // txtNoOfDays
            // 
            txtNoOfDays.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoOfDays.Location = new Point(114, 96);
            txtNoOfDays.Name = "txtNoOfDays";
            txtNoOfDays.Size = new Size(215, 26);
            txtNoOfDays.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(6, 99);
            label7.Name = "label7";
            label7.Size = new Size(96, 18);
            label7.TabIndex = 27;
            label7.Text = "No Of Days :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 67);
            label4.Name = "label4";
            label4.Size = new Size(78, 18);
            label4.TabIndex = 25;
            label4.Text = "Pro Type :";
            // 
            // txtProId
            // 
            txtProId.Enabled = false;
            txtProId.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProId.Location = new Point(114, 32);
            txtProId.Name = "txtProId";
            txtProId.Size = new Size(133, 26);
            txtProId.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 35);
            label3.Name = "label3";
            label3.Size = new Size(57, 18);
            label3.TabIndex = 24;
            label3.Text = "Pro Id :";
            // 
            // combProId
            // 
            combProId.DropDownStyle = ComboBoxStyle.DropDownList;
            combProId.FormattingEnabled = true;
            combProId.Location = new Point(83, 24);
            combProId.Name = "combProId";
            combProId.Size = new Size(133, 26);
            combProId.TabIndex = 24;
            // 
            // checkNeedProperty
            // 
            checkNeedProperty.AutoSize = true;
            checkNeedProperty.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkNeedProperty.Location = new Point(6, 92);
            checkNeedProperty.Name = "checkNeedProperty";
            checkNeedProperty.Size = new Size(210, 22);
            checkNeedProperty.TabIndex = 30;
            checkNeedProperty.Text = "Location need properties?";
            checkNeedProperty.UseVisualStyleBackColor = true;
            checkNeedProperty.CheckedChanged += checkNeedProperty_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(btnRemoveLocation);
            groupBox3.Controls.Add(btnAddLocation);
            groupBox3.Controls.Add(dgLocation);
            groupBox3.Controls.Add(combLocationId);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(txtLocationName);
            groupBox3.Controls.Add(checkNeedProperty);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 241);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(473, 546);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            groupBox3.Text = "Location Info";
            // 
            // btnRemoveLocation
            // 
            btnRemoveLocation.Cursor = Cursors.Hand;
            btnRemoveLocation.FlatStyle = FlatStyle.Flat;
            btnRemoveLocation.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveLocation.ForeColor = Color.Firebrick;
            btnRemoveLocation.Location = new Point(272, 385);
            btnRemoveLocation.Name = "btnRemoveLocation";
            btnRemoveLocation.Size = new Size(90, 31);
            btnRemoveLocation.TabIndex = 43;
            btnRemoveLocation.Text = "Remove";
            btnRemoveLocation.UseVisualStyleBackColor = true;
            // 
            // btnAddLocation
            // 
            btnAddLocation.Cursor = Cursors.Hand;
            btnAddLocation.FlatStyle = FlatStyle.Flat;
            btnAddLocation.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddLocation.ForeColor = Color.RoyalBlue;
            btnAddLocation.Location = new Point(377, 385);
            btnAddLocation.Name = "btnAddLocation";
            btnAddLocation.Size = new Size(90, 31);
            btnAddLocation.TabIndex = 42;
            btnAddLocation.Text = "Add";
            btnAddLocation.UseVisualStyleBackColor = true;
            // 
            // dgLocation
            // 
            dgLocation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgLocation.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgLocation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgLocation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgLocation.DefaultCellStyle = dataGridViewCellStyle2;
            dgLocation.Location = new Point(6, 422);
            dgLocation.Name = "dgLocation";
            dgLocation.RowTemplate.Height = 25;
            dgLocation.Size = new Size(461, 117);
            dgLocation.TabIndex = 42;
            // 
            // combLocationId
            // 
            combLocationId.DropDownStyle = ComboBoxStyle.DropDownList;
            combLocationId.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            combLocationId.FormattingEnabled = true;
            combLocationId.Location = new Point(129, 28);
            combLocationId.Name = "combLocationId";
            combLocationId.Size = new Size(133, 26);
            combLocationId.TabIndex = 32;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnAddProperty);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(dgProperty);
            groupBox4.Controls.Add(txtPropertyName);
            groupBox4.Controls.Add(btnRemoveProperty);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(combPropertyId);
            groupBox4.Location = new Point(6, 120);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(461, 259);
            groupBox4.TabIndex = 42;
            groupBox4.TabStop = false;
            groupBox4.Text = "Property Info";
            // 
            // btnAddProperty
            // 
            btnAddProperty.Cursor = Cursors.Hand;
            btnAddProperty.Enabled = false;
            btnAddProperty.FlatStyle = FlatStyle.Flat;
            btnAddProperty.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProperty.ForeColor = Color.RoyalBlue;
            btnAddProperty.Location = new Point(371, 93);
            btnAddProperty.Name = "btnAddProperty";
            btnAddProperty.Size = new Size(84, 31);
            btnAddProperty.TabIndex = 42;
            btnAddProperty.Text = "Add";
            btnAddProperty.UseVisualStyleBackColor = true;
            btnAddProperty.Click += btnAddProperty_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(6, 32);
            label12.Name = "label12";
            label12.Size = new Size(91, 18);
            label12.TabIndex = 36;
            label12.Text = "Property Id :";
            // 
            // dgProperty
            // 
            dgProperty.AllowUserToAddRows = false;
            dgProperty.AllowUserToDeleteRows = false;
            dgProperty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProperty.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgProperty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgProperty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgProperty.DefaultCellStyle = dataGridViewCellStyle4;
            dgProperty.Enabled = false;
            dgProperty.Location = new Point(7, 130);
            dgProperty.MultiSelect = false;
            dgProperty.Name = "dgProperty";
            dgProperty.RowTemplate.Height = 25;
            dgProperty.ShowEditingIcon = false;
            dgProperty.ShowRowErrors = false;
            dgProperty.Size = new Size(448, 123);
            dgProperty.TabIndex = 41;
            // 
            // txtPropertyName
            // 
            txtPropertyName.Enabled = false;
            txtPropertyName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPropertyName.Location = new Point(131, 61);
            txtPropertyName.Name = "txtPropertyName";
            txtPropertyName.Size = new Size(216, 26);
            txtPropertyName.TabIndex = 39;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(7, 64);
            label13.Name = "label13";
            label13.Size = new Size(121, 18);
            label13.TabIndex = 40;
            label13.Text = "Property Name :";
            // 
            // combPropertyId
            // 
            combPropertyId.DropDownStyle = ComboBoxStyle.DropDownList;
            combPropertyId.Enabled = false;
            combPropertyId.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            combPropertyId.FormattingEnabled = true;
            combPropertyId.Location = new Point(131, 29);
            combPropertyId.Name = "combPropertyId";
            combPropertyId.Size = new Size(133, 26);
            combPropertyId.TabIndex = 33;
            combPropertyId.SelectedIndexChanged += combPropertyId_SelectedIndexChanged;
            // 
            // txtLocationName
            // 
            txtLocationName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLocationName.Location = new Point(129, 60);
            txtLocationName.Name = "txtLocationName";
            txtLocationName.Size = new Size(274, 26);
            txtLocationName.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(6, 63);
            label9.Name = "label9";
            label9.Size = new Size(122, 18);
            label9.TabIndex = 33;
            label9.Text = "Location Name :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(6, 31);
            label10.Name = "label10";
            label10.Size = new Size(92, 18);
            label10.TabIndex = 31;
            label10.Text = "Location Id :";
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.DarkRed;
            btnDelete.Location = new Point(491, 686);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(450, 36);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "Delete Production";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.DarkSlateBlue;
            btnSave.Location = new Point(491, 619);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(450, 36);
            btnSave.TabIndex = 33;
            btnSave.Text = "Save Production Data";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.SteelBlue;
            btnClear.Location = new Point(491, 751);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(450, 36);
            btnClear.TabIndex = 32;
            btnClear.Text = "Clear Form";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Transparent;
            groupBox5.Controls.Add(btnRemoveStaff);
            groupBox5.Controls.Add(dgStaff);
            groupBox5.Controls.Add(btnAddStaff);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(combStaffRole);
            groupBox5.Controls.Add(txtStaffName);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(combStaffId);
            groupBox5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(491, 241);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(450, 313);
            groupBox5.TabIndex = 35;
            groupBox5.TabStop = false;
            groupBox5.Text = "Staff Info";
            // 
            // btnRemoveStaff
            // 
            btnRemoveStaff.Cursor = Cursors.Hand;
            btnRemoveStaff.FlatStyle = FlatStyle.Flat;
            btnRemoveStaff.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveStaff.ForeColor = Color.Firebrick;
            btnRemoveStaff.Location = new Point(261, 124);
            btnRemoveStaff.Name = "btnRemoveStaff";
            btnRemoveStaff.Size = new Size(84, 31);
            btnRemoveStaff.TabIndex = 43;
            btnRemoveStaff.Text = "Remove";
            btnRemoveStaff.UseVisualStyleBackColor = true;
            // 
            // dgStaff
            // 
            dgStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgStaff.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgStaff.DefaultCellStyle = dataGridViewCellStyle6;
            dgStaff.Location = new Point(6, 161);
            dgStaff.Name = "dgStaff";
            dgStaff.RowTemplate.Height = 25;
            dgStaff.Size = new Size(438, 142);
            dgStaff.TabIndex = 42;
            // 
            // btnAddStaff
            // 
            btnAddStaff.Cursor = Cursors.Hand;
            btnAddStaff.FlatStyle = FlatStyle.Flat;
            btnAddStaff.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddStaff.ForeColor = Color.RoyalBlue;
            btnAddStaff.Location = new Point(360, 124);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.Size = new Size(84, 31);
            btnAddStaff.TabIndex = 42;
            btnAddStaff.Text = "Add";
            btnAddStaff.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(6, 95);
            label15.Name = "label15";
            label15.Size = new Size(146, 18);
            label15.TabIndex = 27;
            label15.Text = "Staff Member Role :";
            // 
            // combStaffRole
            // 
            combStaffRole.DropDownStyle = ComboBoxStyle.DropDownList;
            combStaffRole.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            combStaffRole.FormattingEnabled = true;
            combStaffRole.Items.AddRange(new object[] { "Camera Crew", "Runner", "Actor", "Voice Actor", "Producer" });
            combStaffRole.Location = new Point(168, 92);
            combStaffRole.Name = "combStaffRole";
            combStaffRole.Size = new Size(276, 26);
            combStaffRole.TabIndex = 26;
            // 
            // txtStaffName
            // 
            txtStaffName.Enabled = false;
            txtStaffName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(168, 60);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(276, 26);
            txtStaffName.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(6, 63);
            label14.Name = "label14";
            label14.Size = new Size(156, 18);
            label14.TabIndex = 24;
            label14.Text = "Staff Member Name :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(6, 31);
            label11.Name = "label11";
            label11.Size = new Size(126, 18);
            label11.TabIndex = 25;
            label11.Text = "Staff Member Id :";
            // 
            // combStaffId
            // 
            combStaffId.DropDownStyle = ComboBoxStyle.DropDownList;
            combStaffId.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            combStaffId.FormattingEnabled = true;
            combStaffId.Location = new Point(168, 28);
            combStaffId.Name = "combStaffId";
            combStaffId.Size = new Size(276, 26);
            combStaffId.TabIndex = 24;
            // 
            // Production
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(950, 797);
            ControlBox = false;
            Controls.Add(groupBox5);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(groupBox3);
            Controls.Add(combProId);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Production";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Production";
            Load += Production_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgLocation).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgProperty).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Button btnRemoveProperty;
        private ComboBox combClientId;
        private CheckBox checkProSearch;
        private Label label1;
        private DateTimePicker pickPropStartDate;
        private GroupBox groupBox1;
        private TextBox txtClientAddress;
        private Label label2;
        private GroupBox groupBox2;
        private Label label3;
        private Label label8;
        private TextBox txtNoOfDays;
        private Label label7;
        private Label label4;
        private TextBox txtProId;
        private ComboBox combProId;
        private CheckBox checkNeedProperty;
        private GroupBox groupBox3;
        private ComboBox combLocationId;
        private TextBox txtLocationName;
        private Label label9;
        private Label label10;
        private ComboBox combPropertyId;
        private Label label12;
        private TextBox txtPropertyName;
        private Label label13;
        private DataGridView dgProperty;
        private Button btnAddLocation;
        private DataGridView dgLocation;
        private GroupBox groupBox4;
        private Button btnDelete;
        private Button btnSave;
        private Button btnClear;
        private GroupBox groupBox5;
        private Label label11;
        private ComboBox combStaffId;
        private DataGridView dgStaff;
        private Button btnAddStaff;
        private Label label15;
        private ComboBox combStaffRole;
        private TextBox txtStaffName;
        private Label label14;
        private TextBox txtProductionType;
        private Button btnAddProperty;
        private Button btnRemoveLocation;
        private Button btnRemoveStaff;
    }
}
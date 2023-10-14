namespace QuietAtticFilms
{
    partial class Staff
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
            label6 = new Label();
            lblBack = new Label();
            checkSearch = new CheckBox();
            combStaffId = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtContact = new TextBox();
            label4 = new Label();
            txtNic = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtStaffId = new TextBox();
            btnDelete = new Button();
            btnSave = new Button();
            btnClear = new Button();
            dgStaff = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgStaff).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Righteous", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(179, 9);
            label6.Name = "label6";
            label6.Size = new Size(313, 41);
            label6.TabIndex = 17;
            label6.Text = "Staff Management";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Cursor = Cursors.Hand;
            lblBack.Image = Properties.Resources.back;
            lblBack.Location = new Point(12, 9);
            lblBack.Name = "lblBack";
            lblBack.Padding = new Padding(8);
            lblBack.Size = new Size(32, 34);
            lblBack.TabIndex = 16;
            lblBack.Text = "  ";
            lblBack.Click += lblBack_Click;
            // 
            // checkSearch
            // 
            checkSearch.AutoSize = true;
            checkSearch.Location = new Point(235, 39);
            checkSearch.Name = "checkSearch";
            checkSearch.Size = new Size(77, 22);
            checkSearch.TabIndex = 19;
            checkSearch.Text = "Search";
            checkSearch.UseVisualStyleBackColor = true;
            checkSearch.CheckedChanged += checkSearch_CheckedChanged;
            // 
            // combStaffId
            // 
            combStaffId.DropDownStyle = ComboBoxStyle.DropDownList;
            combStaffId.FormattingEnabled = true;
            combStaffId.Location = new Point(92, 37);
            combStaffId.Name = "combStaffId";
            combStaffId.Size = new Size(137, 26);
            combStaffId.TabIndex = 20;
            combStaffId.Visible = false;
            combStaffId.SelectedIndexChanged += combStaffId_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(67, 18);
            label1.TabIndex = 21;
            label1.Text = "Staff ID :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtContact);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(checkSearch);
            groupBox1.Controls.Add(txtNic);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(combStaffId);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtStaffId);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(692, 131);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Info";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(505, 80);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(171, 26);
            txtContact.TabIndex = 29;
            txtContact.TextChanged += txtContact_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(419, 83);
            label4.Name = "label4";
            label4.Size = new Size(70, 18);
            label4.TabIndex = 28;
            label4.Text = "Contact :";
            // 
            // txtNic
            // 
            txtNic.Location = new Point(505, 37);
            txtNic.Name = "txtNic";
            txtNic.Size = new Size(171, 26);
            txtNic.TabIndex = 27;
            txtNic.TextChanged += txtNic_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(419, 40);
            label3.Name = "label3";
            label3.Size = new Size(42, 18);
            label3.TabIndex = 26;
            label3.Text = "NIC :";
            // 
            // txtName
            // 
            txtName.Location = new Point(92, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 26);
            txtName.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 83);
            label2.Name = "label2";
            label2.Size = new Size(58, 18);
            label2.TabIndex = 24;
            label2.Text = "Name :";
            // 
            // txtStaffId
            // 
            txtStaffId.Enabled = false;
            txtStaffId.Location = new Point(92, 37);
            txtStaffId.Name = "txtStaffId";
            txtStaffId.Size = new Size(137, 26);
            txtStaffId.TabIndex = 23;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.DarkRed;
            btnDelete.Location = new Point(513, 218);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 36);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.DarkSlateBlue;
            btnSave.Location = new Point(407, 218);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 36);
            btnSave.TabIndex = 32;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.SteelBlue;
            btnClear.Location = new Point(618, 218);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 36);
            btnClear.TabIndex = 31;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgStaff
            // 
            dgStaff.AllowUserToAddRows = false;
            dgStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgStaff.BackgroundColor = Color.Gainsboro;
            dgStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStaff.ImeMode = ImeMode.Off;
            dgStaff.Location = new Point(12, 274);
            dgStaff.MultiSelect = false;
            dgStaff.Name = "dgStaff";
            dgStaff.ReadOnly = true;
            dgStaff.RowTemplate.Height = 25;
            dgStaff.ShowCellErrors = false;
            dgStaff.ShowCellToolTips = false;
            dgStaff.ShowEditingIcon = false;
            dgStaff.ShowRowErrors = false;
            dgStaff.Size = new Size(692, 234);
            dgStaff.TabIndex = 34;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(716, 521);
            ControlBox = false;
            Controls.Add(dgStaff);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(lblBack);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Staff";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff";
            Load += Staff_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label lblBack;
        private CheckBox checkSearch;
        private ComboBox combStaffId;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtContact;
        private Label label4;
        private TextBox txtNic;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtStaffId;
        private Button btnDelete;
        private Button btnSave;
        private Button btnClear;
        private DataGridView dgStaff;
    }
}
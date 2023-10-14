namespace QuietAtticFilms
{
    partial class Property
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
            btnDelete = new Button();
            btnSave = new Button();
            btnClear = new Button();
            dgProp = new DataGridView();
            groupBox1 = new GroupBox();
            combPropId = new ComboBox();
            combPropType = new ComboBox();
            checkSearch = new CheckBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtPropId = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgProp).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Righteous", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(212, 9);
            label6.Name = "label6";
            label6.Size = new Size(371, 41);
            label6.TabIndex = 19;
            label6.Text = "Property Management";
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
            lblBack.TabIndex = 18;
            lblBack.Text = "  ";
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.DarkRed;
            btnDelete.Location = new Point(538, 215);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 36);
            btnDelete.TabIndex = 36;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.DarkSlateBlue;
            btnSave.Location = new Point(432, 215);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 36);
            btnSave.TabIndex = 35;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.SteelBlue;
            btnClear.Location = new Point(643, 215);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 36);
            btnClear.TabIndex = 34;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgProp
            // 
            dgProp.AllowUserToAddRows = false;
            dgProp.AllowUserToDeleteRows = false;
            dgProp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProp.BackgroundColor = Color.Gainsboro;
            dgProp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProp.Location = new Point(12, 272);
            dgProp.Name = "dgProp";
            dgProp.ReadOnly = true;
            dgProp.RowTemplate.Height = 25;
            dgProp.ShowEditingIcon = false;
            dgProp.ShowRowErrors = false;
            dgProp.Size = new Size(717, 238);
            dgProp.TabIndex = 37;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(combPropId);
            groupBox1.Controls.Add(combPropType);
            groupBox1.Controls.Add(checkSearch);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPropId);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(717, 131);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Property Info";
            // 
            // combPropId
            // 
            combPropId.DropDownStyle = ComboBoxStyle.DropDownList;
            combPropId.FormattingEnabled = true;
            combPropId.Location = new Point(149, 37);
            combPropId.Name = "combPropId";
            combPropId.Size = new Size(137, 26);
            combPropId.TabIndex = 20;
            combPropId.Visible = false;
            combPropId.SelectedIndexChanged += combPropId_SelectedIndexChanged;
            // 
            // combPropType
            // 
            combPropType.DropDownStyle = ComboBoxStyle.DropDownList;
            combPropType.FormattingEnabled = true;
            combPropType.Items.AddRange(new object[] { "- select -", "Vehicle", "Furniture", "Building" });
            combPropType.Location = new Point(512, 80);
            combPropType.Name = "combPropType";
            combPropType.Size = new Size(190, 26);
            combPropType.TabIndex = 27;
            // 
            // checkSearch
            // 
            checkSearch.AutoSize = true;
            checkSearch.Location = new Point(292, 39);
            checkSearch.Name = "checkSearch";
            checkSearch.Size = new Size(77, 22);
            checkSearch.TabIndex = 19;
            checkSearch.Text = "Search";
            checkSearch.UseVisualStyleBackColor = true;
            checkSearch.CheckedChanged += checkSearch_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(394, 83);
            label3.Name = "label3";
            label3.Size = new Size(112, 18);
            label3.TabIndex = 26;
            label3.Text = "Property Type :";
            // 
            // txtName
            // 
            txtName.Location = new Point(149, 80);
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
            // txtPropId
            // 
            txtPropId.Enabled = false;
            txtPropId.Location = new Point(149, 37);
            txtPropId.Name = "txtPropId";
            txtPropId.Size = new Size(137, 26);
            txtPropId.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(91, 18);
            label1.TabIndex = 21;
            label1.Text = "Property Id :";
            // 
            // Property
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(742, 522);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(dgProp);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(label6);
            Controls.Add(lblBack);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Property";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Property";
            Load += Property_Load;
            ((System.ComponentModel.ISupportInitialize)dgProp).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label lblBack;
        private Button btnDelete;
        private Button btnSave;
        private Button btnClear;
        private DataGridView dgProp;
        private GroupBox groupBox1;
        private ComboBox combPropType;
        private CheckBox checkSearch;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtPropId;
        private Label label1;
        private ComboBox combPropId;
    }
}
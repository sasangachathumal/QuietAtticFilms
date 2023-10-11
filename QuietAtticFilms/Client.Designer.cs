namespace QuietAtticFilms
{
    partial class Client
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClear = new Button();
            checkSearch = new CheckBox();
            combClientId = new ComboBox();
            txtClientId = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtAddress = new TextBox();
            label3 = new Label();
            txtContact = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            label5 = new Label();
            dgClient = new DataGridView();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgClient).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.SteelBlue;
            btnClear.Location = new Point(570, 195);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 36);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // checkSearch
            // 
            checkSearch.AutoSize = true;
            checkSearch.Cursor = Cursors.Hand;
            checkSearch.Location = new Point(226, 35);
            checkSearch.Name = "checkSearch";
            checkSearch.Size = new Size(77, 22);
            checkSearch.TabIndex = 1;
            checkSearch.Text = "Search";
            checkSearch.UseVisualStyleBackColor = true;
            checkSearch.CheckedChanged += checkSearch_CheckedChanged;
            // 
            // combClientId
            // 
            combClientId.DropDownStyle = ComboBoxStyle.DropDownList;
            combClientId.FormattingEnabled = true;
            combClientId.Location = new Point(83, 33);
            combClientId.Name = "combClientId";
            combClientId.Size = new Size(137, 26);
            combClientId.TabIndex = 2;
            combClientId.Visible = false;
            combClientId.SelectedIndexChanged += combClientId_SelectedIndexChanged;
            // 
            // txtClientId
            // 
            txtClientId.Enabled = false;
            txtClientId.Location = new Point(83, 33);
            txtClientId.Name = "txtClientId";
            txtClientId.ReadOnly = true;
            txtClientId.Size = new Size(137, 26);
            txtClientId.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(72, 18);
            label1.TabIndex = 4;
            label1.Text = "Client Id :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtContact);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(combClientId);
            groupBox1.Controls.Add(checkSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtClientId);
            groupBox1.Location = new Point(12, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(644, 120);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Client Info";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 80);
            label4.Name = "label4";
            label4.Size = new Size(75, 18);
            label4.TabIndex = 10;
            label4.Text = "Address :";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(428, 77);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(208, 26);
            txtAddress.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 36);
            label3.Name = "label3";
            label3.Size = new Size(74, 18);
            label3.TabIndex = 8;
            label3.Text = "Contact : ";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(424, 33);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(208, 26);
            txtContact.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 80);
            label2.Name = "label2";
            label2.Size = new Size(58, 18);
            label2.TabIndex = 6;
            label2.Text = "Name :";
            // 
            // txtName
            // 
            txtName.Location = new Point(83, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(208, 26);
            txtName.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.DarkSlateBlue;
            btnSave.Location = new Point(359, 195);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 36);
            btnSave.TabIndex = 6;
            btnSave.Text = "Register";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.DarkRed;
            btnDelete.Location = new Point(465, 195);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 36);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
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
            label5.TabIndex = 11;
            label5.Text = "  ";
            // 
            // dgClient
            // 
            dgClient.AllowUserToAddRows = false;
            dgClient.AllowUserToDeleteRows = false;
            dgClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgClient.BackgroundColor = Color.Gainsboro;
            dgClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgClient.Location = new Point(12, 248);
            dgClient.MultiSelect = false;
            dgClient.Name = "dgClient";
            dgClient.ReadOnly = true;
            dgClient.RowTemplate.Height = 25;
            dgClient.ShowEditingIcon = false;
            dgClient.Size = new Size(644, 232);
            dgClient.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Righteous", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(184, 9);
            label6.Name = "label6";
            label6.Size = new Size(320, 41);
            label6.TabIndex = 13;
            label6.Text = "Client Management";
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(668, 492);
            ControlBox = false;
            Controls.Add(label6);
            Controls.Add(dgClient);
            Controls.Add(label5);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Controls.Add(btnClear);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Client";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client Management";
            Load += Client_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgClient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private CheckBox checkSearch;
        private ComboBox combClientId;
        private TextBox txtClientId;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtContact;
        private Label label2;
        private TextBox txtName;
        private Label label4;
        private TextBox txtAddress;
        private Button btnSave;
        private Button btnDelete;
        private Label label5;
        private DataGridView dgClient;
        private Label label6;
    }
}
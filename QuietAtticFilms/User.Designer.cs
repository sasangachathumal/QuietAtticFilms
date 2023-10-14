namespace QuietAtticFilms
{
    partial class User
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
            combUsername = new ComboBox();
            checkSearch = new CheckBox();
            label1 = new Label();
            txtUsername = new TextBox();
            groupBox1 = new GroupBox();
            lblPWconfirm = new Label();
            txtPWconfirm = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            btnDelete = new Button();
            btnSave = new Button();
            btnClear = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Righteous", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(86, 9);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(302, 41);
            label6.TabIndex = 17;
            label6.Text = "User Management";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Cursor = Cursors.Hand;
            lblBack.Image = Properties.Resources.back;
            lblBack.Location = new Point(15, 11);
            lblBack.Margin = new Padding(4, 0, 4, 0);
            lblBack.Name = "lblBack";
            lblBack.Padding = new Padding(12, 11, 12, 11);
            lblBack.Size = new Size(44, 40);
            lblBack.TabIndex = 16;
            lblBack.Text = "   ";
            lblBack.Click += lblBack_Click;
            // 
            // combUsername
            // 
            combUsername.DropDownStyle = ComboBoxStyle.DropDownList;
            combUsername.FormattingEnabled = true;
            combUsername.Location = new Point(113, 43);
            combUsername.Name = "combUsername";
            combUsername.Size = new Size(214, 26);
            combUsername.TabIndex = 18;
            combUsername.Visible = false;
            combUsername.SelectedIndexChanged += combUsername_SelectedIndexChanged;
            // 
            // checkSearch
            // 
            checkSearch.AutoSize = true;
            checkSearch.Cursor = Cursors.Hand;
            checkSearch.Location = new Point(333, 45);
            checkSearch.Name = "checkSearch";
            checkSearch.Size = new Size(77, 22);
            checkSearch.TabIndex = 20;
            checkSearch.Text = "Search";
            checkSearch.UseVisualStyleBackColor = true;
            checkSearch.CheckedChanged += checkSearch_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(88, 18);
            label1.TabIndex = 21;
            label1.Text = "Username :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(113, 43);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(214, 26);
            txtUsername.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblPWconfirm);
            groupBox1.Controls.Add(txtPWconfirm);
            groupBox1.Controls.Add(combUsername);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(checkSearch);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Location = new Point(15, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(435, 186);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            // 
            // lblPWconfirm
            // 
            lblPWconfirm.AutoSize = true;
            lblPWconfirm.Location = new Point(6, 132);
            lblPWconfirm.Name = "lblPWconfirm";
            lblPWconfirm.Size = new Size(101, 18);
            lblPWconfirm.TabIndex = 25;
            lblPWconfirm.Text = "PW Confirm :";
            lblPWconfirm.Click += label3_Click;
            // 
            // txtPWconfirm
            // 
            txtPWconfirm.Location = new Point(113, 129);
            txtPWconfirm.Name = "txtPWconfirm";
            txtPWconfirm.Size = new Size(214, 26);
            txtPWconfirm.TabIndex = 26;
            txtPWconfirm.TextChanged += txtPWconfirm_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 88);
            label2.Name = "label2";
            label2.Size = new Size(86, 18);
            label2.TabIndex = 23;
            label2.Text = "Password :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(113, 85);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(214, 26);
            txtPassword.TabIndex = 24;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.DarkRed;
            btnDelete.Location = new Point(256, 268);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 36);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.DarkSlateBlue;
            btnSave.Location = new Point(150, 268);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 36);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.SteelBlue;
            btnClear.Location = new Point(364, 268);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 36);
            btnClear.TabIndex = 24;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(462, 319);
            ControlBox = false;
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(lblBack);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "User";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            Load += User_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label lblBack;
        private ComboBox combUsername;
        private CheckBox checkSearch;
        private Label label1;
        private TextBox txtUsername;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtPassword;
        private Button btnDelete;
        private Button btnSave;
        private Button btnClear;
        private Label lblPWconfirm;
        private TextBox txtPWconfirm;
    }
}
namespace QuietAtticFilms
{
    partial class HomePage
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
            label1 = new Label();
            lblLogout = new Label();
            lblClient = new Label();
            lblSettings = new Label();
            lblUser = new Label();
            lblPayment = new Label();
            lblProperty = new Label();
            lblLocation = new Label();
            lblStaff = new Label();
            lblProduction = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Righteous", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(126, 9);
            label1.Name = "label1";
            label1.Size = new Size(412, 61);
            label1.TabIndex = 0;
            label1.Text = "Quiet Attic Films";
            // 
            // lblLogout
            // 
            lblLogout.AutoSize = true;
            lblLogout.Cursor = Cursors.Hand;
            lblLogout.Image = Properties.Resources.shutdown__2_;
            lblLogout.Location = new Point(636, 9);
            lblLogout.Name = "lblLogout";
            lblLogout.Padding = new Padding(18, 10, 18, 10);
            lblLogout.Size = new Size(36, 38);
            lblLogout.TabIndex = 1;
            lblLogout.Click += lblLogout_Click;
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.BackColor = Color.RoyalBlue;
            lblClient.Cursor = Cursors.Hand;
            lblClient.FlatStyle = FlatStyle.Flat;
            lblClient.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblClient.ForeColor = Color.White;
            lblClient.Location = new Point(11, 92);
            lblClient.Name = "lblClient";
            lblClient.Padding = new Padding(23, 12, 23, 12);
            lblClient.Size = new Size(201, 43);
            lblClient.TabIndex = 2;
            lblClient.Text = "Client Management";
            lblClient.Click += lblClient_Click;
            // 
            // lblSettings
            // 
            lblSettings.AutoSize = true;
            lblSettings.BackColor = Color.RoyalBlue;
            lblSettings.Cursor = Cursors.Hand;
            lblSettings.FlatStyle = FlatStyle.Flat;
            lblSettings.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSettings.ForeColor = Color.White;
            lblSettings.Location = new Point(470, 215);
            lblSettings.Name = "lblSettings";
            lblSettings.Padding = new Padding(65, 12, 65, 12);
            lblSettings.Size = new Size(202, 43);
            lblSettings.TabIndex = 3;
            lblSettings.Text = "Settings";
            lblSettings.Click += lblSettings_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.RoyalBlue;
            lblUser.Cursor = Cursors.Hand;
            lblUser.FlatStyle = FlatStyle.Flat;
            lblUser.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(11, 215);
            lblUser.Name = "lblUser";
            lblUser.Padding = new Padding(27, 12, 27, 12);
            lblUser.Size = new Size(201, 43);
            lblUser.TabIndex = 4;
            lblUser.Text = "User Management";
            lblUser.Click += lblUser_Click;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.BackColor = Color.RoyalBlue;
            lblPayment.Cursor = Cursors.Hand;
            lblPayment.FlatStyle = FlatStyle.Flat;
            lblPayment.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPayment.ForeColor = Color.White;
            lblPayment.Location = new Point(470, 153);
            lblPayment.Name = "lblPayment";
            lblPayment.Padding = new Padding(12);
            lblPayment.Size = new Size(202, 43);
            lblPayment.TabIndex = 5;
            lblPayment.Text = "Payment Management";
            lblPayment.Click += lblPayment_Click;
            // 
            // lblProperty
            // 
            lblProperty.AutoSize = true;
            lblProperty.BackColor = Color.RoyalBlue;
            lblProperty.Cursor = Cursors.Hand;
            lblProperty.FlatStyle = FlatStyle.Flat;
            lblProperty.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProperty.ForeColor = Color.White;
            lblProperty.Location = new Point(233, 153);
            lblProperty.Name = "lblProperty";
            lblProperty.Padding = new Padding(21, 12, 21, 12);
            lblProperty.Size = new Size(219, 43);
            lblProperty.TabIndex = 6;
            lblProperty.Text = "Property Management";
            lblProperty.Click += lblProperty_Click;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.BackColor = Color.RoyalBlue;
            lblLocation.Cursor = Cursors.Hand;
            lblLocation.FlatStyle = FlatStyle.Flat;
            lblLocation.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLocation.ForeColor = Color.White;
            lblLocation.Location = new Point(11, 153);
            lblLocation.Name = "lblLocation";
            lblLocation.Padding = new Padding(12);
            lblLocation.Size = new Size(202, 43);
            lblLocation.TabIndex = 7;
            lblLocation.Text = "Location Management";
            lblLocation.Click += lblLocation_Click;
            // 
            // lblStaff
            // 
            lblStaff.AutoSize = true;
            lblStaff.BackColor = Color.RoyalBlue;
            lblStaff.Cursor = Cursors.Hand;
            lblStaff.FlatStyle = FlatStyle.Flat;
            lblStaff.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStaff.ForeColor = Color.White;
            lblStaff.Location = new Point(470, 92);
            lblStaff.Name = "lblStaff";
            lblStaff.Padding = new Padding(28, 12, 28, 12);
            lblStaff.Size = new Size(202, 43);
            lblStaff.TabIndex = 8;
            lblStaff.Text = "Staff Management";
            lblStaff.Click += lblStaff_Click;
            // 
            // lblProduction
            // 
            lblProduction.AutoSize = true;
            lblProduction.BackColor = Color.RoyalBlue;
            lblProduction.Cursor = Cursors.Hand;
            lblProduction.FlatStyle = FlatStyle.Flat;
            lblProduction.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduction.ForeColor = Color.White;
            lblProduction.Location = new Point(233, 92);
            lblProduction.Name = "lblProduction";
            lblProduction.Padding = new Padding(12);
            lblProduction.Size = new Size(220, 43);
            lblProduction.TabIndex = 9;
            lblProduction.Text = "Production Management";
            lblProduction.Click += lblProduction_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(685, 270);
            ControlBox = false;
            Controls.Add(lblProduction);
            Controls.Add(lblStaff);
            Controls.Add(lblLocation);
            Controls.Add(lblProperty);
            Controls.Add(lblPayment);
            Controls.Add(lblUser);
            Controls.Add(lblSettings);
            Controls.Add(lblClient);
            Controls.Add(lblLogout);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "HomePage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            Load += HomePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblLogout;
        private Label lblClient;
        private Label lblSettings;
        private Label lblUser;
        private Label lblPayment;
        private Label lblProperty;
        private Label lblLocation;
        private Label lblStaff;
        private Label lblProduction;
    }
}
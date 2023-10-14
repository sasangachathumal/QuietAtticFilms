namespace QuietAtticFilms
{
    partial class Login
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
            btnLogin = new Button();
            label1 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.MidnightBlue;
            btnLogin.Location = new Point(628, 126);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(96, 33);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Righteous", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(295, 61);
            label1.TabIndex = 1;
            label1.Text = "WelCome to";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(522, 41);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(202, 26);
            txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Righteous", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(412, 61);
            label2.TabIndex = 3;
            label2.Text = "Quiet Attic Films";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(421, 44);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 4;
            label3.Text = "Username :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(421, 85);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 6;
            label4.Text = "Password :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(522, 82);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(202, 26);
            txtPassword.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(736, 171);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label1;
        private TextBox txtUsername;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPassword;
    }
}
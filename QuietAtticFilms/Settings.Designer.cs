namespace QuietAtticFilms
{
    partial class Settings
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
            btnUpdate = new Button();
            label1 = new Label();
            label6 = new Label();
            lblBack = new Label();
            txtCcRate = new TextBox();
            txtPRate = new TextBox();
            label2 = new Label();
            txtVaRate = new TextBox();
            label3 = new Label();
            txtAcRate = new TextBox();
            label4 = new Label();
            txtRuRate = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.DarkSlateBlue;
            btnUpdate.Location = new Point(374, 299);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 36);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 76);
            label1.Name = "label1";
            label1.Size = new Size(222, 18);
            label1.TabIndex = 11;
            label1.Text = "Camera Crew Rate : (Per Day)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Righteous", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(80, 9);
            label6.Name = "label6";
            label6.Size = new Size(345, 41);
            label6.TabIndex = 15;
            label6.Text = "Application Settings";
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
            lblBack.TabIndex = 14;
            lblBack.Text = "  ";
            lblBack.Click += lblBack_Click;
            // 
            // txtCcRate
            // 
            txtCcRate.Location = new Point(240, 73);
            txtCcRate.Name = "txtCcRate";
            txtCcRate.Size = new Size(220, 26);
            txtCcRate.TabIndex = 16;
            // 
            // txtPRate
            // 
            txtPRate.Location = new Point(240, 252);
            txtPRate.Name = "txtPRate";
            txtPRate.Size = new Size(220, 26);
            txtPRate.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 255);
            label2.Name = "label2";
            label2.Size = new Size(188, 18);
            label2.TabIndex = 17;
            label2.Text = "Producer Rate : (Per Day)";
            // 
            // txtVaRate
            // 
            txtVaRate.Location = new Point(240, 207);
            txtVaRate.Name = "txtVaRate";
            txtVaRate.Size = new Size(220, 26);
            txtVaRate.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 210);
            label3.Name = "label3";
            label3.Size = new Size(204, 18);
            label3.TabIndex = 19;
            label3.Text = "Voice Actor Rate : (Per Day)";
            // 
            // txtAcRate
            // 
            txtAcRate.Location = new Point(240, 162);
            txtAcRate.Name = "txtAcRate";
            txtAcRate.Size = new Size(220, 26);
            txtAcRate.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 165);
            label4.Name = "label4";
            label4.Size = new Size(161, 18);
            label4.TabIndex = 21;
            label4.Text = "Actor Rate : (Per Day)";
            // 
            // txtRuRate
            // 
            txtRuRate.Location = new Point(240, 117);
            txtRuRate.Name = "txtRuRate";
            txtRuRate.Size = new Size(220, 26);
            txtRuRate.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 120);
            label7.Name = "label7";
            label7.Size = new Size(173, 18);
            label7.TabIndex = 23;
            label7.Text = "Runner Rate : (Per Day)";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(475, 347);
            ControlBox = false;
            Controls.Add(txtRuRate);
            Controls.Add(label7);
            Controls.Add(txtAcRate);
            Controls.Add(label4);
            Controls.Add(txtVaRate);
            Controls.Add(label3);
            Controls.Add(txtPRate);
            Controls.Add(label2);
            Controls.Add(txtCcRate);
            Controls.Add(label6);
            Controls.Add(lblBack);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Settings";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnUpdate;
        private Label label1;
        private Label label6;
        private Label lblBack;
        private TextBox txtCcRate;
        private TextBox txtPRate;
        private Label label2;
        private TextBox txtVaRate;
        private Label label3;
        private TextBox txtAcRate;
        private Label label4;
        private TextBox txtRuRate;
        private Label label7;
    }
}
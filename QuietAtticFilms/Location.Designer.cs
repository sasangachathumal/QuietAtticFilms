﻿namespace QuietAtticFilms
{
    partial class Location
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            combLoId = new ComboBox();
            btnClear = new Button();
            dgLocation = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLocation).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Righteous", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(116, 9);
            label6.Name = "label6";
            label6.Size = new Size(369, 41);
            label6.TabIndex = 15;
            label6.Text = "Location Management";
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
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.DarkRed;
            btnDelete.Location = new Point(393, 167);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 36);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.DarkSlateBlue;
            btnSave.Location = new Point(287, 167);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 36);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(combLoId);
            groupBox1.Location = new Point(12, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(572, 83);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Location Info";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 36);
            label3.Name = "label3";
            label3.Size = new Size(58, 18);
            label3.TabIndex = 8;
            label3.Text = "Name :";
            // 
            // txtName
            // 
            txtName.Location = new Point(347, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(208, 26);
            txtName.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(92, 18);
            label1.TabIndex = 4;
            label1.Text = "Location Id :";
            // 
            // combLoId
            // 
            combLoId.DropDownStyle = ComboBoxStyle.DropDownList;
            combLoId.FormattingEnabled = true;
            combLoId.Location = new Point(104, 33);
            combLoId.Name = "combLoId";
            combLoId.Size = new Size(137, 26);
            combLoId.TabIndex = 17;
            combLoId.SelectedIndexChanged += combLoId_SelectedIndexChanged;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.SteelBlue;
            btnClear.Location = new Point(498, 167);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 36);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgLocation
            // 
            dgLocation.AllowUserToAddRows = false;
            dgLocation.AllowUserToDeleteRows = false;
            dgLocation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgLocation.BackgroundColor = Color.Gainsboro;
            dgLocation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLocation.Location = new Point(12, 221);
            dgLocation.Name = "dgLocation";
            dgLocation.ReadOnly = true;
            dgLocation.RowTemplate.Height = 25;
            dgLocation.ShowEditingIcon = false;
            dgLocation.Size = new Size(572, 232);
            dgLocation.TabIndex = 13;
            // 
            // Location
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(596, 465);
            ControlBox = false;
            Controls.Add(dgLocation);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Controls.Add(btnClear);
            Controls.Add(label6);
            Controls.Add(lblBack);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Location";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Location Management";
            Load += Location_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgLocation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label lblBack;
        private Button btnDelete;
        private Button btnSave;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtName;
        private Label label1;
        private ComboBox combLoId;
        private Button btnClear;
        private DataGridView dgLocation;
    }
}
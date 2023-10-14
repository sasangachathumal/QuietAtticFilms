namespace QuietAtticFilms
{
    partial class Payment
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
            label5 = new Label();
            checkSearch = new CheckBox();
            label1 = new Label();
            txtPaymentId = new TextBox();
            combProductionId = new ComboBox();
            groupBox1 = new GroupBox();
            combPaymentId = new ComboBox();
            label7 = new Label();
            txtPaymentAmount = new TextBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txtClientName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtProductionType = new TextBox();
            btnDelete = new Button();
            btnSave = new Button();
            btnClear = new Button();
            dgPayment = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPayment).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Righteous", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(176, 9);
            label6.Name = "label6";
            label6.Size = new Size(367, 41);
            label6.TabIndex = 15;
            label6.Text = "Payment Management";
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
            label5.Click += label5_Click;
            // 
            // checkSearch
            // 
            checkSearch.AutoSize = true;
            checkSearch.Location = new Point(321, 34);
            checkSearch.Name = "checkSearch";
            checkSearch.Size = new Size(77, 22);
            checkSearch.TabIndex = 17;
            checkSearch.Text = "Search";
            checkSearch.UseVisualStyleBackColor = true;
            checkSearch.CheckedChanged += checkSearch_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(93, 18);
            label1.TabIndex = 18;
            label1.Text = "Payment Id :";
            // 
            // txtPaymentId
            // 
            txtPaymentId.Enabled = false;
            txtPaymentId.Location = new Point(140, 32);
            txtPaymentId.Name = "txtPaymentId";
            txtPaymentId.Size = new Size(175, 26);
            txtPaymentId.TabIndex = 19;
            // 
            // combProductionId
            // 
            combProductionId.DropDownStyle = ComboBoxStyle.DropDownList;
            combProductionId.FormattingEnabled = true;
            combProductionId.Location = new Point(140, 31);
            combProductionId.Name = "combProductionId";
            combProductionId.Size = new Size(175, 26);
            combProductionId.TabIndex = 20;
            combProductionId.SelectedIndexChanged += combProductionId_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(combPaymentId);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtPaymentAmount);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPaymentId);
            groupBox1.Controls.Add(checkSearch);
            groupBox1.Location = new Point(12, 192);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(663, 118);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Payment Info";
            // 
            // combPaymentId
            // 
            combPaymentId.DropDownStyle = ComboBoxStyle.DropDownList;
            combPaymentId.FormattingEnabled = true;
            combPaymentId.Location = new Point(140, 32);
            combPaymentId.Name = "combPaymentId";
            combPaymentId.Size = new Size(175, 26);
            combPaymentId.TabIndex = 24;
            combPaymentId.Visible = false;
            combPaymentId.SelectedIndexChanged += combPaymentId_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 82);
            label7.Name = "label7";
            label7.Size = new Size(133, 18);
            label7.TabIndex = 20;
            label7.Text = "Payment Amount :";
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.Location = new Point(140, 79);
            txtPaymentAmount.Name = "txtPaymentAmount";
            txtPaymentAmount.Size = new Size(175, 26);
            txtPaymentAmount.TabIndex = 21;
            txtPaymentAmount.TextChanged += txtPaymentAmount_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtClientName);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtProductionType);
            groupBox2.Controls.Add(combProductionId);
            groupBox2.Location = new Point(12, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(663, 114);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Production Info";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(342, 34);
            label4.Name = "label4";
            label4.Size = new Size(102, 18);
            label4.TabIndex = 22;
            label4.Text = "Client Name :";
            // 
            // txtClientName
            // 
            txtClientName.Enabled = false;
            txtClientName.Location = new Point(476, 31);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(175, 26);
            txtClientName.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 76);
            label3.Name = "label3";
            label3.Size = new Size(128, 18);
            label3.TabIndex = 20;
            label3.Text = "Production Type :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 34);
            label2.Name = "label2";
            label2.Size = new Size(107, 18);
            label2.TabIndex = 20;
            label2.Text = "Production Id :";
            // 
            // txtProductionType
            // 
            txtProductionType.Enabled = false;
            txtProductionType.Location = new Point(140, 73);
            txtProductionType.Name = "txtProductionType";
            txtProductionType.Size = new Size(175, 26);
            txtProductionType.TabIndex = 21;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.DarkRed;
            btnDelete.Location = new Point(484, 325);
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
            btnSave.Location = new Point(378, 325);
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
            btnClear.Location = new Point(589, 325);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 36);
            btnClear.TabIndex = 24;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgPayment
            // 
            dgPayment.AllowUserToAddRows = false;
            dgPayment.AllowUserToDeleteRows = false;
            dgPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPayment.BackgroundColor = Color.Gainsboro;
            dgPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPayment.Location = new Point(12, 378);
            dgPayment.Name = "dgPayment";
            dgPayment.ReadOnly = true;
            dgPayment.RowTemplate.Height = 25;
            dgPayment.ShowEditingIcon = false;
            dgPayment.ShowRowErrors = false;
            dgPayment.Size = new Size(663, 150);
            dgPayment.TabIndex = 27;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(687, 540);
            ControlBox = false;
            Controls.Add(dgPayment);
            Controls.Add(btnDelete);
            Controls.Add(groupBox2);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Controls.Add(btnClear);
            Controls.Add(label6);
            Controls.Add(label5);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Payment";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += Payment_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPayment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private CheckBox checkSearch;
        private Label label1;
        private TextBox txtPaymentId;
        private ComboBox combProductionId;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private TextBox txtProductionType;
        private Label label7;
        private TextBox txtPaymentAmount;
        private Label label4;
        private TextBox txtClientName;
        private Button btnDelete;
        private Button btnSave;
        private Button btnClear;
        private DataGridView dgPayment;
        private ComboBox combPaymentId;
    }
}
namespace Pocket_Auditor_Admin_Panel.Forms
{
    partial class FormManageAuditors
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
            label1 = new Label();
            cbxUserType = new ComboBox();
            txtUserID = new TextBox();
            label11 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnRegister = new Button();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            Usersdgv = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)Usersdgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(1, 188, 22);
            label1.Location = new Point(36, 29);
            label1.Name = "label1";
            label1.Size = new Size(203, 23);
            label1.TabIndex = 3;
            label1.Text = "MANAGE AUDITORS";
            // 
            // cbxUserType
            // 
            cbxUserType.FormattingEnabled = true;
            cbxUserType.Items.AddRange(new object[] { "Admin", "Auditor" });
            cbxUserType.Location = new Point(148, 323);
            cbxUserType.Name = "cbxUserType";
            cbxUserType.Size = new Size(185, 23);
            cbxUserType.TabIndex = 27;
            // 
            // txtUserID
            // 
            txtUserID.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserID.Location = new Point(148, 156);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(70, 21);
            txtUserID.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(70, 159);
            label11.Name = "label11";
            label11.Size = new Size(48, 15);
            label11.TabIndex = 25;
            label11.Text = "User ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(36, 122);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 23;
            label6.Text = "REGISTRATION";
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(148, 197);
            txtName.Name = "txtName";
            txtName.Size = new Size(185, 21);
            txtName.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(70, 285);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 16;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 200);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 17;
            label3.Text = "UserName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(70, 243);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 18;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(70, 326);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 19;
            label5.Text = "User Type";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Lime;
            btnRegister.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(240, 363);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(93, 30);
            btnRegister.TabIndex = 24;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(148, 282);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(185, 21);
            txtEmail.TabIndex = 20;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(148, 240);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(185, 21);
            txtPassword.TabIndex = 22;
            // 
            // Usersdgv
            // 
            Usersdgv.AllowUserToAddRows = false;
            Usersdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Usersdgv.BackgroundColor = Color.White;
            Usersdgv.BorderStyle = BorderStyle.None;
            Usersdgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(1, 188, 22);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(1, 188, 22);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Usersdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Usersdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Usersdgv.EnableHeadersVisualStyles = false;
            Usersdgv.Location = new Point(360, 94);
            Usersdgv.Name = "Usersdgv";
            Usersdgv.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(185, 238, 187);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGreen;
            Usersdgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            Usersdgv.RowTemplate.Height = 25;
            Usersdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Usersdgv.Size = new Size(528, 471);
            Usersdgv.TabIndex = 28;
            Usersdgv.CellClick += Usersdgv_CellClick;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 192, 192);
            btnUpdate.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(664, 58);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(93, 30);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(786, 58);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 30);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // FormManageAuditors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 630);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(Usersdgv);
            Controls.Add(cbxUserType);
            Controls.Add(txtUserID);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(btnRegister);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormManageAuditors";
            Load += FormManageAuditors_Load;
            ((System.ComponentModel.ISupportInitialize)Usersdgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbxUserType;
        private TextBox txtUserID;
        private Label label11;
        private Label label6;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnRegister;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private DataGridView Usersdgv;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
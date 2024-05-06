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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageAuditors));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            dgv_Users = new DataGridView();
            label2 = new Label();
            btn_AddUser = new Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_Users).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(247, 32);
            label1.TabIndex = 3;
            label1.Text = "MANAGE AUDITORS";
            label1.Click += label1_Click;
            // 
            // dgv_Users
            // 
            dgv_Users.AllowUserToAddRows = false;
            dgv_Users.AllowUserToDeleteRows = false;
            dgv_Users.AllowUserToResizeColumns = false;
            dgv_Users.AllowUserToResizeRows = false;
            dgv_Users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Users.BackgroundColor = Color.White;
            dgv_Users.BorderStyle = BorderStyle.None;
            dgv_Users.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_Users.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(119, 186, 27);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Users.EnableHeadersVisualStyles = false;
            dgv_Users.Location = new Point(59, 161);
            dgv_Users.Name = "dgv_Users";
            dgv_Users.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.ForeColor = Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(173, 223, 136);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Users.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Users.RowTemplate.Height = 25;
            dgv_Users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Users.Size = new Size(868, 430);
            dgv_Users.TabIndex = 28;
            dgv_Users.CellDoubleClick += EditUser;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(59, 140);
            label2.Name = "label2";
            label2.Size = new Size(232, 20);
            label2.TabIndex = 29;
            label2.Text = "Double-click on an entry to edit it";
            // 
            // btn_AddUser
            // 
            btn_AddUser.FlatAppearance.BorderSize = 0;
            btn_AddUser.FlatStyle = FlatStyle.Flat;
            btn_AddUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AddUser.Image = (Image)resources.GetObject("btn_AddUser.Image");
            btn_AddUser.Location = new Point(59, 80);
            btn_AddUser.Name = "btn_AddUser";
            btn_AddUser.Size = new Size(174, 57);
            btn_AddUser.TabIndex = 30;
            btn_AddUser.Text = "  Add user";
            btn_AddUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_AddUser.UseVisualStyleBackColor = true;
            btn_AddUser.Click += btn_AddUser_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(119, 186, 27);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(984, 74);
            guna2Panel1.TabIndex = 31;
            // 
            // FormManageAuditors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 630);
            Controls.Add(guna2Panel1);
            Controls.Add(btn_AddUser);
            Controls.Add(label2);
            Controls.Add(dgv_Users);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormManageAuditors";
            Text = " ";
            WindowState = FormWindowState.Maximized;
            Load += LoadPopulateTable;
            Leave += FormManageAuditors_Leave;
            ((System.ComponentModel.ISupportInitialize)dgv_Users).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_Users;
        private Label label2;
        private Button btn_AddUser;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
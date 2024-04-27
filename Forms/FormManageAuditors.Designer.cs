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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            dgv_Users = new DataGridView();
            label2 = new Label();
            btn_AddUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Users).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HP Simplified", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(265, 35);
            label1.TabIndex = 3;
            label1.Text = "MANAGE AUDITORS";
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.AliceBlue;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Users.EnableHeadersVisualStyles = false;
            dgv_Users.Location = new Point(59, 161);
            dgv_Users.Name = "dgv_Users";
            dgv_Users.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.LightGray;
            dataGridViewCellStyle4.ForeColor = Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_Users.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Users.RowTemplate.Height = 25;
            dgv_Users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Users.Size = new Size(868, 430);
            dgv_Users.TabIndex = 28;
            dgv_Users.CellDoubleClick += EditUser;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HP Simplified Light", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(59, 140);
            label2.Name = "label2";
            label2.Size = new Size(213, 18);
            label2.TabIndex = 29;
            label2.Text = "Double-click on an entry to edit it";
            // 
            // btn_AddUser
            // 
            btn_AddUser.FlatAppearance.BorderSize = 0;
            btn_AddUser.FlatStyle = FlatStyle.Flat;
            btn_AddUser.Font = new Font("HP Simplified Light", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AddUser.Image = Properties.Resources.AddUserBlk_x32;
            btn_AddUser.Location = new Point(59, 91);
            btn_AddUser.Name = "btn_AddUser";
            btn_AddUser.Size = new Size(146, 40);
            btn_AddUser.TabIndex = 30;
            btn_AddUser.Text = "  Add user";
            btn_AddUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_AddUser.UseVisualStyleBackColor = true;
            btn_AddUser.Click += btn_AddUser_Click;
            // 
            // FormManageAuditors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 630);
            Controls.Add(btn_AddUser);
            Controls.Add(label2);
            Controls.Add(dgv_Users);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormManageAuditors";
            Load += LoadPopulateTable;
            Leave += FormManageAuditors_Leave;
            ((System.ComponentModel.ISupportInitialize)dgv_Users).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_Users;
        private Label label2;
        private Button btn_AddUser;
    }
}
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
            dgv_Users = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Users).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(400, 19);
            label1.Name = "label1";
            label1.Size = new Size(203, 23);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Users.EnableHeadersVisualStyles = false;
            dgv_Users.Location = new Point(59, 82);
            dgv_Users.Name = "dgv_Users";
            dgv_Users.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.ForeColor = Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Users.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Users.RowTemplate.Height = 25;
            dgv_Users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Users.Size = new Size(868, 509);
            dgv_Users.TabIndex = 28;
            dgv_Users.CellDoubleClick += EditUser;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 62);
            label2.Name = "label2";
            label2.Size = new Size(183, 15);
            label2.TabIndex = 29;
            label2.Text = "Double-click on an entry to edit it";
            // 
            // FormManageAuditors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 630);
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
    }
}
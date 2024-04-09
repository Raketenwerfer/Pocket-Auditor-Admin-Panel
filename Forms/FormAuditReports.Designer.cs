namespace Pocket_Auditor_Admin_Panel.Forms
{
    partial class FormAuditReports
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
            txtSearch = new TextBox();
            label2 = new Label();
            dgv_Results = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_Results).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(30, 24);
            label1.Name = "label1";
            label1.Size = new Size(165, 23);
            label1.TabIndex = 2;
            label1.Text = "AUDIT RESULTS";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(624, 70);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(253, 22);
            txtSearch.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(520, 74);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 5;
            label2.Text = "Search Barangay";
            // 
            // dgv_Results
            // 
            dgv_Results.AllowUserToAddRows = false;
            dgv_Results.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Results.BackgroundColor = Color.White;
            dgv_Results.BorderStyle = BorderStyle.None;
            dgv_Results.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(1, 188, 22);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(1, 188, 22);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Results.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Results.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Results.EnableHeadersVisualStyles = false;
            dgv_Results.Location = new Point(30, 98);
            dgv_Results.Name = "dgv_Results";
            dgv_Results.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(185, 238, 187);
            dataGridViewCellStyle4.SelectionBackColor = Color.LightGreen;
            dgv_Results.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Results.RowTemplate.Height = 25;
            dgv_Results.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Results.Size = new Size(847, 466);
            dgv_Results.TabIndex = 51;
            dgv_Results.CellContentClick += Reportsdgv_CellContentClick;
            // 
            // FormAuditReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 630);
            Controls.Add(dgv_Results);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAuditReports";
            Text = "FormAuditReports";
            Load += FormAuditReports_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Results).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Label label2;
        private DataGridView dgv_Results;
    }
}
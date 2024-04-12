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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            dgv_Results = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_Results).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(410, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 23);
            label1.TabIndex = 2;
            label1.Text = "AUDIT RESULTS";
            // 
            // dgv_Results
            // 
            dgv_Results.AllowUserToAddRows = false;
            dgv_Results.AllowUserToDeleteRows = false;
            dgv_Results.AllowUserToResizeColumns = false;
            dgv_Results.AllowUserToResizeRows = false;
            dgv_Results.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Results.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Results.BackgroundColor = Color.White;
            dgv_Results.BorderStyle = BorderStyle.None;
            dgv_Results.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(0, 0, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlDarkDark;
            dgv_Results.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Results.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Results.EnableHeadersVisualStyles = false;
            dgv_Results.Location = new Point(1, 36);
            dgv_Results.MultiSelect = false;
            dgv_Results.Name = "dgv_Results";
            dgv_Results.ReadOnly = true;
            dgv_Results.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Gainsboro;
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.Padding = new Padding(0, 0, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgv_Results.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Results.RowTemplate.Height = 25;
            dgv_Results.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Results.Size = new Size(984, 592);
            dgv_Results.TabIndex = 51;
            dgv_Results.CellDoubleClick += Reportsdgv_CellContentClick;
            // 
            // FormAuditReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 631);
            Controls.Add(dgv_Results);
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
        private DataGridView dgv_Results;
    }
}
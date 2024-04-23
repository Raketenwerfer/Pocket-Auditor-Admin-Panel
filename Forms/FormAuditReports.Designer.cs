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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            dgv_Results = new DataGridView();
            btn_DeleteEntry = new Button();
            btn_ResetEntries = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Results).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HP Simplified", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(249, 41);
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new Padding(0, 0, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlDarkDark;
            dgv_Results.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv_Results.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Results.EnableHeadersVisualStyles = false;
            dgv_Results.Location = new Point(1, 100);
            dgv_Results.MultiSelect = false;
            dgv_Results.Name = "dgv_Results";
            dgv_Results.ReadOnly = true;
            dgv_Results.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.Gainsboro;
            dataGridViewCellStyle6.ForeColor = Color.DimGray;
            dataGridViewCellStyle6.Padding = new Padding(0, 0, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dgv_Results.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgv_Results.RowTemplate.Height = 25;
            dgv_Results.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Results.Size = new Size(984, 528);
            dgv_Results.TabIndex = 51;
            dgv_Results.CellDoubleClick += Reportsdgv_CellContentClick;
            // 
            // btn_DeleteEntry
            // 
            btn_DeleteEntry.BackColor = Color.Transparent;
            btn_DeleteEntry.Cursor = Cursors.Hand;
            btn_DeleteEntry.FlatAppearance.BorderSize = 0;
            btn_DeleteEntry.FlatStyle = FlatStyle.Flat;
            btn_DeleteEntry.Font = new Font("HP Simplified Light", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DeleteEntry.Image = Properties.Resources.Delete_x32;
            btn_DeleteEntry.Location = new Point(660, 50);
            btn_DeleteEntry.Name = "btn_DeleteEntry";
            btn_DeleteEntry.Size = new Size(139, 44);
            btn_DeleteEntry.TabIndex = 52;
            btn_DeleteEntry.Text = "Delete Report";
            btn_DeleteEntry.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_DeleteEntry.UseVisualStyleBackColor = false;
            btn_DeleteEntry.Click += btn_DeleteEntry_Click;
            // 
            // btn_ResetEntries
            // 
            btn_ResetEntries.BackColor = Color.Transparent;
            btn_ResetEntries.Cursor = Cursors.Hand;
            btn_ResetEntries.FlatAppearance.BorderSize = 0;
            btn_ResetEntries.FlatStyle = FlatStyle.Flat;
            btn_ResetEntries.Font = new Font("HP Simplified Light", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ResetEntries.Image = Properties.Resources.Restart_x32;
            btn_ResetEntries.Location = new Point(806, 48);
            btn_ResetEntries.Name = "btn_ResetEntries";
            btn_ResetEntries.Size = new Size(171, 44);
            btn_ResetEntries.TabIndex = 53;
            btn_ResetEntries.Text = "Delete All Reports";
            btn_ResetEntries.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ResetEntries.UseVisualStyleBackColor = false;
            btn_ResetEntries.Click += btn_ResetEntries_Click;
            // 
            // FormAuditReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 631);
            Controls.Add(btn_ResetEntries);
            Controls.Add(btn_DeleteEntry);
            Controls.Add(dgv_Results);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAuditReports";
            Text = "FormAuditReports";
            Load += FormAuditReports_Load;
            Leave += FormAuditReports_Leave;
            ((System.ComponentModel.ISupportInitialize)dgv_Results).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_Results;
        private Button btn_DeleteEntry;
        private Button btn_ResetEntries;
    }
}
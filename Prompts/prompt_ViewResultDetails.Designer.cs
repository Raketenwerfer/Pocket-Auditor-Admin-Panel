namespace Pocket_Auditor_Admin_Panel.Prompts
{
    partial class prompt_ViewResultDetails
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgv_table_ResultsDetails = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_table_ResultsDetails).BeginInit();
            SuspendLayout();
            // 
            // dgv_table_ResultsDetails
            // 
            dgv_table_ResultsDetails.AllowUserToAddRows = false;
            dgv_table_ResultsDetails.AllowUserToDeleteRows = false;
            dgv_table_ResultsDetails.AllowUserToResizeRows = false;
            dgv_table_ResultsDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_table_ResultsDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_table_ResultsDetails.BackgroundColor = Color.White;
            dgv_table_ResultsDetails.BorderStyle = BorderStyle.None;
            dgv_table_ResultsDetails.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_table_ResultsDetails.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(119, 186, 27);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(119, 186, 27);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_table_ResultsDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_table_ResultsDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(119, 186, 27);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(119, 186, 27);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_table_ResultsDetails.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_table_ResultsDetails.Dock = DockStyle.Fill;
            dgv_table_ResultsDetails.GridColor = Color.Gainsboro;
            dgv_table_ResultsDetails.Location = new Point(0, 0);
            dgv_table_ResultsDetails.MultiSelect = false;
            dgv_table_ResultsDetails.Name = "dgv_table_ResultsDetails";
            dgv_table_ResultsDetails.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(119, 186, 27);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_table_ResultsDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_table_ResultsDetails.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.Gainsboro;
            dataGridViewCellStyle4.ForeColor = Color.DimGray;
            dataGridViewCellStyle4.Padding = new Padding(0, 0, 0, 4);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(119, 186, 27);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_table_ResultsDetails.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_table_ResultsDetails.RowTemplate.Height = 25;
            dgv_table_ResultsDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_table_ResultsDetails.Size = new Size(734, 461);
            dgv_table_ResultsDetails.TabIndex = 0;
            // 
            // prompt_ViewResultDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 461);
            Controls.Add(dgv_table_ResultsDetails);
            MinimizeBox = false;
            Name = "prompt_ViewResultDetails";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Audit Results";
            Load += prompt_ViewResultDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_table_ResultsDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_table_ResultsDetails;
    }
}
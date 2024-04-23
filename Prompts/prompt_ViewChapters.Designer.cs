namespace Pocket_Auditor_Admin_Panel.Prompts
{
    partial class prompt_ViewChapters
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
            dgv_Chapters = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_Chapters).BeginInit();
            SuspendLayout();
            // 
            // dgv_Chapters
            // 
            dgv_Chapters.AllowUserToAddRows = false;
            dgv_Chapters.AllowUserToDeleteRows = false;
            dgv_Chapters.AllowUserToResizeColumns = false;
            dgv_Chapters.AllowUserToResizeRows = false;
            dgv_Chapters.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Chapters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Chapters.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv_Chapters.BackgroundColor = Color.Black;
            dgv_Chapters.BorderStyle = BorderStyle.None;
            dgv_Chapters.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_Chapters.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("HP Simplified Light", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Chapters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Chapters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Chapters.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Chapters.Location = new Point(-1, 0);
            dgv_Chapters.MultiSelect = false;
            dgv_Chapters.Name = "dgv_Chapters";
            dgv_Chapters.ReadOnly = true;
            dgv_Chapters.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Chapters.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Chapters.RowTemplate.Height = 25;
            dgv_Chapters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Chapters.Size = new Size(352, 285);
            dgv_Chapters.TabIndex = 0;
            // 
            // prompt_ViewChapters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(351, 284);
            Controls.Add(dgv_Chapters);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "prompt_ViewChapters";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chapters/Barangays";
            ((System.ComponentModel.ISupportInitialize)dgv_Chapters).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Chapters;
    }
}
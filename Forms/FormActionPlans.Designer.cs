namespace Pocket_Auditor_Admin_Panel.Forms
{
    partial class FormActionPlans
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            label1 = new Label();
            dgv_ChapterSelect = new DataGridView();
            dgv_SelectedChapterAuditResults = new DataGridView();
            label2 = new Label();
            dgv_CategorySelect = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            rtb_ActionPlanDetail = new RichTextBox();
            label5 = new Label();
            btn_SaveActionPlan = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ChapterSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_SelectedChapterAuditResults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_CategorySelect).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(1, 188, 22);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 23);
            label1.TabIndex = 2;
            label1.Text = "ACTION PLANS";
            // 
            // dgv_ChapterSelect
            // 
            dgv_ChapterSelect.AllowUserToAddRows = false;
            dgv_ChapterSelect.AllowUserToDeleteRows = false;
            dgv_ChapterSelect.AllowUserToResizeColumns = false;
            dgv_ChapterSelect.AllowUserToResizeRows = false;
            dgv_ChapterSelect.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ChapterSelect.BackgroundColor = Color.White;
            dgv_ChapterSelect.BorderStyle = BorderStyle.None;
            dgv_ChapterSelect.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(1, 188, 22);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(1, 188, 22);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgv_ChapterSelect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgv_ChapterSelect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ChapterSelect.ColumnHeadersVisible = false;
            dgv_ChapterSelect.EnableHeadersVisualStyles = false;
            dgv_ChapterSelect.Location = new Point(0, 96);
            dgv_ChapterSelect.MultiSelect = false;
            dgv_ChapterSelect.Name = "dgv_ChapterSelect";
            dgv_ChapterSelect.ReadOnly = true;
            dgv_ChapterSelect.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.LightGray;
            dataGridViewCellStyle8.ForeColor = Color.Gray;
            dataGridViewCellStyle8.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgv_ChapterSelect.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgv_ChapterSelect.RowTemplate.Height = 25;
            dgv_ChapterSelect.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ChapterSelect.Size = new Size(159, 262);
            dgv_ChapterSelect.TabIndex = 16;
            dgv_ChapterSelect.CellClick += eSelChap;
            // 
            // dgv_SelectedChapterAuditResults
            // 
            dgv_SelectedChapterAuditResults.AllowUserToAddRows = false;
            dgv_SelectedChapterAuditResults.AllowUserToDeleteRows = false;
            dgv_SelectedChapterAuditResults.AllowUserToResizeColumns = false;
            dgv_SelectedChapterAuditResults.AllowUserToResizeRows = false;
            dgv_SelectedChapterAuditResults.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgv_SelectedChapterAuditResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_SelectedChapterAuditResults.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv_SelectedChapterAuditResults.BackgroundColor = Color.White;
            dgv_SelectedChapterAuditResults.BorderStyle = BorderStyle.None;
            dgv_SelectedChapterAuditResults.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(1, 188, 22);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(1, 188, 22);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgv_SelectedChapterAuditResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgv_SelectedChapterAuditResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_SelectedChapterAuditResults.EnableHeadersVisualStyles = false;
            dgv_SelectedChapterAuditResults.Location = new Point(359, 96);
            dgv_SelectedChapterAuditResults.MultiSelect = false;
            dgv_SelectedChapterAuditResults.Name = "dgv_SelectedChapterAuditResults";
            dgv_SelectedChapterAuditResults.ReadOnly = true;
            dgv_SelectedChapterAuditResults.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.Gainsboro;
            dataGridViewCellStyle10.ForeColor = Color.DimGray;
            dataGridViewCellStyle10.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgv_SelectedChapterAuditResults.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgv_SelectedChapterAuditResults.RowTemplate.Height = 25;
            dgv_SelectedChapterAuditResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_SelectedChapterAuditResults.Size = new Size(621, 262);
            dgv_SelectedChapterAuditResults.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 76);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 18;
            label2.Text = "Select a Barangay";
            // 
            // dgv_CategorySelect
            // 
            dgv_CategorySelect.AllowUserToAddRows = false;
            dgv_CategorySelect.AllowUserToDeleteRows = false;
            dgv_CategorySelect.AllowUserToResizeColumns = false;
            dgv_CategorySelect.AllowUserToResizeRows = false;
            dgv_CategorySelect.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_CategorySelect.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_CategorySelect.BackgroundColor = Color.White;
            dgv_CategorySelect.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(1, 188, 22);
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(1, 188, 22);
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgv_CategorySelect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgv_CategorySelect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_CategorySelect.ColumnHeadersVisible = false;
            dgv_CategorySelect.EnableHeadersVisualStyles = false;
            dgv_CategorySelect.Location = new Point(165, 96);
            dgv_CategorySelect.MultiSelect = false;
            dgv_CategorySelect.Name = "dgv_CategorySelect";
            dgv_CategorySelect.ReadOnly = true;
            dgv_CategorySelect.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.LightGray;
            dataGridViewCellStyle12.ForeColor = Color.Gray;
            dataGridViewCellStyle12.SelectionBackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgv_CategorySelect.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dgv_CategorySelect.RowTemplate.Height = 32;
            dgv_CategorySelect.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_CategorySelect.Size = new Size(188, 262);
            dgv_CategorySelect.TabIndex = 19;
            dgv_CategorySelect.CellClick += eSelCat;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 76);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 20;
            label3.Text = "Select a Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(359, 76);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 21;
            label4.Text = "Audit Details";
            // 
            // rtb_ActionPlanDetail
            // 
            rtb_ActionPlanDetail.Location = new Point(12, 393);
            rtb_ActionPlanDetail.Name = "rtb_ActionPlanDetail";
            rtb_ActionPlanDetail.Size = new Size(789, 226);
            rtb_ActionPlanDetail.TabIndex = 22;
            rtb_ActionPlanDetail.Text = "";
            rtb_ActionPlanDetail.TextChanged += rtb_ActionPlanDetail_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 375);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 23;
            label5.Text = "Action Plan";
            // 
            // btn_SaveActionPlan
            // 
            btn_SaveActionPlan.BackColor = Color.SpringGreen;
            btn_SaveActionPlan.FlatAppearance.BorderSize = 0;
            btn_SaveActionPlan.FlatStyle = FlatStyle.Flat;
            btn_SaveActionPlan.Location = new Point(818, 393);
            btn_SaveActionPlan.Name = "btn_SaveActionPlan";
            btn_SaveActionPlan.Size = new Size(154, 32);
            btn_SaveActionPlan.TabIndex = 24;
            btn_SaveActionPlan.Text = "SAVE";
            btn_SaveActionPlan.UseVisualStyleBackColor = false;
            btn_SaveActionPlan.Click += btn_SaveActionPlan_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(818, 431);
            button1.Name = "button1";
            button1.Size = new Size(154, 32);
            button1.TabIndex = 25;
            button1.Text = "DELETE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormActionPlans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 631);
            Controls.Add(button1);
            Controls.Add(btn_SaveActionPlan);
            Controls.Add(label5);
            Controls.Add(rtb_ActionPlanDetail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgv_CategorySelect);
            Controls.Add(label2);
            Controls.Add(dgv_SelectedChapterAuditResults);
            Controls.Add(dgv_ChapterSelect);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormActionPlans";
            Text = "FormActionPlans";
            Load += FormActionPlans_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_ChapterSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_SelectedChapterAuditResults).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_CategorySelect).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_ChapterSelect;
        private DataGridView dgv_SelectedChapterAuditResults;
        private Label label2;
        private DataGridView dgv_CategorySelect;
        private Label label3;
        private Label label4;
        private RichTextBox rtb_ActionPlanDetail;
        private Label label5;
        private Button btn_SaveActionPlan;
        private Button button1;
    }
}
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            btn_Delete = new Button();
            btn_pnl_Export = new Panel();
            btn_lbl_Export = new Label();
            btn_pb_Export = new PictureBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_ChapterSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_SelectedChapterAuditResults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_CategorySelect).BeginInit();
            btn_pnl_Export.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_pb_Export).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 2;
            label1.Text = "ACTION PLANS";
            label1.Click += label1_Click;
            // 
            // dgv_ChapterSelect
            // 
            dgv_ChapterSelect.AllowUserToAddRows = false;
            dgv_ChapterSelect.AllowUserToDeleteRows = false;
            dgv_ChapterSelect.AllowUserToResizeColumns = false;
            dgv_ChapterSelect.AllowUserToResizeRows = false;
            dgv_ChapterSelect.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ChapterSelect.BackgroundColor = Color.White;
            dgv_ChapterSelect.BorderStyle = BorderStyle.Fixed3D;
            dgv_ChapterSelect.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(110, 110, 110);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(110, 110, 110);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_ChapterSelect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_ChapterSelect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ChapterSelect.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(186, 255, 57);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_ChapterSelect.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_ChapterSelect.EnableHeadersVisualStyles = false;
            dgv_ChapterSelect.Location = new Point(12, 112);
            dgv_ChapterSelect.MultiSelect = false;
            dgv_ChapterSelect.Name = "dgv_ChapterSelect";
            dgv_ChapterSelect.ReadOnly = true;
            dgv_ChapterSelect.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.LightGray;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(186, 255, 57);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_ChapterSelect.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv_ChapterSelect.RowTemplate.Height = 25;
            dgv_ChapterSelect.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ChapterSelect.Size = new Size(161, 262);
            dgv_ChapterSelect.TabIndex = 16;
            dgv_ChapterSelect.CellClick += eSelChap;
            // 
            // dgv_SelectedChapterAuditResults
            // 
            dgv_SelectedChapterAuditResults.AllowUserToAddRows = false;
            dgv_SelectedChapterAuditResults.AllowUserToDeleteRows = false;
            dgv_SelectedChapterAuditResults.AllowUserToResizeColumns = false;
            dgv_SelectedChapterAuditResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(119, 186, 27);
            dgv_SelectedChapterAuditResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_SelectedChapterAuditResults.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgv_SelectedChapterAuditResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_SelectedChapterAuditResults.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv_SelectedChapterAuditResults.BackgroundColor = Color.White;
            dgv_SelectedChapterAuditResults.BorderStyle = BorderStyle.Fixed3D;
            dgv_SelectedChapterAuditResults.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(1, 188, 22);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(1, 188, 22);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv_SelectedChapterAuditResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv_SelectedChapterAuditResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_SelectedChapterAuditResults.EnableHeadersVisualStyles = false;
            dgv_SelectedChapterAuditResults.Location = new Point(373, 112);
            dgv_SelectedChapterAuditResults.MultiSelect = false;
            dgv_SelectedChapterAuditResults.Name = "dgv_SelectedChapterAuditResults";
            dgv_SelectedChapterAuditResults.ReadOnly = true;
            dgv_SelectedChapterAuditResults.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.LightGray;
            dataGridViewCellStyle6.ForeColor = Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(186, 255, 57);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_SelectedChapterAuditResults.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgv_SelectedChapterAuditResults.RowTemplate.Height = 25;
            dgv_SelectedChapterAuditResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_SelectedChapterAuditResults.Size = new Size(607, 262);
            dgv_SelectedChapterAuditResults.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
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
            dgv_CategorySelect.BorderStyle = BorderStyle.Fixed3D;
            dgv_CategorySelect.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(1, 188, 22);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(1, 188, 22);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgv_CategorySelect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgv_CategorySelect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_CategorySelect.ColumnHeadersVisible = false;
            dgv_CategorySelect.EnableHeadersVisualStyles = false;
            dgv_CategorySelect.Location = new Point(179, 112);
            dgv_CategorySelect.MultiSelect = false;
            dgv_CategorySelect.Name = "dgv_CategorySelect";
            dgv_CategorySelect.ReadOnly = true;
            dgv_CategorySelect.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.LightGray;
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(186, 255, 57);
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgv_CategorySelect.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgv_CategorySelect.RowTemplate.Height = 32;
            dgv_CategorySelect.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_CategorySelect.Size = new Size(188, 262);
            dgv_CategorySelect.TabIndex = 19;
            dgv_CategorySelect.CellClick += eSelCat;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(179, 89);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 20;
            label3.Text = "Select a Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(373, 89);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 21;
            label4.Text = "Audit Details";
            // 
            // rtb_ActionPlanDetail
            // 
            rtb_ActionPlanDetail.BorderStyle = BorderStyle.FixedSingle;
            rtb_ActionPlanDetail.Location = new Point(12, 410);
            rtb_ActionPlanDetail.Name = "rtb_ActionPlanDetail";
            rtb_ActionPlanDetail.Size = new Size(800, 204);
            rtb_ActionPlanDetail.TabIndex = 22;
            rtb_ActionPlanDetail.Text = "";
            rtb_ActionPlanDetail.TextChanged += rtb_ActionPlanDetail_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 387);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 23;
            label5.Text = "Action Plan";
            label5.Click += label5_Click;
            // 
            // btn_SaveActionPlan
            // 
            btn_SaveActionPlan.BackColor = Color.FromArgb(119, 186, 27);
            btn_SaveActionPlan.FlatAppearance.BorderSize = 0;
            btn_SaveActionPlan.FlatStyle = FlatStyle.Flat;
            btn_SaveActionPlan.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_SaveActionPlan.ForeColor = Color.White;
            btn_SaveActionPlan.Location = new Point(818, 431);
            btn_SaveActionPlan.Name = "btn_SaveActionPlan";
            btn_SaveActionPlan.Size = new Size(154, 32);
            btn_SaveActionPlan.TabIndex = 24;
            btn_SaveActionPlan.Text = "SAVE";
            btn_SaveActionPlan.UseVisualStyleBackColor = false;
            btn_SaveActionPlan.Click += btn_SaveActionPlan_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.Salmon;
            btn_Delete.FlatAppearance.BorderColor = Color.Salmon;
            btn_Delete.FlatAppearance.BorderSize = 3;
            btn_Delete.FlatStyle = FlatStyle.Flat;
            btn_Delete.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Delete.ForeColor = Color.White;
            btn_Delete.Location = new Point(818, 469);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(154, 32);
            btn_Delete.TabIndex = 25;
            btn_Delete.Text = "DELETE";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += button1_Click;
            // 
            // btn_pnl_Export
            // 
            btn_pnl_Export.BackColor = Color.Transparent;
            btn_pnl_Export.Controls.Add(btn_lbl_Export);
            btn_pnl_Export.Controls.Add(btn_pb_Export);
            btn_pnl_Export.Location = new Point(818, 587);
            btn_pnl_Export.Name = "btn_pnl_Export";
            btn_pnl_Export.Size = new Size(154, 32);
            btn_pnl_Export.TabIndex = 26;
            btn_pnl_Export.Click += PressExport;
            btn_pnl_Export.MouseEnter += MOExport;
            btn_pnl_Export.MouseLeave += MLExport;
            // 
            // btn_lbl_Export
            // 
            btn_lbl_Export.AutoSize = true;
            btn_lbl_Export.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_lbl_Export.ForeColor = Color.FromArgb(119, 186, 27);
            btn_lbl_Export.Location = new Point(32, 6);
            btn_lbl_Export.Name = "btn_lbl_Export";
            btn_lbl_Export.Size = new Size(119, 21);
            btn_lbl_Export.TabIndex = 28;
            btn_lbl_Export.Text = "Export to PDF";
            btn_lbl_Export.Click += PressExport;
            btn_lbl_Export.MouseEnter += MOExport;
            btn_lbl_Export.MouseLeave += MLExport;
            // 
            // btn_pb_Export
            // 
            btn_pb_Export.Image = Properties.Resources.Export_x32;
            btn_pb_Export.Location = new Point(0, 0);
            btn_pb_Export.Name = "btn_pb_Export";
            btn_pb_Export.Size = new Size(32, 32);
            btn_pb_Export.TabIndex = 27;
            btn_pb_Export.TabStop = false;
            btn_pb_Export.Click += PressExport;
            btn_pb_Export.MouseEnter += MOExport;
            btn_pb_Export.MouseLeave += MLExport;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(119, 186, 27);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.ForeColor = Color.White;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(984, 74);
            guna2Panel1.TabIndex = 27;
            // 
            // FormActionPlans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(984, 631);
            Controls.Add(guna2Panel1);
            Controls.Add(btn_pnl_Export);
            Controls.Add(btn_Delete);
            Controls.Add(btn_SaveActionPlan);
            Controls.Add(label5);
            Controls.Add(rtb_ActionPlanDetail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgv_CategorySelect);
            Controls.Add(label2);
            Controls.Add(dgv_SelectedChapterAuditResults);
            Controls.Add(dgv_ChapterSelect);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormActionPlans";
            Text = "FormActionPlans";
            Leave += FormActionPlans_Leave;
            ((System.ComponentModel.ISupportInitialize)dgv_ChapterSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_SelectedChapterAuditResults).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_CategorySelect).EndInit();
            btn_pnl_Export.ResumeLayout(false);
            btn_pnl_Export.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_pb_Export).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
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
        private Button btn_Delete;
        private Panel btn_pnl_Export;
        private Label btn_lbl_Export;
        private PictureBox btn_pb_Export;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
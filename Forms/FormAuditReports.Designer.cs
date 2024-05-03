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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuditReports));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            dgv_Results = new DataGridView();
            btn_DeleteEntry = new Button();
            btn_ResetEntries = new Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_Results).BeginInit();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 11);
            label1.Name = "label1";
            label1.Size = new Size(191, 32);
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
            dgv_Results.Location = new Point(27, 154);
            dgv_Results.MultiSelect = false;
            dgv_Results.Name = "dgv_Results";
            dgv_Results.ReadOnly = true;
            dgv_Results.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Gainsboro;
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.Padding = new Padding(0, 0, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(173, 223, 136);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgv_Results.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Results.RowTemplate.Height = 25;
            dgv_Results.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Results.Size = new Size(932, 450);
            dgv_Results.TabIndex = 51;
            dgv_Results.CellDoubleClick += Reportsdgv_CellContentClick;
            // 
            // btn_DeleteEntry
            // 
            btn_DeleteEntry.BackColor = Color.Transparent;
            btn_DeleteEntry.Cursor = Cursors.Hand;
            btn_DeleteEntry.FlatAppearance.BorderSize = 0;
            btn_DeleteEntry.FlatStyle = FlatStyle.Flat;
            btn_DeleteEntry.Font = new Font("Microsoft Sans Serif", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DeleteEntry.ForeColor = Color.Black;
            btn_DeleteEntry.Image = (Image)resources.GetObject("btn_DeleteEntry.Image");
            btn_DeleteEntry.Location = new Point(669, 104);
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
            btn_ResetEntries.Font = new Font("Microsoft Sans Serif", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ResetEntries.ForeColor = Color.Black;
            btn_ResetEntries.Image = (Image)resources.GetObject("btn_ResetEntries.Image");
            btn_ResetEntries.Location = new Point(814, 104);
            btn_ResetEntries.Name = "btn_ResetEntries";
            btn_ResetEntries.Size = new Size(171, 44);
            btn_ResetEntries.TabIndex = 53;
            btn_ResetEntries.Text = "Delete All Reports";
            btn_ResetEntries.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ResetEntries.UseVisualStyleBackColor = false;
            btn_ResetEntries.Click += btn_ResetEntries_Click;
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
            guna2Panel1.TabIndex = 54;
            // 
            // FormAuditReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(984, 631);
            Controls.Add(guna2Panel1);
            Controls.Add(btn_ResetEntries);
            Controls.Add(btn_DeleteEntry);
            Controls.Add(dgv_Results);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAuditReports";
            Text = "FormAuditReports";
            Load += FormAuditReports_Load;
            Leave += FormAuditReports_Leave;
            ((System.ComponentModel.ISupportInitialize)dgv_Results).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dgv_Results;
        private Button btn_DeleteEntry;
        private Button btn_ResetEntries;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
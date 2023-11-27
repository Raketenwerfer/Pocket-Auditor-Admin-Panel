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
            label1 = new Label();
            txtSearch = new TextBox();
            label2 = new Label();
            Reportsdgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Reportsdgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 24);
            label1.Name = "label1";
            label1.Size = new Size(167, 23);
            label1.TabIndex = 2;
            label1.Text = "AUDIT REPORTS";
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
            // Reportsdgv
            // 
            Reportsdgv.AllowUserToAddRows = false;
            Reportsdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Reportsdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Reportsdgv.Location = new Point(30, 98);
            Reportsdgv.Name = "Reportsdgv";
            Reportsdgv.RowTemplate.Height = 25;
            Reportsdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Reportsdgv.Size = new Size(847, 570);
            Reportsdgv.TabIndex = 51;
            Reportsdgv.CellContentClick += Reportsdgv_CellContentClick;
            // 
            // FormAuditReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 788);
            Controls.Add(Reportsdgv);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAuditReports";
            Text = "FormAuditReports";
            Load += FormAuditReports_Load;
            ((System.ComponentModel.ISupportInitialize)Reportsdgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Label label2;
        private DataGridView Reportsdgv;
    }
}
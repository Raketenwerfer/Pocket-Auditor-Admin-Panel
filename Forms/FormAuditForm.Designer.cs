namespace Pocket_Auditor_Admin_Panel.Forms
{
    partial class FormAuditForm
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
            label2 = new Label();
            txtCategoryName = new TextBox();
            label5 = new Label();
            txtIndicators = new TextBox();
            label6 = new Label();
            txtSubIndicators = new TextBox();
            cbxSubIndicators = new CheckBox();
            pnlSubIndicators = new Panel();
            btnSubDelete = new Button();
            btnSubUpdate = new Button();
            btnSubInsert = new Button();
            dgvSubIndicators = new DataGridView();
            label3 = new Label();
            cbxType = new ComboBox();
            btnIndiDelete = new Button();
            btnIndiUpdate = new Button();
            btnIndiInsert = new Button();
            btnCatDelete = new Button();
            btnCatUpdate = new Button();
            btnCatInsert = new Button();
            fLpDisplayForm = new FlowLayoutPanel();
            btnMobileForm = new Button();
            pnlSubIndicators.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubIndicators).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 1;
            label1.Text = "AUDIT FORM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 69);
            label2.Name = "label2";
            label2.Size = new Size(102, 16);
            label2.TabIndex = 2;
            label2.Text = "Category Name";
            // 
            // txtCategoryName
            // 
            txtCategoryName.BackColor = Color.Silver;
            txtCategoryName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoryName.Location = new Point(34, 90);
            txtCategoryName.Multiline = true;
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(317, 23);
            txtCategoryName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(32, 148);
            label5.Name = "label5";
            label5.Size = new Size(65, 16);
            label5.TabIndex = 14;
            label5.Text = "Indicators";
            // 
            // txtIndicators
            // 
            txtIndicators.BackColor = Color.Silver;
            txtIndicators.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtIndicators.Location = new Point(34, 169);
            txtIndicators.Multiline = true;
            txtIndicators.Name = "txtIndicators";
            txtIndicators.Size = new Size(317, 23);
            txtIndicators.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(14, 51);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 16;
            label6.Text = "Sub-Indicators";
            // 
            // txtSubIndicators
            // 
            txtSubIndicators.BackColor = Color.Silver;
            txtSubIndicators.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubIndicators.Location = new Point(16, 72);
            txtSubIndicators.Multiline = true;
            txtSubIndicators.Name = "txtSubIndicators";
            txtSubIndicators.Size = new Size(301, 23);
            txtSubIndicators.TabIndex = 17;
            // 
            // cbxSubIndicators
            // 
            cbxSubIndicators.AutoSize = true;
            cbxSubIndicators.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbxSubIndicators.Location = new Point(33, 241);
            cbxSubIndicators.Name = "cbxSubIndicators";
            cbxSubIndicators.Size = new Size(140, 20);
            cbxSubIndicators.TabIndex = 18;
            cbxSubIndicators.Text = "Add Sub-Indicators";
            cbxSubIndicators.UseVisualStyleBackColor = true;
            cbxSubIndicators.CheckedChanged += cbxSubIndicators_CheckedChanged;
            // 
            // pnlSubIndicators
            // 
            pnlSubIndicators.Controls.Add(btnSubDelete);
            pnlSubIndicators.Controls.Add(btnSubUpdate);
            pnlSubIndicators.Controls.Add(btnSubInsert);
            pnlSubIndicators.Controls.Add(dgvSubIndicators);
            pnlSubIndicators.Controls.Add(label3);
            pnlSubIndicators.Controls.Add(cbxType);
            pnlSubIndicators.Controls.Add(txtSubIndicators);
            pnlSubIndicators.Controls.Add(label6);
            pnlSubIndicators.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            pnlSubIndicators.Location = new Point(31, 267);
            pnlSubIndicators.Name = "pnlSubIndicators";
            pnlSubIndicators.Size = new Size(341, 342);
            pnlSubIndicators.TabIndex = 19;
            // 
            // btnSubDelete
            // 
            btnSubDelete.Location = new Point(246, 101);
            btnSubDelete.Name = "btnSubDelete";
            btnSubDelete.Size = new Size(71, 25);
            btnSubDelete.TabIndex = 22;
            btnSubDelete.Text = "Delete";
            btnSubDelete.UseVisualStyleBackColor = true;
            // 
            // btnSubUpdate
            // 
            btnSubUpdate.Location = new Point(169, 101);
            btnSubUpdate.Name = "btnSubUpdate";
            btnSubUpdate.Size = new Size(71, 25);
            btnSubUpdate.TabIndex = 22;
            btnSubUpdate.Text = "Update";
            btnSubUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSubInsert
            // 
            btnSubInsert.Location = new Point(92, 101);
            btnSubInsert.Name = "btnSubInsert";
            btnSubInsert.Size = new Size(71, 25);
            btnSubInsert.TabIndex = 21;
            btnSubInsert.Text = "Insert";
            btnSubInsert.UseVisualStyleBackColor = true;
            // 
            // dgvSubIndicators
            // 
            dgvSubIndicators.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubIndicators.Location = new Point(16, 147);
            dgvSubIndicators.Name = "dgvSubIndicators";
            dgvSubIndicators.RowTemplate.Height = 25;
            dgvSubIndicators.Size = new Size(301, 171);
            dgvSubIndicators.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 4);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 19;
            label3.Text = "Choose type";
            // 
            // cbxType
            // 
            cbxType.FormattingEnabled = true;
            cbxType.Items.AddRange(new object[] { "Details", "Options" });
            cbxType.Location = new Point(16, 25);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(301, 24);
            cbxType.TabIndex = 18;
            // 
            // btnIndiDelete
            // 
            btnIndiDelete.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIndiDelete.Location = new Point(277, 197);
            btnIndiDelete.Name = "btnIndiDelete";
            btnIndiDelete.Size = new Size(71, 25);
            btnIndiDelete.TabIndex = 28;
            btnIndiDelete.Text = "Delete";
            btnIndiDelete.UseVisualStyleBackColor = true;
            // 
            // btnIndiUpdate
            // 
            btnIndiUpdate.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIndiUpdate.Location = new Point(200, 197);
            btnIndiUpdate.Name = "btnIndiUpdate";
            btnIndiUpdate.Size = new Size(71, 25);
            btnIndiUpdate.TabIndex = 27;
            btnIndiUpdate.Text = "Update";
            btnIndiUpdate.UseVisualStyleBackColor = true;
            // 
            // btnIndiInsert
            // 
            btnIndiInsert.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIndiInsert.Location = new Point(123, 197);
            btnIndiInsert.Name = "btnIndiInsert";
            btnIndiInsert.Size = new Size(71, 25);
            btnIndiInsert.TabIndex = 26;
            btnIndiInsert.Text = "Insert";
            btnIndiInsert.UseVisualStyleBackColor = true;
            // 
            // btnCatDelete
            // 
            btnCatDelete.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCatDelete.Location = new Point(277, 119);
            btnCatDelete.Name = "btnCatDelete";
            btnCatDelete.Size = new Size(71, 25);
            btnCatDelete.TabIndex = 31;
            btnCatDelete.Text = "Delete";
            btnCatDelete.UseVisualStyleBackColor = true;
            // 
            // btnCatUpdate
            // 
            btnCatUpdate.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCatUpdate.Location = new Point(200, 119);
            btnCatUpdate.Name = "btnCatUpdate";
            btnCatUpdate.Size = new Size(71, 25);
            btnCatUpdate.TabIndex = 30;
            btnCatUpdate.Text = "Update";
            btnCatUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCatInsert
            // 
            btnCatInsert.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCatInsert.Location = new Point(123, 119);
            btnCatInsert.Name = "btnCatInsert";
            btnCatInsert.Size = new Size(71, 25);
            btnCatInsert.TabIndex = 29;
            btnCatInsert.Text = "Insert";
            btnCatInsert.UseVisualStyleBackColor = true;
            btnCatInsert.Click += btnCatInsert_Click;
            // 
            // fLpDisplayForm
            // 
            fLpDisplayForm.Location = new Point(378, 69);
            fLpDisplayForm.Name = "fLpDisplayForm";
            fLpDisplayForm.Size = new Size(504, 541);
            fLpDisplayForm.TabIndex = 32;
            // 
            // btnMobileForm
            // 
            btnMobileForm.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMobileForm.Location = new Point(378, 38);
            btnMobileForm.Name = "btnMobileForm";
            btnMobileForm.Size = new Size(143, 25);
            btnMobileForm.TabIndex = 33;
            btnMobileForm.Text = "Display Mobile Form";
            btnMobileForm.UseVisualStyleBackColor = true;
            // 
            // FormAuditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(915, 631);
            Controls.Add(btnMobileForm);
            Controls.Add(fLpDisplayForm);
            Controls.Add(btnCatDelete);
            Controls.Add(btnCatUpdate);
            Controls.Add(btnCatInsert);
            Controls.Add(btnIndiDelete);
            Controls.Add(btnIndiUpdate);
            Controls.Add(btnIndiInsert);
            Controls.Add(pnlSubIndicators);
            Controls.Add(cbxSubIndicators);
            Controls.Add(label5);
            Controls.Add(txtIndicators);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCategoryName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAuditForm";
            Text = "FormAuditForm";
            Load += FormAuditForm_Load;
            pnlSubIndicators.ResumeLayout(false);
            pnlSubIndicators.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubIndicators).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCategoryName;
        private Label label5;
        private TextBox txtIndicators;
        private Label label6;
        private TextBox txtSubIndicators;
        private CheckBox cbxSubIndicators;
        private Panel pnlSubIndicators;
        private Label label3;
        private ComboBox cbxType;
        private Button btnSubDelete;
        private Button btnSubUpdate;
        private Button btnSubInsert;
        private DataGridView dgvSubIndicators;
        private Button btnIndiDelete;
        private Button btnIndiUpdate;
        private Button btnIndiInsert;
        private Button btnCatDelete;
        private Button btnCatUpdate;
        private Button btnCatInsert;
        private FlowLayoutPanel fLpDisplayForm;
        private Button btnMobileForm;
    }
}
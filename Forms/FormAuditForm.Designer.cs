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
            label5 = new Label();
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
            fLpDisplayForm = new FlowLayoutPanel();
            label4 = new Label();
            txtCatID = new TextBox();
            txtCatName = new TextBox();
            txtIndicators = new TextBox();
            btnInsertData = new Button();
            btnUpdateData = new Button();
            btnDelData = new Button();
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
            label2.Location = new Point(32, 101);
            label2.Name = "label2";
            label2.Size = new Size(102, 16);
            label2.TabIndex = 2;
            label2.Text = "Category Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(32, 157);
            label5.Name = "label5";
            label5.Size = new Size(65, 16);
            label5.TabIndex = 14;
            label5.Text = "Indicators";
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
            cbxSubIndicators.Location = new Point(32, 243);
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
            pnlSubIndicators.Location = new Point(31, 273);
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
            btnSubDelete.Click += btnSubDelete_Click;
            // 
            // btnSubUpdate
            // 
            btnSubUpdate.Location = new Point(169, 101);
            btnSubUpdate.Name = "btnSubUpdate";
            btnSubUpdate.Size = new Size(71, 25);
            btnSubUpdate.TabIndex = 22;
            btnSubUpdate.Text = "Update";
            btnSubUpdate.UseVisualStyleBackColor = true;
            btnSubUpdate.Click += btnSubUpdate_Click;
            // 
            // btnSubInsert
            // 
            btnSubInsert.Location = new Point(92, 101);
            btnSubInsert.Name = "btnSubInsert";
            btnSubInsert.Size = new Size(71, 25);
            btnSubInsert.TabIndex = 21;
            btnSubInsert.Text = "Insert";
            btnSubInsert.UseVisualStyleBackColor = true;
            btnSubInsert.Click += btnSubInsert_Click;
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
            // fLpDisplayForm
            // 
            fLpDisplayForm.Location = new Point(494, 69);
            fLpDisplayForm.Name = "fLpDisplayForm";
            fLpDisplayForm.Size = new Size(388, 541);
            fLpDisplayForm.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 71);
            label4.Name = "label4";
            label4.Size = new Size(78, 16);
            label4.TabIndex = 34;
            label4.Text = "Category ID";
            // 
            // txtCatID
            // 
            txtCatID.Location = new Point(116, 69);
            txtCatID.Name = "txtCatID";
            txtCatID.Size = new Size(100, 23);
            txtCatID.TabIndex = 36;
            txtCatID.KeyPress += txtCatID_KeyPress_1;
            // 
            // txtCatName
            // 
            txtCatName.Location = new Point(131, 99);
            txtCatName.Multiline = true;
            txtCatName.Name = "txtCatName";
            txtCatName.Size = new Size(211, 52);
            txtCatName.TabIndex = 37;
            // 
            // txtIndicators
            // 
            txtIndicators.Location = new Point(131, 157);
            txtIndicators.Multiline = true;
            txtIndicators.Name = "txtIndicators";
            txtIndicators.Size = new Size(211, 52);
            txtIndicators.TabIndex = 38;
            // 
            // btnInsertData
            // 
            btnInsertData.Location = new Point(363, 100);
            btnInsertData.Name = "btnInsertData";
            btnInsertData.Size = new Size(75, 23);
            btnInsertData.TabIndex = 39;
            btnInsertData.Text = "INSERT";
            btnInsertData.UseVisualStyleBackColor = true;
            btnInsertData.Click += btnInsertData_Click;
            // 
            // btnUpdateData
            // 
            btnUpdateData.Location = new Point(363, 138);
            btnUpdateData.Name = "btnUpdateData";
            btnUpdateData.Size = new Size(75, 23);
            btnUpdateData.TabIndex = 40;
            btnUpdateData.Text = "UPDATE";
            btnUpdateData.UseVisualStyleBackColor = true;
            btnUpdateData.Click += btnUpdateData_Click;
            // 
            // btnDelData
            // 
            btnDelData.Location = new Point(363, 177);
            btnDelData.Name = "btnDelData";
            btnDelData.Size = new Size(75, 23);
            btnDelData.TabIndex = 41;
            btnDelData.Text = "DELETE";
            btnDelData.UseVisualStyleBackColor = true;
            btnDelData.Click += btnDelData_Click;
            // 
            // FormAuditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(915, 631);
            Controls.Add(btnDelData);
            Controls.Add(btnUpdateData);
            Controls.Add(btnInsertData);
            Controls.Add(txtIndicators);
            Controls.Add(txtCatName);
            Controls.Add(txtCatID);
            Controls.Add(label4);
            Controls.Add(fLpDisplayForm);
            Controls.Add(pnlSubIndicators);
            Controls.Add(cbxSubIndicators);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label5;
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
        private FlowLayoutPanel fLpDisplayForm;
        private Label label4;
        private TextBox txtCatID;
        private TextBox txtCatName;
        private TextBox txtIndicators;
        private Button btnInsertData;
        private Button btnUpdateData;
        private Button btnDelData;
    }
}
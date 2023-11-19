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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button3 = new Button();
            txtCatName = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            pnlSubIndicators = new Panel();
            btnSubDelete = new Button();
            btnSubUpdate = new Button();
            btnSubInsert = new Button();
            dgvSubIndicators = new DataGridView();
            label3 = new Label();
            cbxType = new ComboBox();
            txtSubIndicators = new TextBox();
            label6 = new Label();
            cbxSubIndicators = new CheckBox();
            btnDelData = new Button();
            btnUpdateData = new Button();
            btnInsertData = new Button();
            txtIndicators = new TextBox();
            label5 = new Label();
            fLpDisplayForm = new FlowLayoutPanel();
            label4 = new Label();
            textBox1 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            pnlSubIndicators.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubIndicators).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 17);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 1;
            label1.Text = "AUDIT FORM";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 48);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(810, 571);
            tabControl1.TabIndex = 42;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(fLpDisplayForm);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(txtCatName);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(802, 543);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Categories";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(574, 26);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 42;
            button3.Text = "INSERT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtCatName
            // 
            txtCatName.Location = new Point(247, 23);
            txtCatName.Multiline = true;
            txtCatName.Name = "txtCatName";
            txtCatName.Size = new Size(321, 26);
            txtCatName.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(139, 29);
            label2.Name = "label2";
            label2.Size = new Size(102, 16);
            label2.TabIndex = 38;
            label2.Text = "Category Name";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(flowLayoutPanel1);
            tabPage2.Controls.Add(pnlSubIndicators);
            tabPage2.Controls.Add(cbxSubIndicators);
            tabPage2.Controls.Add(btnDelData);
            tabPage2.Controls.Add(btnUpdateData);
            tabPage2.Controls.Add(btnInsertData);
            tabPage2.Controls.Add(txtIndicators);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(802, 543);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Indicators";
            tabPage2.UseVisualStyleBackColor = true;
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
            pnlSubIndicators.Location = new Point(28, 106);
            pnlSubIndicators.Name = "pnlSubIndicators";
            pnlSubIndicators.Size = new Size(743, 149);
            pnlSubIndicators.TabIndex = 48;
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
            dgvSubIndicators.Location = new Point(343, 25);
            dgvSubIndicators.Name = "dgvSubIndicators";
            dgvSubIndicators.RowTemplate.Height = 25;
            dgvSubIndicators.Size = new Size(371, 101);
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
            // cbxSubIndicators
            // 
            cbxSubIndicators.AutoSize = true;
            cbxSubIndicators.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbxSubIndicators.Location = new Point(28, 80);
            cbxSubIndicators.Name = "cbxSubIndicators";
            cbxSubIndicators.Size = new Size(140, 20);
            cbxSubIndicators.TabIndex = 47;
            cbxSubIndicators.Text = "Add Sub-Indicators";
            cbxSubIndicators.UseVisualStyleBackColor = true;
            cbxSubIndicators.CheckedChanged += cbxSubIndicators_CheckedChanged;
            // 
            // btnDelData
            // 
            btnDelData.Location = new Point(190, 51);
            btnDelData.Name = "btnDelData";
            btnDelData.Size = new Size(75, 23);
            btnDelData.TabIndex = 46;
            btnDelData.Text = "DELETE";
            btnDelData.UseVisualStyleBackColor = true;
            // 
            // btnUpdateData
            // 
            btnUpdateData.Location = new Point(109, 51);
            btnUpdateData.Name = "btnUpdateData";
            btnUpdateData.Size = new Size(75, 23);
            btnUpdateData.TabIndex = 45;
            btnUpdateData.Text = "UPDATE";
            btnUpdateData.UseVisualStyleBackColor = true;
            // 
            // btnInsertData
            // 
            btnInsertData.Location = new Point(371, 19);
            btnInsertData.Name = "btnInsertData";
            btnInsertData.Size = new Size(75, 23);
            btnInsertData.TabIndex = 44;
            btnInsertData.Text = "INSERT";
            btnInsertData.UseVisualStyleBackColor = true;
            // 
            // txtIndicators
            // 
            txtIndicators.Location = new Point(148, 20);
            txtIndicators.Multiline = true;
            txtIndicators.Name = "txtIndicators";
            txtIndicators.Size = new Size(211, 16);
            txtIndicators.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(28, 20);
            label5.Name = "label5";
            label5.Size = new Size(114, 16);
            label5.TabIndex = 42;
            label5.Text = "Indicator Question";
            // 
            // fLpDisplayForm
            // 
            fLpDisplayForm.Location = new Point(18, 129);
            fLpDisplayForm.Name = "fLpDisplayForm";
            fLpDisplayForm.Size = new Size(765, 396);
            fLpDisplayForm.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 94);
            label4.Name = "label4";
            label4.Size = new Size(131, 16);
            label4.TabIndex = 46;
            label4.Text = "Find Category Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 92);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(629, 20);
            textBox1.TabIndex = 47;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(28, 269);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(743, 247);
            flowLayoutPanel1.TabIndex = 49;
            // 
            // FormAuditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(838, 631);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAuditForm";
            Text = "FormAuditForm";
            Load += FormAuditForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            pnlSubIndicators.ResumeLayout(false);
            pnlSubIndicators.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubIndicators).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button3;
        private TextBox txtCatName;
        private Label label2;
        private CheckBox cbxSubIndicators;
        private Button btnDelData;
        private Button btnUpdateData;
        private Button btnInsertData;
        private TextBox txtIndicators;
        private Label label5;
        private Panel pnlSubIndicators;
        private Button btnSubDelete;
        private Button btnSubUpdate;
        private Button btnSubInsert;
        private DataGridView dgvSubIndicators;
        private Label label3;
        private ComboBox cbxType;
        private TextBox txtSubIndicators;
        private Label label6;
        private FlowLayoutPanel fLpDisplayForm;
        private TextBox textBox1;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
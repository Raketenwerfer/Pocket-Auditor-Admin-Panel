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
            CatDeletebtn = new Button();
            CatUpdatebtn = new Button();
            Catdgv = new DataGridView();
            CatInsertbtn = new Button();
            txtCatName = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            IndicatorNumbertxt = new TextBox();
            label10 = new Label();
            num_IndicatorSV = new NumericUpDown();
            label7 = new Label();
            pnlSubIndicators = new Panel();
            num_SubIndicatorSV = new NumericUpDown();
            label9 = new Label();
            label4 = new Label();
            btnSubIndSubmitEvent = new Button();
            SubIndicatorsdgv = new DataGridView();
            label3 = new Label();
            cbxType = new ComboBox();
            txtSubIndicators = new TextBox();
            label6 = new Label();
            cbox_IndicatorFilterbyCategory = new ComboBox();
            SubIndicatorscbx = new CheckBox();
            Indicatordgv = new DataGridView();
            Indicatortxt = new TextBox();
            CatIDcbx = new ComboBox();
            label8 = new Label();
            IndicatorInsertbtn = new Button();
            label5 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Catdgv).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_IndicatorSV).BeginInit();
            pnlSubIndicators.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_SubIndicatorSV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SubIndicatorsdgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Indicatordgv).BeginInit();
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
            tabControl1.Location = new Point(15, 46);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(879, 558);
            tabControl1.TabIndex = 42;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(CatDeletebtn);
            tabPage1.Controls.Add(CatUpdatebtn);
            tabPage1.Controls.Add(Catdgv);
            tabPage1.Controls.Add(CatInsertbtn);
            tabPage1.Controls.Add(txtCatName);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(871, 530);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Categories";
            // 
            // CatDeletebtn
            // 
            CatDeletebtn.Location = new Point(439, 103);
            CatDeletebtn.Name = "CatDeletebtn";
            CatDeletebtn.Size = new Size(75, 23);
            CatDeletebtn.TabIndex = 52;
            CatDeletebtn.Text = "DELETE";
            CatDeletebtn.UseVisualStyleBackColor = true;
            CatDeletebtn.Click += CatDeletebtn_Click;
            // 
            // CatUpdatebtn
            // 
            CatUpdatebtn.Location = new Point(358, 103);
            CatUpdatebtn.Name = "CatUpdatebtn";
            CatUpdatebtn.Size = new Size(75, 23);
            CatUpdatebtn.TabIndex = 51;
            CatUpdatebtn.Text = "UPDATE";
            CatUpdatebtn.UseVisualStyleBackColor = true;
            CatUpdatebtn.Click += CatUpdatebtn_Click;
            // 
            // Catdgv
            // 
            Catdgv.AllowUserToAddRows = false;
            Catdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Catdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Catdgv.Location = new Point(22, 157);
            Catdgv.MultiSelect = false;
            Catdgv.Name = "Catdgv";
            Catdgv.ReadOnly = true;
            Catdgv.RowTemplate.Height = 25;
            Catdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Catdgv.Size = new Size(824, 358);
            Catdgv.TabIndex = 50;
            Catdgv.CellClick += Catdgv_CellClick;
            // 
            // CatInsertbtn
            // 
            CatInsertbtn.Location = new Point(358, 74);
            CatInsertbtn.Name = "CatInsertbtn";
            CatInsertbtn.Size = new Size(156, 23);
            CatInsertbtn.TabIndex = 42;
            CatInsertbtn.Text = "INSERT";
            CatInsertbtn.UseVisualStyleBackColor = true;
            CatInsertbtn.Click += CatInsertbtn_Click;
            // 
            // txtCatName
            // 
            txtCatName.Location = new Point(242, 45);
            txtCatName.Multiline = true;
            txtCatName.Name = "txtCatName";
            txtCatName.Size = new Size(385, 23);
            txtCatName.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(384, 26);
            label2.Name = "label2";
            label2.Size = new Size(102, 16);
            label2.TabIndex = 38;
            label2.Text = "Category Name";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(IndicatorNumbertxt);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(num_IndicatorSV);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(pnlSubIndicators);
            tabPage2.Controls.Add(cbox_IndicatorFilterbyCategory);
            tabPage2.Controls.Add(SubIndicatorscbx);
            tabPage2.Controls.Add(Indicatordgv);
            tabPage2.Controls.Add(Indicatortxt);
            tabPage2.Controls.Add(CatIDcbx);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(IndicatorInsertbtn);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(871, 530);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Indicators";
            tabPage2.Enter += Indicatordgv_Leave;
            // 
            // IndicatorNumbertxt
            // 
            IndicatorNumbertxt.BackColor = Color.White;
            IndicatorNumbertxt.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IndicatorNumbertxt.Location = new Point(679, 5);
            IndicatorNumbertxt.Multiline = true;
            IndicatorNumbertxt.Name = "IndicatorNumbertxt";
            IndicatorNumbertxt.Size = new Size(103, 24);
            IndicatorNumbertxt.TabIndex = 61;
            IndicatorNumbertxt.Enter += Indicatordgv_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(564, 8);
            label10.Name = "label10";
            label10.Size = new Size(109, 16);
            label10.TabIndex = 60;
            label10.Text = "Indicator Number";
            // 
            // num_IndicatorSV
            // 
            num_IndicatorSV.Location = new Point(679, 35);
            num_IndicatorSV.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            num_IndicatorSV.Name = "num_IndicatorSV";
            num_IndicatorSV.Size = new Size(41, 23);
            num_IndicatorSV.TabIndex = 59;
            num_IndicatorSV.Enter += Indicatordgv_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(592, 37);
            label7.Name = "label7";
            label7.Size = new Size(81, 16);
            label7.TabIndex = 58;
            label7.Text = "Score Value";
            // 
            // pnlSubIndicators
            // 
            pnlSubIndicators.Controls.Add(num_SubIndicatorSV);
            pnlSubIndicators.Controls.Add(label9);
            pnlSubIndicators.Controls.Add(label4);
            pnlSubIndicators.Controls.Add(btnSubIndSubmitEvent);
            pnlSubIndicators.Controls.Add(SubIndicatorsdgv);
            pnlSubIndicators.Controls.Add(label3);
            pnlSubIndicators.Controls.Add(cbxType);
            pnlSubIndicators.Controls.Add(txtSubIndicators);
            pnlSubIndicators.Controls.Add(label6);
            pnlSubIndicators.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            pnlSubIndicators.Location = new Point(16, 266);
            pnlSubIndicators.Name = "pnlSubIndicators";
            pnlSubIndicators.Size = new Size(840, 258);
            pnlSubIndicators.TabIndex = 50;
            // 
            // num_SubIndicatorSV
            // 
            num_SubIndicatorSV.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            num_SubIndicatorSV.Location = new Point(407, 39);
            num_SubIndicatorSV.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            num_SubIndicatorSV.Name = "num_SubIndicatorSV";
            num_SubIndicatorSV.Size = new Size(41, 22);
            num_SubIndicatorSV.TabIndex = 60;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(320, 42);
            label9.Name = "label9";
            label9.Size = new Size(81, 16);
            label9.TabIndex = 56;
            label9.Text = "Score Value";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(8, 86);
            label4.Name = "label4";
            label4.Size = new Size(148, 16);
            label4.TabIndex = 23;
            label4.Text = "INDICATOR NUMBER: ";
            // 
            // btnSubIndSubmitEvent
            // 
            btnSubIndSubmitEvent.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubIndSubmitEvent.Location = new Point(755, 73);
            btnSubIndSubmitEvent.Name = "btnSubIndSubmitEvent";
            btnSubIndSubmitEvent.Size = new Size(71, 25);
            btnSubIndSubmitEvent.TabIndex = 22;
            btnSubIndSubmitEvent.Text = "TEXT HERE";
            btnSubIndSubmitEvent.UseVisualStyleBackColor = true;
            btnSubIndSubmitEvent.Click += btnSubIndSubmitEvent_Click;
            // 
            // SubIndicatorsdgv
            // 
            SubIndicatorsdgv.AllowUserToAddRows = false;
            SubIndicatorsdgv.AllowUserToDeleteRows = false;
            SubIndicatorsdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SubIndicatorsdgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            SubIndicatorsdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SubIndicatorsdgv.Location = new Point(3, 105);
            SubIndicatorsdgv.MultiSelect = false;
            SubIndicatorsdgv.Name = "SubIndicatorsdgv";
            SubIndicatorsdgv.ReadOnly = true;
            SubIndicatorsdgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            SubIndicatorsdgv.RowTemplate.Height = 25;
            SubIndicatorsdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SubIndicatorsdgv.Size = new Size(827, 140);
            SubIndicatorsdgv.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(67, 42);
            label3.Name = "label3";
            label3.Size = new Size(89, 16);
            label3.TabIndex = 19;
            label3.Text = "Choose Type";
            // 
            // cbxType
            // 
            cbxType.FormattingEnabled = true;
            cbxType.Items.AddRange(new object[] { "DETAILS", "OPTIONS" });
            cbxType.Location = new Point(162, 39);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(128, 24);
            cbxType.TabIndex = 18;
            // 
            // txtSubIndicators
            // 
            txtSubIndicators.BackColor = Color.White;
            txtSubIndicators.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubIndicators.Location = new Point(162, 9);
            txtSubIndicators.Multiline = true;
            txtSubIndicators.Name = "txtSubIndicators";
            txtSubIndicators.Size = new Size(320, 24);
            txtSubIndicators.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(14, 12);
            label6.Name = "label6";
            label6.Size = new Size(142, 16);
            label6.TabIndex = 16;
            label6.Text = "Sub-Indicator Question";
            // 
            // cbox_IndicatorFilterbyCategory
            // 
            cbox_IndicatorFilterbyCategory.FormattingEnabled = true;
            cbox_IndicatorFilterbyCategory.Location = new Point(19, 96);
            cbox_IndicatorFilterbyCategory.Name = "cbox_IndicatorFilterbyCategory";
            cbox_IndicatorFilterbyCategory.Size = new Size(226, 23);
            cbox_IndicatorFilterbyCategory.TabIndex = 54;
            cbox_IndicatorFilterbyCategory.Text = "Sort By Category";
            cbox_IndicatorFilterbyCategory.SelectedIndexChanged += cbox_IndicatorFilterbyCategory_SelectedIndexChanged;
            cbox_IndicatorFilterbyCategory.Enter += Indicatordgv_Leave;
            // 
            // SubIndicatorscbx
            // 
            SubIndicatorscbx.AutoSize = true;
            SubIndicatorscbx.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SubIndicatorscbx.Location = new Point(414, 62);
            SubIndicatorscbx.Name = "SubIndicatorscbx";
            SubIndicatorscbx.Size = new Size(140, 20);
            SubIndicatorscbx.TabIndex = 49;
            SubIndicatorscbx.Text = "Add Sub-Indicators";
            SubIndicatorscbx.UseVisualStyleBackColor = true;
            SubIndicatorscbx.CheckedChanged += SubIndicatorscbx_CheckedChanged;
            // 
            // Indicatordgv
            // 
            Indicatordgv.AllowUserToAddRows = false;
            Indicatordgv.AllowUserToDeleteRows = false;
            Indicatordgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Indicatordgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Indicatordgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Indicatordgv.Location = new Point(19, 125);
            Indicatordgv.MultiSelect = false;
            Indicatordgv.Name = "Indicatordgv";
            Indicatordgv.ReadOnly = true;
            Indicatordgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            Indicatordgv.RowTemplate.Height = 25;
            Indicatordgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Indicatordgv.Size = new Size(827, 135);
            Indicatordgv.TabIndex = 53;
            Indicatordgv.CellClick += Indicatordgv_CellClick;
            Indicatordgv.CellDoubleClick += Indicatordgv_CellDoubleClick;
            // 
            // Indicatortxt
            // 
            Indicatortxt.Location = new Point(139, 6);
            Indicatortxt.Multiline = true;
            Indicatortxt.Name = "Indicatortxt";
            Indicatortxt.Size = new Size(415, 47);
            Indicatortxt.TabIndex = 52;
            Indicatortxt.Enter += Indicatordgv_Leave;
            // 
            // CatIDcbx
            // 
            CatIDcbx.FormattingEnabled = true;
            CatIDcbx.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            CatIDcbx.Location = new Point(139, 59);
            CatIDcbx.Name = "CatIDcbx";
            CatIDcbx.Size = new Size(232, 23);
            CatIDcbx.TabIndex = 51;
            CatIDcbx.Enter += Indicatordgv_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(8, 59);
            label8.Name = "label8";
            label8.Size = new Size(122, 16);
            label8.TabIndex = 50;
            label8.Text = "Assigned Category";
            // 
            // IndicatorInsertbtn
            // 
            IndicatorInsertbtn.Location = new Point(771, 95);
            IndicatorInsertbtn.Name = "IndicatorInsertbtn";
            IndicatorInsertbtn.Size = new Size(75, 23);
            IndicatorInsertbtn.TabIndex = 44;
            IndicatorInsertbtn.Text = "INSERT";
            IndicatorInsertbtn.UseVisualStyleBackColor = true;
            IndicatorInsertbtn.Click += IndicatorInsertbtn_Click;
            IndicatorInsertbtn.Enter += Indicatordgv_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 8);
            label5.Name = "label5";
            label5.Size = new Size(114, 16);
            label5.TabIndex = 42;
            label5.Text = "Indicator Question";
            // 
            // FormAuditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(915, 612);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAuditForm";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "FormAuditForm";
            Load += FormAuditForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Catdgv).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_IndicatorSV).EndInit();
            pnlSubIndicators.ResumeLayout(false);
            pnlSubIndicators.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_SubIndicatorSV).EndInit();
            ((System.ComponentModel.ISupportInitialize)SubIndicatorsdgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)Indicatordgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button CatInsertbtn;
        private TextBox txtCatName;
        private Label label2;
        private Button IndicatorInsertbtn;
        private Label label5;
        private DataGridView Catdgv;
        private Button CatUpdatebtn;
        private Button CatDeletebtn;
        private TextBox Indicatortxt;
        private ComboBox CatIDcbx;
        private Label label8;
        private DataGridView Indicatordgv;
        private ComboBox cbox_IndicatorFilterbyCategory;
        private Panel pnlSubIndicators;
        private Button btnSubIndSubmitEvent;
        private DataGridView SubIndicatorsdgv;
        private Label label3;
        private ComboBox cbxType;
        private TextBox txtSubIndicators;
        private Label label6;
        private CheckBox SubIndicatorscbx;
        private Label label4;
        private Label label9;
        private Label label7;
        private NumericUpDown num_IndicatorSV;
        private NumericUpDown num_SubIndicatorSV;
        private TextBox IndicatorNumbertxt;
        private Label label10;
    }
}
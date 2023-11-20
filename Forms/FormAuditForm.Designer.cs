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
            comboBox1 = new ComboBox();
            Indicatordgv = new DataGridView();
            Indicatortxt = new TextBox();
            CatIDcbx = new ComboBox();
            label8 = new Label();
            pnlSubIndicators = new Panel();
            btnSubDelete = new Button();
            btnSubUpdate = new Button();
            btnSubInsert = new Button();
            SubIndicatorsdgv = new DataGridView();
            label3 = new Label();
            cbxType = new ComboBox();
            txtSubIndicators = new TextBox();
            label6 = new Label();
            SubIndicatorscbx = new CheckBox();
            IndicatorDeletebtn = new Button();
            IndicatorUpdatebtn = new Button();
            IndicatorInsertbtn = new Button();
            label5 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Catdgv).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Indicatordgv).BeginInit();
            pnlSubIndicators.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SubIndicatorsdgv).BeginInit();
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
            tabControl1.Size = new Size(879, 540);
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
            tabPage1.Size = new Size(871, 512);
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
            Catdgv.Name = "Catdgv";
            Catdgv.RowTemplate.Height = 25;
            Catdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Catdgv.Size = new Size(824, 334);
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
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(Indicatordgv);
            tabPage2.Controls.Add(Indicatortxt);
            tabPage2.Controls.Add(CatIDcbx);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(pnlSubIndicators);
            tabPage2.Controls.Add(SubIndicatorscbx);
            tabPage2.Controls.Add(IndicatorDeletebtn);
            tabPage2.Controls.Add(IndicatorUpdatebtn);
            tabPage2.Controls.Add(IndicatorInsertbtn);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(871, 512);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Indicators";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox1.Location = new Point(28, 140);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 23);
            comboBox1.TabIndex = 54;
            comboBox1.Text = "Sort By Category ID";
            // 
            // Indicatordgv
            // 
            Indicatordgv.AllowUserToAddRows = false;
            Indicatordgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Indicatordgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Indicatordgv.Location = new Point(28, 169);
            Indicatordgv.Name = "Indicatordgv";
            Indicatordgv.RowTemplate.Height = 25;
            Indicatordgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Indicatordgv.Size = new Size(371, 367);
            Indicatordgv.TabIndex = 53;
            Indicatordgv.CellClick += Indicatordgv_CellClick;
            // 
            // Indicatortxt
            // 
            Indicatortxt.Location = new Point(144, 52);
            Indicatortxt.Multiline = true;
            Indicatortxt.Name = "Indicatortxt";
            Indicatortxt.Size = new Size(217, 67);
            Indicatortxt.TabIndex = 52;
            // 
            // CatIDcbx
            // 
            CatIDcbx.FormattingEnabled = true;
            CatIDcbx.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            CatIDcbx.Location = new Point(158, 17);
            CatIDcbx.Name = "CatIDcbx";
            CatIDcbx.Size = new Size(86, 23);
            CatIDcbx.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(19, 19);
            label8.Name = "label8";
            label8.Size = new Size(128, 16);
            label8.TabIndex = 50;
            label8.Text = "Choose Category ID";
            // 
            // pnlSubIndicators
            // 
            pnlSubIndicators.Controls.Add(btnSubDelete);
            pnlSubIndicators.Controls.Add(btnSubUpdate);
            pnlSubIndicators.Controls.Add(btnSubInsert);
            pnlSubIndicators.Controls.Add(SubIndicatorsdgv);
            pnlSubIndicators.Controls.Add(label3);
            pnlSubIndicators.Controls.Add(cbxType);
            pnlSubIndicators.Controls.Add(txtSubIndicators);
            pnlSubIndicators.Controls.Add(label6);
            pnlSubIndicators.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            pnlSubIndicators.Location = new Point(452, 52);
            pnlSubIndicators.Name = "pnlSubIndicators";
            pnlSubIndicators.Size = new Size(419, 468);
            pnlSubIndicators.TabIndex = 48;
            // 
            // btnSubDelete
            // 
            btnSubDelete.Location = new Point(242, 165);
            btnSubDelete.Name = "btnSubDelete";
            btnSubDelete.Size = new Size(71, 25);
            btnSubDelete.TabIndex = 22;
            btnSubDelete.Text = "Delete";
            btnSubDelete.UseVisualStyleBackColor = true;
            btnSubDelete.Click += btnSubDelete_Click;
            // 
            // btnSubUpdate
            // 
            btnSubUpdate.Location = new Point(165, 165);
            btnSubUpdate.Name = "btnSubUpdate";
            btnSubUpdate.Size = new Size(71, 25);
            btnSubUpdate.TabIndex = 22;
            btnSubUpdate.Text = "Update";
            btnSubUpdate.UseVisualStyleBackColor = true;
            btnSubUpdate.Click += btnSubUpdate_Click;
            // 
            // btnSubInsert
            // 
            btnSubInsert.Location = new Point(326, 102);
            btnSubInsert.Name = "btnSubInsert";
            btnSubInsert.Size = new Size(71, 25);
            btnSubInsert.TabIndex = 21;
            btnSubInsert.Text = "Insert";
            btnSubInsert.UseVisualStyleBackColor = true;
            btnSubInsert.Click += btnSubInsert_Click;
            // 
            // SubIndicatorsdgv
            // 
            SubIndicatorsdgv.AllowUserToAddRows = false;
            SubIndicatorsdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SubIndicatorsdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SubIndicatorsdgv.Location = new Point(26, 206);
            SubIndicatorsdgv.Name = "SubIndicatorsdgv";
            SubIndicatorsdgv.RowTemplate.Height = 25;
            SubIndicatorsdgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SubIndicatorsdgv.Size = new Size(371, 241);
            SubIndicatorsdgv.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 22);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 19;
            label3.Text = "Choose type";
            // 
            // cbxType
            // 
            cbxType.FormattingEnabled = true;
            cbxType.Items.AddRange(new object[] { "Details", "Options" });
            cbxType.Location = new Point(16, 43);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(301, 24);
            cbxType.TabIndex = 18;
            // 
            // txtSubIndicators
            // 
            txtSubIndicators.BackColor = Color.Silver;
            txtSubIndicators.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubIndicators.Location = new Point(16, 90);
            txtSubIndicators.Multiline = true;
            txtSubIndicators.Name = "txtSubIndicators";
            txtSubIndicators.Size = new Size(301, 49);
            txtSubIndicators.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(14, 69);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 16;
            label6.Text = "Sub-Indicators";
            // 
            // SubIndicatorscbx
            // 
            SubIndicatorscbx.AutoSize = true;
            SubIndicatorscbx.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SubIndicatorscbx.Location = new Point(466, 19);
            SubIndicatorscbx.Name = "SubIndicatorscbx";
            SubIndicatorscbx.Size = new Size(140, 20);
            SubIndicatorscbx.TabIndex = 47;
            SubIndicatorscbx.Text = "Add Sub-Indicators";
            SubIndicatorscbx.UseVisualStyleBackColor = true;
            SubIndicatorscbx.CheckedChanged += SubIndicatorscbx_CheckedChanged;
            // 
            // IndicatorDeletebtn
            // 
            IndicatorDeletebtn.Location = new Point(321, 140);
            IndicatorDeletebtn.Name = "IndicatorDeletebtn";
            IndicatorDeletebtn.Size = new Size(75, 23);
            IndicatorDeletebtn.TabIndex = 46;
            IndicatorDeletebtn.Text = "DELETE";
            IndicatorDeletebtn.UseVisualStyleBackColor = true;
            IndicatorDeletebtn.Click += IndicatorDeletebtn_Click;
            // 
            // IndicatorUpdatebtn
            // 
            IndicatorUpdatebtn.Location = new Point(240, 140);
            IndicatorUpdatebtn.Name = "IndicatorUpdatebtn";
            IndicatorUpdatebtn.Size = new Size(75, 23);
            IndicatorUpdatebtn.TabIndex = 45;
            IndicatorUpdatebtn.Text = "UPDATE";
            IndicatorUpdatebtn.UseVisualStyleBackColor = true;
            IndicatorUpdatebtn.Click += IndicatorUpdatebtn_Click;
            // 
            // IndicatorInsertbtn
            // 
            IndicatorInsertbtn.Location = new Point(286, 18);
            IndicatorInsertbtn.Name = "IndicatorInsertbtn";
            IndicatorInsertbtn.Size = new Size(75, 23);
            IndicatorInsertbtn.TabIndex = 44;
            IndicatorInsertbtn.Text = "INSERT";
            IndicatorInsertbtn.UseVisualStyleBackColor = true;
            IndicatorInsertbtn.Click += IndicatorInsertbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 54);
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
            ClientSize = new Size(915, 631);
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
            ((System.ComponentModel.ISupportInitialize)Indicatordgv).EndInit();
            pnlSubIndicators.ResumeLayout(false);
            pnlSubIndicators.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SubIndicatorsdgv).EndInit();
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
        private CheckBox SubIndicatorscbx;
        private Button IndicatorDeletebtn;
        private Button IndicatorUpdatebtn;
        private Button IndicatorInsertbtn;
        private Label label5;
        private Panel pnlSubIndicators;
        private Button btnSubDelete;
        private Button btnSubUpdate;
        private Button btnSubInsert;
        private DataGridView SubIndicatorsdgv;
        private Label label3;
        private ComboBox cbxType;
        private TextBox txtSubIndicators;
        private Label label6;
        private DataGridView Catdgv;
        private Button CatUpdatebtn;
        private Button CatDeletebtn;
        private TextBox Indicatortxt;
        private ComboBox CatIDcbx;
        private Label label8;
        private DataGridView Indicatordgv;
        private ComboBox comboBox1;
    }
}
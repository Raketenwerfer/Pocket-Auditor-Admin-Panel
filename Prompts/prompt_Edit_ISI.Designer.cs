namespace Pocket_Auditor_Admin_Panel.Prompts
{
    partial class prompt_Edit_ISI
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
            lbl_itemname = new Label();
            lbl_itemnumber = new Label();
            lbl_itemscorevalue = new Label();
            lbl_assignment_or_dgvname = new Label();
            prmpt_dgv_subind = new DataGridView();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)prmpt_dgv_subind).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lbl_itemname
            // 
            lbl_itemname.AutoSize = true;
            lbl_itemname.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_itemname.Location = new Point(30, 17);
            lbl_itemname.Name = "lbl_itemname";
            lbl_itemname.Size = new Size(74, 17);
            lbl_itemname.TabIndex = 0;
            lbl_itemname.Text = "---Indicator";
            // 
            // lbl_itemnumber
            // 
            lbl_itemnumber.AutoSize = true;
            lbl_itemnumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_itemnumber.Location = new Point(27, 89);
            lbl_itemnumber.Name = "lbl_itemnumber";
            lbl_itemnumber.Size = new Size(71, 17);
            lbl_itemnumber.TabIndex = 1;
            lbl_itemnumber.Text = "---Number";
            // 
            // lbl_itemscorevalue
            // 
            lbl_itemscorevalue.AutoSize = true;
            lbl_itemscorevalue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_itemscorevalue.Location = new Point(27, 122);
            lbl_itemscorevalue.Name = "lbl_itemscorevalue";
            lbl_itemscorevalue.Size = new Size(87, 17);
            lbl_itemscorevalue.TabIndex = 2;
            lbl_itemscorevalue.Text = "---ScoreValue";
            // 
            // lbl_assignment_or_dgvname
            // 
            lbl_assignment_or_dgvname.AutoSize = true;
            lbl_assignment_or_dgvname.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_assignment_or_dgvname.Location = new Point(27, 154);
            lbl_assignment_or_dgvname.Name = "lbl_assignment_or_dgvname";
            lbl_assignment_or_dgvname.Size = new Size(133, 17);
            lbl_assignment_or_dgvname.TabIndex = 3;
            lbl_assignment_or_dgvname.Text = "---Assigned Category";
            // 
            // prmpt_dgv_subind
            // 
            prmpt_dgv_subind.AllowUserToAddRows = false;
            prmpt_dgv_subind.AllowUserToDeleteRows = false;
            prmpt_dgv_subind.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            prmpt_dgv_subind.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            prmpt_dgv_subind.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prmpt_dgv_subind.Location = new Point(0, 197);
            prmpt_dgv_subind.MultiSelect = false;
            prmpt_dgv_subind.Name = "prmpt_dgv_subind";
            prmpt_dgv_subind.ReadOnly = true;
            prmpt_dgv_subind.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            prmpt_dgv_subind.RowTemplate.Height = 25;
            prmpt_dgv_subind.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            prmpt_dgv_subind.Size = new Size(443, 194);
            prmpt_dgv_subind.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(196, 16);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 64);
            textBox1.TabIndex = 22;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(196, 119);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(47, 23);
            numericUpDown1.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(196, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(85, 23);
            textBox2.TabIndex = 24;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(196, 154);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 23);
            comboBox1.TabIndex = 25;
            // 
            // prompt_Edit_ISI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(444, 391);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(prmpt_dgv_subind);
            Controls.Add(lbl_assignment_or_dgvname);
            Controls.Add(lbl_itemscorevalue);
            Controls.Add(lbl_itemnumber);
            Controls.Add(lbl_itemname);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "prompt_Edit_ISI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Item";
            ((System.ComponentModel.ISupportInitialize)prmpt_dgv_subind).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_itemname;
        private Label lbl_itemnumber;
        private Label lbl_itemscorevalue;
        private Label lbl_assignment_or_dgvname;
        private DataGridView prmpt_dgv_subind;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private ComboBox comboBox1;
    }
}
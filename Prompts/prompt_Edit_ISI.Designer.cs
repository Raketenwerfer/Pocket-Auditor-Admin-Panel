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
            lbl_editType = new Label();
            prmpt_dgv_subind = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)prmpt_dgv_subind).BeginInit();
            SuspendLayout();
            // 
            // lbl_itemname
            // 
            lbl_itemname.AutoSize = true;
            lbl_itemname.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_itemname.Location = new Point(23, 63);
            lbl_itemname.Name = "lbl_itemname";
            lbl_itemname.Size = new Size(74, 17);
            lbl_itemname.TabIndex = 0;
            lbl_itemname.Text = "---Indicator";
            // 
            // lbl_itemnumber
            // 
            lbl_itemnumber.AutoSize = true;
            lbl_itemnumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_itemnumber.Location = new Point(23, 130);
            lbl_itemnumber.Name = "lbl_itemnumber";
            lbl_itemnumber.Size = new Size(71, 17);
            lbl_itemnumber.TabIndex = 1;
            lbl_itemnumber.Text = "---Number";
            // 
            // lbl_itemscorevalue
            // 
            lbl_itemscorevalue.AutoSize = true;
            lbl_itemscorevalue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_itemscorevalue.Location = new Point(23, 97);
            lbl_itemscorevalue.Name = "lbl_itemscorevalue";
            lbl_itemscorevalue.Size = new Size(87, 17);
            lbl_itemscorevalue.TabIndex = 2;
            lbl_itemscorevalue.Text = "---ScoreValue";
            // 
            // lbl_assignment_or_dgvname
            // 
            lbl_assignment_or_dgvname.AutoSize = true;
            lbl_assignment_or_dgvname.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_assignment_or_dgvname.Location = new Point(23, 162);
            lbl_assignment_or_dgvname.Name = "lbl_assignment_or_dgvname";
            lbl_assignment_or_dgvname.Size = new Size(133, 17);
            lbl_assignment_or_dgvname.TabIndex = 3;
            lbl_assignment_or_dgvname.Text = "---Assigned Category";
            // 
            // lbl_editType
            // 
            lbl_editType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_editType.AutoSize = true;
            lbl_editType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_editType.Location = new Point(114, 18);
            lbl_editType.Name = "lbl_editType";
            lbl_editType.Size = new Size(225, 21);
            lbl_editType.TabIndex = 4;
            lbl_editType.Text = "Editing >IND/SUBINDICATOR<";
            lbl_editType.TextAlign = ContentAlignment.MiddleCenter;
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
            // prompt_Edit_ISI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 391);
            Controls.Add(prmpt_dgv_subind);
            Controls.Add(lbl_editType);
            Controls.Add(lbl_assignment_or_dgvname);
            Controls.Add(lbl_itemscorevalue);
            Controls.Add(lbl_itemnumber);
            Controls.Add(lbl_itemname);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "prompt_Edit_ISI";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Item";
            ((System.ComponentModel.ISupportInitialize)prmpt_dgv_subind).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_itemname;
        private Label lbl_itemnumber;
        private Label lbl_itemscorevalue;
        private Label lbl_assignment_or_dgvname;
        private Label lbl_editType;
        private DataGridView prmpt_dgv_subind;
    }
}
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
            label1 = new Label();
            label2 = new Label();
            txtPlanName = new TextBox();
            label3 = new Label();
            cbxA_CatList = new ComboBox();
            txtPlanDetails = new TextBox();
            label4 = new Label();
            txtLink = new TextBox();
            label5 = new Label();
            dgvActionPlans = new DataGridView();
            btnA_Insert = new Button();
            btnA_Delete = new Button();
            btnA_Update = new Button();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvActionPlans).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(154, 23);
            label1.TabIndex = 2;
            label1.Text = "ACTION PLANS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(87, 87);
            label2.Name = "label2";
            label2.Size = new Size(138, 18);
            label2.TabIndex = 3;
            label2.Text = "Action Plan Name";
            // 
            // txtPlanName
            // 
            txtPlanName.BackColor = Color.Silver;
            txtPlanName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPlanName.Location = new Point(253, 84);
            txtPlanName.Name = "txtPlanName";
            txtPlanName.Size = new Size(337, 27);
            txtPlanName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(117, 134);
            label3.Name = "label3";
            label3.Size = new Size(107, 18);
            label3.TabIndex = 5;
            label3.Text = "Category List";
            // 
            // cbxA_CatList
            // 
            cbxA_CatList.BackColor = Color.Silver;
            cbxA_CatList.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxA_CatList.FormattingEnabled = true;
            cbxA_CatList.Location = new Point(253, 131);
            cbxA_CatList.Name = "cbxA_CatList";
            cbxA_CatList.Size = new Size(337, 26);
            cbxA_CatList.TabIndex = 6;
            cbxA_CatList.Text = "Choose a Category Here";
            // 
            // txtPlanDetails
            // 
            txtPlanDetails.BackColor = Color.Silver;
            txtPlanDetails.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPlanDetails.Location = new Point(253, 213);
            txtPlanDetails.Name = "txtPlanDetails";
            txtPlanDetails.Size = new Size(337, 27);
            txtPlanDetails.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(87, 216);
            label4.Name = "label4";
            label4.Size = new Size(143, 18);
            label4.TabIndex = 7;
            label4.Text = "Action Plan Details";
            // 
            // txtLink
            // 
            txtLink.BackColor = Color.Silver;
            txtLink.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLink.Location = new Point(253, 260);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(337, 27);
            txtLink.TabIndex = 10;
            txtLink.Text = "Paste link here";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(124, 263);
            label5.Name = "label5";
            label5.Size = new Size(102, 18);
            label5.TabIndex = 9;
            label5.Text = "External Link";
            // 
            // dgvActionPlans
            // 
            dgvActionPlans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActionPlans.Location = new Point(32, 351);
            dgvActionPlans.Name = "dgvActionPlans";
            dgvActionPlans.RowTemplate.Height = 25;
            dgvActionPlans.Size = new Size(806, 256);
            dgvActionPlans.TabIndex = 11;
            // 
            // btnA_Insert
            // 
            btnA_Insert.BackColor = Color.Lime;
            btnA_Insert.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnA_Insert.Location = new Point(388, 312);
            btnA_Insert.Name = "btnA_Insert";
            btnA_Insert.Size = new Size(82, 33);
            btnA_Insert.TabIndex = 12;
            btnA_Insert.Text = "Insert";
            btnA_Insert.UseVisualStyleBackColor = false;
            // 
            // btnA_Delete
            // 
            btnA_Delete.BackColor = Color.Red;
            btnA_Delete.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnA_Delete.ForeColor = Color.White;
            btnA_Delete.Location = new Point(756, 312);
            btnA_Delete.Name = "btnA_Delete";
            btnA_Delete.Size = new Size(82, 33);
            btnA_Delete.TabIndex = 13;
            btnA_Delete.Text = "Delete";
            btnA_Delete.UseVisualStyleBackColor = false;
            // 
            // btnA_Update
            // 
            btnA_Update.BackColor = Color.FromArgb(0, 192, 192);
            btnA_Update.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnA_Update.Location = new Point(494, 312);
            btnA_Update.Name = "btnA_Update";
            btnA_Update.Size = new Size(82, 33);
            btnA_Update.TabIndex = 14;
            btnA_Update.Text = "Update";
            btnA_Update.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(325, 173);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(183, 22);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Apply to All Category";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormActionPlans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 631);
            Controls.Add(checkBox1);
            Controls.Add(btnA_Update);
            Controls.Add(btnA_Delete);
            Controls.Add(btnA_Insert);
            Controls.Add(dgvActionPlans);
            Controls.Add(txtLink);
            Controls.Add(label5);
            Controls.Add(txtPlanDetails);
            Controls.Add(label4);
            Controls.Add(cbxA_CatList);
            Controls.Add(label3);
            Controls.Add(txtPlanName);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormActionPlans";
            Text = "FormActionPlans";
            ((System.ComponentModel.ISupportInitialize)dgvActionPlans).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPlanName;
        private Label label3;
        private ComboBox cbxA_CatList;
        private TextBox txtPlanDetails;
        private Label label4;
        private TextBox txtLink;
        private Label label5;
        private DataGridView dgvActionPlans;
        private Button btnA_Insert;
        private Button btnA_Delete;
        private Button btnA_Update;
        private CheckBox checkBox1;
    }
}
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
            cbxAPlanType = new ComboBox();
            txtPlanDetails = new TextBox();
            label4 = new Label();
            btnA_Insert = new Button();
            btnA_Delete = new Button();
            btnA_Update = new Button();
            APlandgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)APlandgv).BeginInit();
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
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 84);
            label2.Name = "label2";
            label2.Size = new Size(114, 16);
            label2.TabIndex = 3;
            label2.Text = "Action Plan Name";
            // 
            // txtPlanName
            // 
            txtPlanName.BackColor = Color.Silver;
            txtPlanName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPlanName.Location = new Point(37, 103);
            txtPlanName.Name = "txtPlanName";
            txtPlanName.Size = new Size(368, 22);
            txtPlanName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 225);
            label3.Name = "label3";
            label3.Size = new Size(109, 16);
            label3.TabIndex = 5;
            label3.Text = "Action Plan Type";
            // 
            // cbxAPlanType
            // 
            cbxAPlanType.BackColor = Color.Silver;
            cbxAPlanType.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbxAPlanType.FormattingEnabled = true;
            cbxAPlanType.Items.AddRange(new object[] { "Singular", "Multiple ", "General" });
            cbxAPlanType.Location = new Point(38, 244);
            cbxAPlanType.Name = "cbxAPlanType";
            cbxAPlanType.Size = new Size(367, 24);
            cbxAPlanType.TabIndex = 6;
            // 
            // txtPlanDetails
            // 
            txtPlanDetails.BackColor = Color.Silver;
            txtPlanDetails.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPlanDetails.Location = new Point(38, 157);
            txtPlanDetails.Multiline = true;
            txtPlanDetails.Name = "txtPlanDetails";
            txtPlanDetails.Size = new Size(367, 50);
            txtPlanDetails.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 138);
            label4.Name = "label4";
            label4.Size = new Size(119, 16);
            label4.TabIndex = 7;
            label4.Text = "Action Plan Details";
            // 
            // btnA_Insert
            // 
            btnA_Insert.BackColor = Color.Lime;
            btnA_Insert.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnA_Insert.Location = new Point(323, 283);
            btnA_Insert.Name = "btnA_Insert";
            btnA_Insert.Size = new Size(82, 33);
            btnA_Insert.TabIndex = 12;
            btnA_Insert.Text = "Insert";
            btnA_Insert.UseVisualStyleBackColor = false;
            btnA_Insert.Click += btnA_Insert_Click;
            // 
            // btnA_Delete
            // 
            btnA_Delete.BackColor = Color.Red;
            btnA_Delete.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnA_Delete.ForeColor = Color.White;
            btnA_Delete.Location = new Point(800, 64);
            btnA_Delete.Name = "btnA_Delete";
            btnA_Delete.Size = new Size(86, 33);
            btnA_Delete.TabIndex = 13;
            btnA_Delete.Text = "Delete";
            btnA_Delete.UseVisualStyleBackColor = false;
            btnA_Delete.Click += btnA_Delete_Click;
            // 
            // btnA_Update
            // 
            btnA_Update.BackColor = Color.FromArgb(0, 192, 192);
            btnA_Update.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnA_Update.Location = new Point(685, 64);
            btnA_Update.Name = "btnA_Update";
            btnA_Update.Size = new Size(82, 33);
            btnA_Update.TabIndex = 14;
            btnA_Update.Text = "Update";
            btnA_Update.UseVisualStyleBackColor = false;
            btnA_Update.Click += btnA_Update_Click;
            // 
            // APlandgv
            // 
            APlandgv.AllowUserToAddRows = false;
            APlandgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            APlandgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            APlandgv.Location = new Point(430, 103);
            APlandgv.Name = "APlandgv";
            APlandgv.RowTemplate.Height = 25;
            APlandgv.Size = new Size(456, 499);
            APlandgv.TabIndex = 16;
            APlandgv.CellClick += APlandgv_CellClick;
            // 
            // FormActionPlans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 631);
            Controls.Add(APlandgv);
            Controls.Add(btnA_Update);
            Controls.Add(btnA_Delete);
            Controls.Add(btnA_Insert);
            Controls.Add(txtPlanDetails);
            Controls.Add(label4);
            Controls.Add(cbxAPlanType);
            Controls.Add(label3);
            Controls.Add(txtPlanName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormActionPlans";
            Text = "FormActionPlans";
            Load += FormActionPlans_Load;
            ((System.ComponentModel.ISupportInitialize)APlandgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPlanName;
        private Label label3;
        private ComboBox cbxAPlanType;
        private TextBox txtPlanDetails;
        private Label label4;
        private Button btnA_Insert;
        private Button btnA_Delete;
        private Button btnA_Update;
        private DataGridView APlandgv;
    }
}
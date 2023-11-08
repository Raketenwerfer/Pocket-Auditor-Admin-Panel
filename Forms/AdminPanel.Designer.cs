namespace Pocket_Audior_Admin_Panel
{
    partial class AdminPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnAuditForm = new Button();
            btnActionPlans = new Button();
            btnAuditReports = new Button();
            btnManageAuditors = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            lblTitle = new Label();
            panelContent = new Panel();
            panelMenu.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ActiveBorder;
            panelMenu.Controls.Add(btnAuditForm);
            panelMenu.Controls.Add(btnActionPlans);
            panelMenu.Controls.Add(btnAuditReports);
            panelMenu.Controls.Add(btnManageAuditors);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 631);
            panelMenu.TabIndex = 0;
            // 
            // btnAuditForm
            // 
            btnAuditForm.Location = new Point(25, 140);
            btnAuditForm.Name = "btnAuditForm";
            btnAuditForm.Size = new Size(137, 46);
            btnAuditForm.TabIndex = 1;
            btnAuditForm.Text = "Audit Form";
            btnAuditForm.UseVisualStyleBackColor = true;
            btnAuditForm.Click += btnAuditForm_Click;
            // 
            // btnActionPlans
            // 
            btnActionPlans.Location = new Point(25, 192);
            btnActionPlans.Name = "btnActionPlans";
            btnActionPlans.Size = new Size(137, 46);
            btnActionPlans.TabIndex = 2;
            btnActionPlans.Text = "Action Plans";
            btnActionPlans.UseVisualStyleBackColor = true;
            btnActionPlans.Click += btnActionPlans_Click;
            // 
            // btnAuditReports
            // 
            btnAuditReports.Location = new Point(25, 244);
            btnAuditReports.Name = "btnAuditReports";
            btnAuditReports.Size = new Size(137, 46);
            btnAuditReports.TabIndex = 3;
            btnAuditReports.Text = "Audit Reports";
            btnAuditReports.UseVisualStyleBackColor = true;
            btnAuditReports.Click += btnAuditReports_Click;
            // 
            // btnManageAuditors
            // 
            btnManageAuditors.Location = new Point(25, 296);
            btnManageAuditors.Name = "btnManageAuditors";
            btnManageAuditors.Size = new Size(137, 46);
            btnManageAuditors.TabIndex = 4;
            btnManageAuditors.Text = "Manage Auditors";
            btnManageAuditors.UseVisualStyleBackColor = true;
            btnManageAuditors.Click += btnManageAuditors_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(25, 88);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(137, 46);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Controls.Add(lblTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(915, 80);
            panel2.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(411, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(54, 18);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TITLE";
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(200, 80);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(915, 551);
            panelContent.TabIndex = 2;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 631);
            Controls.Add(panelContent);
            Controls.Add(panel2);
            Controls.Add(panelMenu);
            Name = "AdminPanel";
            Text = "Admin";
            Load += AdminPanel_Load;
            panelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnAuditForm;
        private Button btnActionPlans;
        private Button btnAuditReports;
        private Button btnManageAuditors;
        private Button btnDashboard;
        private Panel panel2;
        private Label lblTitle;
        private Panel panelContent;
    }
}
namespace Pocket_Auditor_Admin_Panel
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
            button1 = new Button();
            btnAuditForm = new Button();
            btnActionPlans = new Button();
            btnAuditReports = new Button();
            btnManageAuditors = new Button();
            btnDashboard = new Button();
            panelContent = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Green;
            panelMenu.Controls.Add(button1);
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
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(200, 0);
            button1.TabIndex = 5;
            button1.Text = "ADMIN PANEL";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnAuditForm
            // 
            btnAuditForm.Location = new Point(29, 149);
            btnAuditForm.Name = "btnAuditForm";
            btnAuditForm.Size = new Size(139, 50);
            btnAuditForm.TabIndex = 1;
            btnAuditForm.Text = "Audit Form";
            btnAuditForm.UseVisualStyleBackColor = true;
            btnAuditForm.Click += btnAuditForm_Click;
            // 
            // btnActionPlans
            // 
            btnActionPlans.Location = new Point(29, 206);
            btnActionPlans.Name = "btnActionPlans";
            btnActionPlans.Size = new Size(139, 50);
            btnActionPlans.TabIndex = 2;
            btnActionPlans.Text = "Action Plans";
            btnActionPlans.UseVisualStyleBackColor = true;
            btnActionPlans.Click += btnActionPlans_Click;
            // 
            // btnAuditReports
            // 
            btnAuditReports.Location = new Point(29, 262);
            btnAuditReports.Name = "btnAuditReports";
            btnAuditReports.Size = new Size(139, 50);
            btnAuditReports.TabIndex = 3;
            btnAuditReports.Text = "Audit Reports";
            btnAuditReports.UseVisualStyleBackColor = true;
            btnAuditReports.Click += btnAuditReports_Click;
            // 
            // btnManageAuditors
            // 
            btnManageAuditors.Location = new Point(29, 319);
            btnManageAuditors.Name = "btnManageAuditors";
            btnManageAuditors.Size = new Size(139, 50);
            btnManageAuditors.TabIndex = 4;
            btnManageAuditors.Text = "Manage Auditors";
            btnManageAuditors.UseVisualStyleBackColor = true;
            btnManageAuditors.Click += btnManageAuditors_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(29, 91);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(139, 50);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panelContent.Location = new Point(200, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(915, 631);
            panelContent.TabIndex = 2;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 631);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += AdminPanel_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnAuditForm;
        private Button btnActionPlans;
        private Button btnAuditReports;
        private Button btnManageAuditors;
        private Button btnDashboard;
        private Panel panelContent;
        private Button button1;
    }
}
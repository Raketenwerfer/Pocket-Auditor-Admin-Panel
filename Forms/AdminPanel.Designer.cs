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
            pictureBox1 = new PictureBox();
            btnLogOut = new Button();
            button1 = new Button();
            btnAuditForm = new Button();
            btnActionPlans = new Button();
            btnAuditReports = new Button();
            btnManageAuditors = new Button();
            btnDashboard = new Button();
            panelContent = new Panel();
            panel2 = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Green;
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(btnLogOut);
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._352514791_278804624543271_4286607186819115630_n;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            btnLogOut.Dock = DockStyle.Bottom;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Image = Properties.Resources.icons8_logout_32__2_;
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(0, 581);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(40, 0, 0, 0);
            btnLogOut.Size = new Size(200, 50);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = "Logout";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogOut.UseVisualStyleBackColor = true;
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
            btnAuditForm.FlatAppearance.BorderSize = 0;
            btnAuditForm.FlatStyle = FlatStyle.Flat;
            btnAuditForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAuditForm.ForeColor = Color.White;
            btnAuditForm.Image = Properties.Resources.icons8_task_32;
            btnAuditForm.ImageAlign = ContentAlignment.MiddleLeft;
            btnAuditForm.Location = new Point(0, 214);
            btnAuditForm.Name = "btnAuditForm";
            btnAuditForm.Padding = new Padding(25, 0, 0, 0);
            btnAuditForm.Size = new Size(200, 50);
            btnAuditForm.TabIndex = 1;
            btnAuditForm.Text = "Audit Form";
            btnAuditForm.TextAlign = ContentAlignment.MiddleLeft;
            btnAuditForm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAuditForm.UseVisualStyleBackColor = true;
            btnAuditForm.Click += btnAuditForm_Click;
            // 
            // btnActionPlans
            // 
            btnActionPlans.FlatAppearance.BorderSize = 0;
            btnActionPlans.FlatStyle = FlatStyle.Flat;
            btnActionPlans.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnActionPlans.ForeColor = Color.White;
            btnActionPlans.Image = Properties.Resources.icons8_survey_32;
            btnActionPlans.ImageAlign = ContentAlignment.MiddleLeft;
            btnActionPlans.Location = new Point(0, 270);
            btnActionPlans.Name = "btnActionPlans";
            btnActionPlans.Padding = new Padding(25, 0, 0, 0);
            btnActionPlans.Size = new Size(200, 50);
            btnActionPlans.TabIndex = 2;
            btnActionPlans.Text = "Action Plans";
            btnActionPlans.TextAlign = ContentAlignment.MiddleLeft;
            btnActionPlans.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActionPlans.UseVisualStyleBackColor = true;
            btnActionPlans.Click += btnActionPlans_Click;
            // 
            // btnAuditReports
            // 
            btnAuditReports.FlatAppearance.BorderSize = 0;
            btnAuditReports.FlatStyle = FlatStyle.Flat;
            btnAuditReports.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAuditReports.ForeColor = Color.White;
            btnAuditReports.Image = Properties.Resources.icons8_what_i_do_32__2_;
            btnAuditReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnAuditReports.Location = new Point(0, 326);
            btnAuditReports.Name = "btnAuditReports";
            btnAuditReports.Padding = new Padding(25, 0, 0, 0);
            btnAuditReports.Size = new Size(200, 50);
            btnAuditReports.TabIndex = 3;
            btnAuditReports.Text = "Audit Reports";
            btnAuditReports.TextAlign = ContentAlignment.MiddleLeft;
            btnAuditReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAuditReports.UseVisualStyleBackColor = true;
            btnAuditReports.Click += btnAuditReports_Click;
            // 
            // btnManageAuditors
            // 
            btnManageAuditors.FlatAppearance.BorderSize = 0;
            btnManageAuditors.FlatStyle = FlatStyle.Flat;
            btnManageAuditors.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnManageAuditors.ForeColor = Color.White;
            btnManageAuditors.Image = Properties.Resources.icons8_manage_32__1_1;
            btnManageAuditors.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageAuditors.Location = new Point(0, 382);
            btnManageAuditors.Name = "btnManageAuditors";
            btnManageAuditors.Padding = new Padding(15, 0, 0, 0);
            btnManageAuditors.Size = new Size(200, 50);
            btnManageAuditors.TabIndex = 4;
            btnManageAuditors.Text = "Manage Auditors";
            btnManageAuditors.TextAlign = ContentAlignment.MiddleLeft;
            btnManageAuditors.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnManageAuditors.UseVisualStyleBackColor = true;
            btnManageAuditors.Click += btnManageAuditors_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = Properties.Resources.icons8_system_administrator_male_32__1_;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 158);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(25, 0, 0, 0);
            btnDashboard.Size = new Size(200, 50);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(panel2);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panelContent.Location = new Point(200, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(904, 631);
            panelContent.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 584);
            panel2.Name = "panel2";
            panel2.Size = new Size(904, 47);
            panel2.TabIndex = 0;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1184, 631);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pocket Auditor - Admin Panel";
            Load += AdminPanel_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContent.ResumeLayout(false);
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
        private Button btnLogOut;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}
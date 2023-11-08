namespace Pocket_Audior_Admin_Panel.Forms
{
    partial class form2
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
            btnStartAudit = new Button();
            btnRecordsSubmitted = new Button();
            btnRecentSubmissions = new Button();
            btnViewRankings = new Button();
            SuspendLayout();
            // 
            // btnStartAudit
            // 
            btnStartAudit.Dock = DockStyle.Top;
            btnStartAudit.Location = new Point(0, 0);
            btnStartAudit.Name = "btnStartAudit";
            btnStartAudit.Size = new Size(834, 74);
            btnStartAudit.TabIndex = 0;
            btnStartAudit.Text = "Start / Stop Audit";
            btnStartAudit.UseVisualStyleBackColor = true;
            // 
            // btnRecordsSubmitted
            // 
            btnRecordsSubmitted.Dock = DockStyle.Top;
            btnRecordsSubmitted.Location = new Point(0, 74);
            btnRecordsSubmitted.Name = "btnRecordsSubmitted";
            btnRecordsSubmitted.Size = new Size(834, 74);
            btnRecordsSubmitted.TabIndex = 1;
            btnRecordsSubmitted.Text = "View Total Records Submitted";
            btnRecordsSubmitted.UseVisualStyleBackColor = true;
            // 
            // btnRecentSubmissions
            // 
            btnRecentSubmissions.Dock = DockStyle.Top;
            btnRecentSubmissions.Location = new Point(0, 148);
            btnRecentSubmissions.Name = "btnRecentSubmissions";
            btnRecentSubmissions.Size = new Size(834, 74);
            btnRecentSubmissions.TabIndex = 2;
            btnRecentSubmissions.Text = "View Recent Submissions";
            btnRecentSubmissions.UseVisualStyleBackColor = true;
            // 
            // btnViewRankings
            // 
            btnViewRankings.Dock = DockStyle.Top;
            btnViewRankings.Location = new Point(0, 222);
            btnViewRankings.Name = "btnViewRankings";
            btnViewRankings.Size = new Size(834, 74);
            btnViewRankings.TabIndex = 3;
            btnViewRankings.Text = "View Rankings";
            btnViewRankings.UseVisualStyleBackColor = true;
            // 
            // form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 523);
            Controls.Add(btnViewRankings);
            Controls.Add(btnRecentSubmissions);
            Controls.Add(btnRecordsSubmitted);
            Controls.Add(btnStartAudit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form2";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnStartAudit;
        private Button btnRecordsSubmitted;
        private Button btnRecentSubmissions;
        private Button btnViewRankings;
    }
}
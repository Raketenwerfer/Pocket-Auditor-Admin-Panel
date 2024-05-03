namespace Pocket_Auditor_Admin_Panel.Forms
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            flp_Ranks = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            btn_ViewChapters = new Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 37);
            label1.Name = "label1";
            label1.Size = new Size(145, 37);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flp_Ranks
            // 
            flp_Ranks.AutoScrollMargin = new Size(2, 2);
            flp_Ranks.BackColor = SystemColors.Control;
            flp_Ranks.ForeColor = Color.Black;
            flp_Ranks.Location = new Point(26, 185);
            flp_Ranks.Name = "flp_Ranks";
            flp_Ranks.Size = new Size(932, 418);
            flp_Ranks.TabIndex = 4;
            flp_Ranks.Paint += flp_Ranks_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(119, 186, 27);
            label2.Location = new Point(26, 112);
            label2.Name = "label2";
            label2.Size = new Size(119, 32);
            label2.TabIndex = 5;
            label2.Text = "Rankings";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(556, 45);
            label3.TabIndex = 6;
            label3.Text = "CCYDC Pocket Auditor Admin Panel";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_ViewChapters
            // 
            btn_ViewChapters.Cursor = Cursors.Hand;
            btn_ViewChapters.FlatAppearance.BorderSize = 0;
            btn_ViewChapters.FlatStyle = FlatStyle.Flat;
            btn_ViewChapters.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ViewChapters.ForeColor = Color.White;
            btn_ViewChapters.Image = (Image)resources.GetObject("btn_ViewChapters.Image");
            btn_ViewChapters.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ViewChapters.Location = new Point(750, 0);
            btn_ViewChapters.Name = "btn_ViewChapters";
            btn_ViewChapters.Padding = new Padding(12, 0, 0, 0);
            btn_ViewChapters.RightToLeft = RightToLeft.No;
            btn_ViewChapters.Size = new Size(234, 48);
            btn_ViewChapters.TabIndex = 8;
            btn_ViewChapters.Text = "View list of Barangays";
            btn_ViewChapters.TextAlign = ContentAlignment.MiddleLeft;
            btn_ViewChapters.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ViewChapters.UseVisualStyleBackColor = true;
            btn_ViewChapters.Click += ShowChapters;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(119, 186, 27);
            guna2HtmlLabel1.Location = new Point(39, 147);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(136, 34);
            guna2HtmlLabel1.TabIndex = 9;
            guna2HtmlLabel1.Text = "BARANGAY";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel2.ForeColor = Color.FromArgb(119, 186, 27);
            guna2HtmlLabel2.Location = new Point(810, 147);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(111, 34);
            guna2HtmlLabel2.TabIndex = 10;
            guna2HtmlLabel2.Text = "AUDITOR";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(119, 186, 27);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(btn_ViewChapters);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(984, 74);
            guna2Panel1.TabIndex = 11;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 631);
            Controls.Add(guna2Panel1);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(label2);
            Controls.Add(flp_Ranks);
            ForeColor = Color.FromArgb(110, 172, 78);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDashboard";
            Text = "FormDashboard";
            Leave += FormDashboard_Leave;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flp_Ranks;
        private Label label2;
        private Label label3;
        private Button btn_ViewChapters;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
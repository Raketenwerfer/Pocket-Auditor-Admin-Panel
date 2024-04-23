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
            label1 = new Label();
            btn_pnl_AF = new Panel();
            btn_lbl_AF = new Label();
            btn_pb_AF = new PictureBox();
            btn_pnl_AP = new Panel();
            btn_lbl_AP = new Label();
            btn_pn_AP = new PictureBox();
            btn_pnl_AR = new Panel();
            btn_lbl_AR = new Label();
            btn_pb_AR = new PictureBox();
            flp_Ranks = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            btn_DirectAddUser = new Button();
            btn_ViewChapters = new Button();
            btn_pnl_AF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_pb_AF).BeginInit();
            btn_pnl_AP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_pn_AP).BeginInit();
            btn_pnl_AR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_pb_AR).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HP Simplified", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 55);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_pnl_AF
            // 
            btn_pnl_AF.BackColor = Color.MediumAquamarine;
            btn_pnl_AF.Controls.Add(btn_lbl_AF);
            btn_pnl_AF.Controls.Add(btn_pb_AF);
            btn_pnl_AF.Cursor = Cursors.Hand;
            btn_pnl_AF.Location = new Point(26, 340);
            btn_pnl_AF.Name = "btn_pnl_AF";
            btn_pnl_AF.Size = new Size(270, 270);
            btn_pnl_AF.TabIndex = 2;
            btn_pnl_AF.Click += SelectAF;
            btn_pnl_AF.MouseEnter += HoverAF;
            btn_pnl_AF.MouseLeave += LeaveAF;
            // 
            // btn_lbl_AF
            // 
            btn_lbl_AF.AutoSize = true;
            btn_lbl_AF.Font = new Font("HP Simplified", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_lbl_AF.Location = new Point(70, 224);
            btn_lbl_AF.Name = "btn_lbl_AF";
            btn_lbl_AF.Size = new Size(132, 28);
            btn_lbl_AF.TabIndex = 3;
            btn_lbl_AF.Text = "Audit Forms";
            btn_lbl_AF.Click += SelectAF;
            btn_lbl_AF.MouseEnter += HoverAF;
            btn_lbl_AF.MouseLeave += LeaveAF;
            // 
            // btn_pb_AF
            // 
            btn_pb_AF.Image = (Image)resources.GetObject("btn_pb_AF.Image");
            btn_pb_AF.Location = new Point(39, 21);
            btn_pb_AF.Name = "btn_pb_AF";
            btn_pb_AF.Size = new Size(209, 190);
            btn_pb_AF.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_pb_AF.TabIndex = 2;
            btn_pb_AF.TabStop = false;
            btn_pb_AF.Click += SelectAF;
            btn_pb_AF.MouseEnter += HoverAF;
            btn_pb_AF.MouseLeave += LeaveAF;
            // 
            // btn_pnl_AP
            // 
            btn_pnl_AP.BackColor = Color.MediumAquamarine;
            btn_pnl_AP.Controls.Add(btn_lbl_AP);
            btn_pnl_AP.Controls.Add(btn_pn_AP);
            btn_pnl_AP.Cursor = Cursors.Hand;
            btn_pnl_AP.Location = new Point(352, 340);
            btn_pnl_AP.Name = "btn_pnl_AP";
            btn_pnl_AP.Size = new Size(270, 270);
            btn_pnl_AP.TabIndex = 3;
            btn_pnl_AP.Click += SelectAP;
            btn_pnl_AP.MouseEnter += HoverAP;
            btn_pnl_AP.MouseLeave += LeaveAP;
            // 
            // btn_lbl_AP
            // 
            btn_lbl_AP.AutoSize = true;
            btn_lbl_AP.Cursor = Cursors.Hand;
            btn_lbl_AP.Font = new Font("HP Simplified", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_lbl_AP.Location = new Point(69, 224);
            btn_lbl_AP.Name = "btn_lbl_AP";
            btn_lbl_AP.Size = new Size(133, 28);
            btn_lbl_AP.TabIndex = 4;
            btn_lbl_AP.Text = "Action Plans";
            btn_lbl_AP.Click += SelectAP;
            btn_lbl_AP.MouseEnter += HoverAP;
            btn_lbl_AP.MouseLeave += LeaveAP;
            // 
            // btn_pn_AP
            // 
            btn_pn_AP.Cursor = Cursors.Hand;
            btn_pn_AP.Image = (Image)resources.GetObject("btn_pn_AP.Image");
            btn_pn_AP.Location = new Point(30, 21);
            btn_pn_AP.Name = "btn_pn_AP";
            btn_pn_AP.Size = new Size(201, 190);
            btn_pn_AP.SizeMode = PictureBoxSizeMode.Zoom;
            btn_pn_AP.TabIndex = 1;
            btn_pn_AP.TabStop = false;
            btn_pn_AP.Click += SelectAP;
            btn_pn_AP.MouseEnter += HoverAP;
            btn_pn_AP.MouseLeave += LeaveAP;
            // 
            // btn_pnl_AR
            // 
            btn_pnl_AR.BackColor = Color.MediumAquamarine;
            btn_pnl_AR.Controls.Add(btn_lbl_AR);
            btn_pnl_AR.Controls.Add(btn_pb_AR);
            btn_pnl_AR.Cursor = Cursors.Hand;
            btn_pnl_AR.Location = new Point(690, 340);
            btn_pnl_AR.Name = "btn_pnl_AR";
            btn_pnl_AR.Size = new Size(270, 270);
            btn_pnl_AR.TabIndex = 3;
            btn_pnl_AR.Click += SelectAR;
            btn_pnl_AR.MouseEnter += HoverAR;
            btn_pnl_AR.MouseLeave += LeaveAR;
            // 
            // btn_lbl_AR
            // 
            btn_lbl_AR.AutoSize = true;
            btn_lbl_AR.Font = new Font("HP Simplified", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_lbl_AR.Location = new Point(71, 224);
            btn_lbl_AR.Name = "btn_lbl_AR";
            btn_lbl_AR.Size = new Size(148, 28);
            btn_lbl_AR.TabIndex = 4;
            btn_lbl_AR.Text = "Audit Reports";
            btn_lbl_AR.Click += SelectAR;
            btn_lbl_AR.MouseEnter += HoverAR;
            btn_lbl_AR.MouseLeave += LeaveAR;
            // 
            // btn_pb_AR
            // 
            btn_pb_AR.Image = (Image)resources.GetObject("btn_pb_AR.Image");
            btn_pb_AR.Location = new Point(36, 21);
            btn_pb_AR.Name = "btn_pb_AR";
            btn_pb_AR.Size = new Size(209, 190);
            btn_pb_AR.SizeMode = PictureBoxSizeMode.Zoom;
            btn_pb_AR.TabIndex = 1;
            btn_pb_AR.TabStop = false;
            btn_pb_AR.Click += SelectAR;
            btn_pb_AR.MouseEnter += HoverAR;
            btn_pb_AR.MouseLeave += LeaveAR;
            // 
            // flp_Ranks
            // 
            flp_Ranks.Location = new Point(555, 120);
            flp_Ranks.Name = "flp_Ranks";
            flp_Ranks.Size = new Size(380, 180);
            flp_Ranks.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HP Simplified", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(555, 94);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 5;
            label2.Text = "Rankings";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("HP Simplified", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(26, 20);
            label3.Name = "label3";
            label3.Size = new Size(468, 35);
            label3.TabIndex = 6;
            label3.Text = "CCYDC Pocket Auditor Admin Panel";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_DirectAddUser
            // 
            btn_DirectAddUser.Cursor = Cursors.Hand;
            btn_DirectAddUser.FlatAppearance.BorderSize = 0;
            btn_DirectAddUser.FlatStyle = FlatStyle.Flat;
            btn_DirectAddUser.Font = new Font("HP Simplified Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DirectAddUser.ForeColor = Color.White;
            btn_DirectAddUser.Image = Properties.Resources.AddUser_x32;
            btn_DirectAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            btn_DirectAddUser.Location = new Point(90, 161);
            btn_DirectAddUser.Name = "btn_DirectAddUser";
            btn_DirectAddUser.Size = new Size(138, 40);
            btn_DirectAddUser.TabIndex = 7;
            btn_DirectAddUser.Text = "  Add a user";
            btn_DirectAddUser.TextAlign = ContentAlignment.MiddleLeft;
            btn_DirectAddUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_DirectAddUser.UseVisualStyleBackColor = true;
            btn_DirectAddUser.Click += AddUser;
            // 
            // btn_ViewChapters
            // 
            btn_ViewChapters.Cursor = Cursors.Hand;
            btn_ViewChapters.FlatAppearance.BorderSize = 0;
            btn_ViewChapters.FlatStyle = FlatStyle.Flat;
            btn_ViewChapters.Font = new Font("HP Simplified Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ViewChapters.ForeColor = Color.White;
            btn_ViewChapters.Image = Properties.Resources.ChapterList_x32;
            btn_ViewChapters.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ViewChapters.Location = new Point(90, 207);
            btn_ViewChapters.Name = "btn_ViewChapters";
            btn_ViewChapters.Size = new Size(304, 40);
            btn_ViewChapters.TabIndex = 8;
            btn_ViewChapters.Text = "  View list of Chapters/Barangays";
            btn_ViewChapters.TextAlign = ContentAlignment.MiddleLeft;
            btn_ViewChapters.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ViewChapters.UseVisualStyleBackColor = true;
            btn_ViewChapters.Click += ShowChapters;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(984, 631);
            Controls.Add(btn_ViewChapters);
            Controls.Add(btn_DirectAddUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(flp_Ranks);
            Controls.Add(btn_pnl_AR);
            Controls.Add(btn_pnl_AP);
            Controls.Add(btn_pnl_AF);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDashboard";
            Text = "FormDashboard";
            btn_pnl_AF.ResumeLayout(false);
            btn_pnl_AF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_pb_AF).EndInit();
            btn_pnl_AP.ResumeLayout(false);
            btn_pnl_AP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_pn_AP).EndInit();
            btn_pnl_AR.ResumeLayout(false);
            btn_pnl_AR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_pb_AR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel btn_pnl_AF;
        private Panel btn_pnl_AP;
        private Panel btn_pnl_AR;
        private PictureBox btn_pn_AP;
        private PictureBox btn_pb_AF;
        private PictureBox btn_pb_AR;
        private Label btn_lbl_AF;
        private Label btn_lbl_AP;
        private Label btn_lbl_AR;
        private FlowLayoutPanel flp_Ranks;
        private Label label2;
        private Label label3;
        private Button btn_DirectAddUser;
        private Button btn_ViewChapters;
    }
}
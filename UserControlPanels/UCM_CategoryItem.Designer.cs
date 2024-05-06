namespace Pocket_Auditor_Admin_Panel.UserControlPanels
{
    partial class UCM_CategoryItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCM_CategoryItem));
            ItemExpand = new System.Windows.Forms.Timer(components);
            xpnd_subcatPanel = new FlowLayoutPanel();
            lbl_categoryName = new Label();
            btn_pnl = new Panel();
            label1 = new Label();
            btn_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // ItemExpand
            // 
            ItemExpand.Enabled = true;
            ItemExpand.Interval = 10;
            ItemExpand.Tick += ItemExpand_Tick;
            // 
            // xpnd_subcatPanel
            // 
            xpnd_subcatPanel.Location = new Point(0, 41);
            xpnd_subcatPanel.Margin = new Padding(0);
            xpnd_subcatPanel.Name = "xpnd_subcatPanel";
            xpnd_subcatPanel.Size = new Size(285, 32);
            xpnd_subcatPanel.TabIndex = 1;
            xpnd_subcatPanel.Click += UCM_CategoryItem_Click;
            // 
            // lbl_categoryName
            // 
            lbl_categoryName.AutoSize = true;
            lbl_categoryName.Location = new Point(6, 8);
            lbl_categoryName.Name = "lbl_categoryName";
            lbl_categoryName.Size = new Size(60, 15);
            lbl_categoryName.TabIndex = 2;
            lbl_categoryName.Text = "Insert Text";
            lbl_categoryName.Click += UCM_CategoryItem_Click;
            // 
            // btn_pnl
            // 
            btn_pnl.BackColor = Color.FromArgb(119, 186, 27);
            btn_pnl.Controls.Add(label1);
            btn_pnl.Dock = DockStyle.Bottom;
            btn_pnl.Location = new Point(0, 80);
            btn_pnl.Name = "btn_pnl";
            btn_pnl.Size = new Size(287, 32);
            btn_pnl.TabIndex = 3;
            btn_pnl.Click += AddSubCategory;
            btn_pnl.MouseEnter += btn_pnl_MouseEnter;
            btn_pnl.MouseLeave += btn_pnl_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(68, 6);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(160, 20);
            label1.TabIndex = 0;
            label1.Text = "     Add Sub-Category";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseWaitCursor = true;
            label1.Click += AddSubCategory;
            label1.MouseEnter += btn_pnl_MouseEnter;
            label1.MouseLeave += btn_pnl_MouseLeave;
            // 
            // UCM_CategoryItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(btn_pnl);
            Controls.Add(lbl_categoryName);
            Controls.Add(xpnd_subcatPanel);
            Cursor = Cursors.Hand;
            Margin = new Padding(0);
            Name = "UCM_CategoryItem";
            Size = new Size(287, 112);
            Click += UCM_CategoryItem_Click;
            btn_pnl.ResumeLayout(false);
            btn_pnl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer ItemExpand;
        private FlowLayoutPanel xpnd_subcatPanel;
        private Label lbl_categoryName;
        private Panel btn_pnl;
        private Label label1;
    }
}

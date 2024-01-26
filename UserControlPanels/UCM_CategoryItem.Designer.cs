﻿namespace Pocket_Auditor_Admin_Panel.UserControlPanels
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
            ItemExpand = new System.Windows.Forms.Timer(components);
            xpnd_subcatPanel = new FlowLayoutPanel();
            lbl_categoryName = new Label();
            panel1 = new Panel();
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
            xpnd_subcatPanel.BackColor = Color.SeaGreen;
            xpnd_subcatPanel.Location = new Point(0, 32);
            xpnd_subcatPanel.Name = "xpnd_subcatPanel";
            xpnd_subcatPanel.Size = new Size(285, 33);
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
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Location = new Point(121, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(54, 25);
            panel1.TabIndex = 3;
            // 
            // UCM_CategoryItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            Controls.Add(panel1);
            Controls.Add(lbl_categoryName);
            Controls.Add(xpnd_subcatPanel);
            Cursor = Cursors.Hand;
            Margin = new Padding(0);
            Name = "UCM_CategoryItem";
            Size = new Size(287, 96);
            Click += UCM_CategoryItem_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer ItemExpand;
        private FlowLayoutPanel xpnd_subcatPanel;
        private Label lbl_categoryName;
        private Panel panel1;
    }
}

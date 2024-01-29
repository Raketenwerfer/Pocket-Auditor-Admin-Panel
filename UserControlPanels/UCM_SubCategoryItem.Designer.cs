namespace Pocket_Auditor_Admin_Panel.UserControlPanels
{
    partial class UCM_SubCategoryItem
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
            lbl_SubCat = new Label();
            btn_pnl_EditSubCat = new Panel();
            SuspendLayout();
            // 
            // lbl_SubCat
            // 
            lbl_SubCat.AutoSize = true;
            lbl_SubCat.Location = new Point(3, 9);
            lbl_SubCat.Name = "lbl_SubCat";
            lbl_SubCat.Size = new Size(88, 15);
            lbl_SubCat.TabIndex = 0;
            lbl_SubCat.Text = "Insert Text Here";
            // 
            // btn_pnl_EditSubCat
            // 
            btn_pnl_EditSubCat.BackColor = SystemColors.AppWorkspace;
            btn_pnl_EditSubCat.Location = new Point(255, 4);
            btn_pnl_EditSubCat.Name = "btn_pnl_EditSubCat";
            btn_pnl_EditSubCat.Size = new Size(25, 25);
            btn_pnl_EditSubCat.TabIndex = 1;
            // 
            // UCM_SubCategoryItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_pnl_EditSubCat);
            Controls.Add(lbl_SubCat);
            Cursor = Cursors.Hand;
            Name = "UCM_SubCategoryItem";
            Size = new Size(285, 33);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_SubCat;
        private Panel btn_pnl_EditSubCat;
    }
}

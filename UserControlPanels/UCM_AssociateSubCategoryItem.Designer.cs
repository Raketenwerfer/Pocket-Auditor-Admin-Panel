namespace Pocket_Auditor_Admin_Panel.UserControlPanels
{
    partial class UCM_AssociateSubCategoryItem
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
            btn_pnl_EditSubCat = new Panel();
            cbox_SubCategory = new CheckBox();
            SuspendLayout();
            // 
            // btn_pnl_EditSubCat
            // 
            btn_pnl_EditSubCat.BackColor = SystemColors.AppWorkspace;
            btn_pnl_EditSubCat.Location = new Point(461, 0);
            btn_pnl_EditSubCat.Name = "btn_pnl_EditSubCat";
            btn_pnl_EditSubCat.Size = new Size(30, 30);
            btn_pnl_EditSubCat.TabIndex = 1;
            // 
            // cbox_SubCategory
            // 
            cbox_SubCategory.AutoSize = true;
            cbox_SubCategory.Location = new Point(7, 5);
            cbox_SubCategory.Name = "cbox_SubCategory";
            cbox_SubCategory.Size = new Size(94, 19);
            cbox_SubCategory.TabIndex = 2;
            cbox_SubCategory.Text = "SubCategory";
            cbox_SubCategory.UseVisualStyleBackColor = true;
            cbox_SubCategory.MouseDown += cbox_SubCategory_MouseDown;
            // 
            // UCM_AssociateSubCategoryItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(cbox_SubCategory);
            Controls.Add(btn_pnl_EditSubCat);
            Cursor = Cursors.Hand;
            Name = "UCM_AssociateSubCategoryItem";
            Size = new Size(491, 28);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel btn_pnl_EditSubCat;
        private CheckBox cbox_SubCategory;
    }
}

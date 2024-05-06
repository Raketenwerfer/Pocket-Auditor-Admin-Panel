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
            lbl_subCategoryName = new Label();
            SuspendLayout();
            // 
            // lbl_subCategoryName
            // 
            lbl_subCategoryName.AutoSize = true;
            lbl_subCategoryName.Location = new Point(21, 9);
            lbl_subCategoryName.Name = "lbl_subCategoryName";
            lbl_subCategoryName.Size = new Size(60, 15);
            lbl_subCategoryName.TabIndex = 3;
            lbl_subCategoryName.Text = "Insert Text";
            lbl_subCategoryName.Click += IndicatorDisplayFilter;
            // 
            // UCM_SubCategoryItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(lbl_subCategoryName);
            Margin = new Padding(0);
            Name = "UCM_SubCategoryItem";
            Size = new Size(285, 32);
            Click += IndicatorDisplayFilter;
            MouseEnter += UCM_SubCategoryItem_MouseEnter;
            MouseLeave += UCM_SubCategoryItem_MouseLeave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_subCategoryName;
    }
}

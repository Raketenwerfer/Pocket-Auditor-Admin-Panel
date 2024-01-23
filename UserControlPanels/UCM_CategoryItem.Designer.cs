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
            lbl_categoryName = new Label();
            SuspendLayout();
            // 
            // lbl_categoryName
            // 
            lbl_categoryName.AutoSize = true;
            lbl_categoryName.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_categoryName.Location = new Point(3, 9);
            lbl_categoryName.Name = "lbl_categoryName";
            lbl_categoryName.Size = new Size(253, 13);
            lbl_categoryName.TabIndex = 0;
            lbl_categoryName.Text = "Test Category - ho ho ho ho ho ho ho ho ho ho";
            // 
            // UCM_CategoryItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lbl_categoryName);
            Name = "UCM_CategoryItem";
            Size = new Size(270, 31);
            Click += UCM_CategoryItem_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_categoryName;
    }
}

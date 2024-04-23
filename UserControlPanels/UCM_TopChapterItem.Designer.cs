namespace Pocket_Auditor_Admin_Panel.UserControlPanels
{
    partial class UCM_TopChapterItem
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
            lbl_Barangay = new Label();
            SuspendLayout();
            // 
            // lbl_Barangay
            // 
            lbl_Barangay.AutoSize = true;
            lbl_Barangay.Font = new Font("HP Simplified", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Barangay.Location = new Point(13, 11);
            lbl_Barangay.Name = "lbl_Barangay";
            lbl_Barangay.Size = new Size(92, 24);
            lbl_Barangay.TabIndex = 0;
            lbl_Barangay.Text = "Barangay";
            // 
            // UCM_TopChapterItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            Controls.Add(lbl_Barangay);
            Name = "UCM_TopChapterItem";
            Size = new Size(370, 50);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Barangay;
    }
}

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
            lbl_Auditor = new Label();
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
            // lbl_Auditor
            // 
            lbl_Auditor.AutoSize = true;
            lbl_Auditor.Font = new Font("HP Simplified", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Auditor.Location = new Point(833, 11);
            lbl_Auditor.Name = "lbl_Auditor";
            lbl_Auditor.Size = new Size(74, 24);
            lbl_Auditor.TabIndex = 1;
            lbl_Auditor.Text = "Auditor";
            lbl_Auditor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UCM_TopChapterItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            Controls.Add(lbl_Auditor);
            Controls.Add(lbl_Barangay);
            Name = "UCM_TopChapterItem";
            Size = new Size(925, 50);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Barangay;
        private Label lbl_Auditor;
    }
}

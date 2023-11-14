namespace Pocket_Auditor_Admin_Panel
{
    partial class CardViewControl
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
            lblCatTitle = new Label();
            lblIndicator = new Label();
            rbnYes = new RadioButton();
            rbnNo = new RadioButton();
            SuspendLayout();
            // 
            // lblCatTitle
            // 
            lblCatTitle.AutoEllipsis = true;
            lblCatTitle.Location = new Point(27, 26);
            lblCatTitle.Name = "lblCatTitle";
            lblCatTitle.Size = new Size(300, 19);
            lblCatTitle.TabIndex = 0;
            lblCatTitle.Text = "Category Name";
            // 
            // lblIndicator
            // 
            lblIndicator.AutoEllipsis = true;
            lblIndicator.Location = new Point(50, 59);
            lblIndicator.Name = "lblIndicator";
            lblIndicator.Size = new Size(228, 47);
            lblIndicator.TabIndex = 1;
            lblIndicator.Text = "Indicator";
            // 
            // rbnYes
            // 
            rbnYes.AutoSize = true;
            rbnYes.Location = new Point(295, 59);
            rbnYes.Name = "rbnYes";
            rbnYes.Size = new Size(44, 19);
            rbnYes.TabIndex = 2;
            rbnYes.TabStop = true;
            rbnYes.Text = "YES";
            rbnYes.UseVisualStyleBackColor = true;
            // 
            // rbnNo
            // 
            rbnNo.AutoSize = true;
            rbnNo.Location = new Point(295, 87);
            rbnNo.Name = "rbnNo";
            rbnNo.Size = new Size(43, 19);
            rbnNo.TabIndex = 3;
            rbnNo.TabStop = true;
            rbnNo.Text = "NO";
            rbnNo.UseVisualStyleBackColor = true;
            // 
            // CardViewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rbnNo);
            Controls.Add(rbnYes);
            Controls.Add(lblIndicator);
            Controls.Add(lblCatTitle);
            Name = "CardViewControl";
            Size = new Size(366, 142);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCatTitle;
        private Label lblIndicator;
        private RadioButton rbnYes;
        private RadioButton rbnNo;
    }
}

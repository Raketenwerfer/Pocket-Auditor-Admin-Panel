namespace Pocket_Auditor_Admin_Panel.UserControlPanels
{
    partial class UCM_IndicatorItem
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
            pictureBox1 = new PictureBox();
            txt_itemName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.Location = new Point(737, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 42);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txt_itemName
            // 
            txt_itemName.AutoSize = true;
            txt_itemName.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_itemName.Location = new Point(9, 9);
            txt_itemName.Name = "txt_itemName";
            txt_itemName.Size = new Size(79, 19);
            txt_itemName.TabIndex = 0;
            txt_itemName.Text = "ItemName";
            // 
            // UCM_IndicatorItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(pictureBox1);
            Controls.Add(txt_itemName);
            Name = "UCM_IndicatorItem";
            Size = new Size(780, 40);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label txt_itemName;
    }
}

namespace Pocket_Auditor_Admin_Panel.UserControlPanels
{
    partial class UCM_SubIndicatorItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCM_SubIndicatorItem));
            cbox_SubIndicator = new CheckBox();
            btn_Delete = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btn_Delete).BeginInit();
            SuspendLayout();
            // 
            // cbox_SubIndicator
            // 
            cbox_SubIndicator.AutoSize = true;
            cbox_SubIndicator.Location = new Point(7, 5);
            cbox_SubIndicator.Name = "cbox_SubIndicator";
            cbox_SubIndicator.Size = new Size(93, 19);
            cbox_SubIndicator.TabIndex = 1;
            cbox_SubIndicator.Text = "SubIndicator";
            cbox_SubIndicator.UseVisualStyleBackColor = true;
            cbox_SubIndicator.MouseDown += cbox_SubIndicator_MouseDown;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.Transparent;
            btn_Delete.Image = (Image)resources.GetObject("btn_Delete.Image");
            btn_Delete.Location = new Point(464, 0);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(27, 28);
            btn_Delete.TabIndex = 2;
            btn_Delete.TabStop = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // UCM_SubIndicatorItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btn_Delete);
            Controls.Add(cbox_SubIndicator);
            Margin = new Padding(6, 3, 6, 3);
            Name = "UCM_SubIndicatorItem";
            Size = new Size(491, 28);
            ((System.ComponentModel.ISupportInitialize)btn_Delete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_SubIndicator;
        private CheckBox cbox_SubIndicator;
        private PictureBox btn_Delete;
    }
}

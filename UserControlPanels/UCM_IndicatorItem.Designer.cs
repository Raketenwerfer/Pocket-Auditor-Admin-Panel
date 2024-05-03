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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCM_IndicatorItem));
            pbox_btn_EditItem = new PictureBox();
            txt_itemName = new Label();
            ((System.ComponentModel.ISupportInitialize)pbox_btn_EditItem).BeginInit();
            SuspendLayout();
            // 
            // pbox_btn_EditItem
            // 
            pbox_btn_EditItem.BackColor = Color.Transparent;
            pbox_btn_EditItem.Image = (Image)resources.GetObject("pbox_btn_EditItem.Image");
            pbox_btn_EditItem.InitialImage = null;
            pbox_btn_EditItem.Location = new Point(646, 0);
            pbox_btn_EditItem.Name = "pbox_btn_EditItem";
            pbox_btn_EditItem.Size = new Size(44, 42);
            pbox_btn_EditItem.TabIndex = 1;
            pbox_btn_EditItem.TabStop = false;
            pbox_btn_EditItem.Click += pbox_btn_EditItem_Click;
            // 
            // txt_itemName
            // 
            txt_itemName.AutoSize = true;
            txt_itemName.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_itemName.Location = new Point(10, 10);
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
            Controls.Add(pbox_btn_EditItem);
            Controls.Add(txt_itemName);
            Margin = new Padding(3, 3, 6, 3);
            Name = "UCM_IndicatorItem";
            Padding = new Padding(1, 1, 6, 1);
            Size = new Size(690, 40);
            ((System.ComponentModel.ISupportInitialize)pbox_btn_EditItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbox_btn_EditItem;
        private Label txt_itemName;
    }
}

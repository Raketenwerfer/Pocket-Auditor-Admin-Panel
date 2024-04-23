namespace Pocket_Auditor_Admin_Panel.Forms
{
    partial class CDisplay_ISI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDisplay_ISI));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnl_btn_AddIndicator = new Panel();
            lbl_btn_AddIndicator = new Label();
            lbl_dis_CategoryName = new Label();
            pbox_btn_ConfigureCategory = new PictureBox();
            pnl_btn_AddIndicator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbox_btn_ConfigureCategory).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.DarkSeaGreen;
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.ForeColor = Color.Green;
            flowLayoutPanel1.Location = new Point(0, 45);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(2);
            flowLayoutPanel1.Size = new Size(700, 585);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // pnl_btn_AddIndicator
            // 
            pnl_btn_AddIndicator.BackColor = Color.SpringGreen;
            pnl_btn_AddIndicator.Controls.Add(lbl_btn_AddIndicator);
            pnl_btn_AddIndicator.Location = new Point(571, -1);
            pnl_btn_AddIndicator.Name = "pnl_btn_AddIndicator";
            pnl_btn_AddIndicator.Size = new Size(130, 47);
            pnl_btn_AddIndicator.TabIndex = 1;
            pnl_btn_AddIndicator.Click += AddIndicator;
            // 
            // lbl_btn_AddIndicator
            // 
            lbl_btn_AddIndicator.AutoSize = true;
            lbl_btn_AddIndicator.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_btn_AddIndicator.ForeColor = Color.DarkSlateGray;
            lbl_btn_AddIndicator.Location = new Point(11, 15);
            lbl_btn_AddIndicator.Name = "lbl_btn_AddIndicator";
            lbl_btn_AddIndicator.Size = new Size(112, 16);
            lbl_btn_AddIndicator.TabIndex = 3;
            lbl_btn_AddIndicator.Text = "ADD INDICATOR";
            lbl_btn_AddIndicator.Click += AddIndicator;
            // 
            // lbl_dis_CategoryName
            // 
            lbl_dis_CategoryName.AutoSize = true;
            lbl_dis_CategoryName.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_dis_CategoryName.ForeColor = SystemColors.ControlText;
            lbl_dis_CategoryName.Location = new Point(11, 13);
            lbl_dis_CategoryName.Name = "lbl_dis_CategoryName";
            lbl_dis_CategoryName.Size = new Size(77, 19);
            lbl_dis_CategoryName.TabIndex = 2;
            lbl_dis_CategoryName.Text = "Indicators";
            // 
            // pbox_btn_ConfigureCategory
            // 
            pbox_btn_ConfigureCategory.BackColor = Color.Transparent;
            pbox_btn_ConfigureCategory.ErrorImage = null;
            pbox_btn_ConfigureCategory.Image = (Image)resources.GetObject("pbox_btn_ConfigureCategory.Image");
            pbox_btn_ConfigureCategory.Location = new Point(532, 7);
            pbox_btn_ConfigureCategory.Name = "pbox_btn_ConfigureCategory";
            pbox_btn_ConfigureCategory.Size = new Size(30, 30);
            pbox_btn_ConfigureCategory.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox_btn_ConfigureCategory.TabIndex = 3;
            pbox_btn_ConfigureCategory.TabStop = false;
            pbox_btn_ConfigureCategory.Click += pbox_btn_ConfigureCategory_Click;
            // 
            // CDisplay_ISI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(700, 630);
            Controls.Add(pbox_btn_ConfigureCategory);
            Controls.Add(pnl_btn_AddIndicator);
            Controls.Add(lbl_dis_CategoryName);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CDisplay_ISI";
            Text = "CDisplay_ISI";
            pnl_btn_AddIndicator.ResumeLayout(false);
            pnl_btn_AddIndicator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbox_btn_ConfigureCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnl_btn_AddIndicator;
        private Label lbl_btn_AddIndicator;
        private Label lbl_dis_CategoryName;
        private PictureBox pbox_btn_ConfigureCategory;
    }
}
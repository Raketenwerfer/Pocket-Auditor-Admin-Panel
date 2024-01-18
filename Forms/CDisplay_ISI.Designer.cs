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
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnl_btn_AddIndicator = new Panel();
            lbl_btn_AddIndicator = new Label();
            lbl_dis_Indicator = new Label();
            pnl_btn_AddIndicator.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.DarkSeaGreen;
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 45);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(2);
            flowLayoutPanel1.Size = new Size(915, 585);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // pnl_btn_AddIndicator
            // 
            pnl_btn_AddIndicator.BackColor = Color.SpringGreen;
            pnl_btn_AddIndicator.Controls.Add(lbl_btn_AddIndicator);
            pnl_btn_AddIndicator.Location = new Point(785, -1);
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
            lbl_btn_AddIndicator.Location = new Point(9, 15);
            lbl_btn_AddIndicator.Name = "lbl_btn_AddIndicator";
            lbl_btn_AddIndicator.Size = new Size(112, 16);
            lbl_btn_AddIndicator.TabIndex = 3;
            lbl_btn_AddIndicator.Text = "ADD INDICATOR";
            lbl_btn_AddIndicator.Click += AddIndicator;
            // 
            // lbl_dis_Indicator
            // 
            lbl_dis_Indicator.AutoSize = true;
            lbl_dis_Indicator.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_dis_Indicator.ForeColor = SystemColors.ControlText;
            lbl_dis_Indicator.Location = new Point(12, 11);
            lbl_dis_Indicator.Name = "lbl_dis_Indicator";
            lbl_dis_Indicator.Size = new Size(93, 22);
            lbl_dis_Indicator.TabIndex = 2;
            lbl_dis_Indicator.Text = "Indicators";
            // 
            // CDisplay_ISI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(915, 630);
            Controls.Add(lbl_dis_Indicator);
            Controls.Add(pnl_btn_AddIndicator);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CDisplay_ISI";
            Text = "CDisplay_ISI";
            pnl_btn_AddIndicator.ResumeLayout(false);
            pnl_btn_AddIndicator.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnl_btn_AddIndicator;
        private Label lbl_btn_AddIndicator;
        private Label lbl_dis_Indicator;
    }
}
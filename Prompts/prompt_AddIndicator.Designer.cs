namespace Pocket_Auditor_Admin_Panel.Prompts
{
    partial class prompt_AddIndicator
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
            tbox_Indicator = new TextBox();
            btn_AcceptIndicator = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // tbox_Indicator
            // 
            tbox_Indicator.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_Indicator.Location = new Point(12, 24);
            tbox_Indicator.Name = "tbox_Indicator";
            tbox_Indicator.Size = new Size(524, 27);
            tbox_Indicator.TabIndex = 0;
            // 
            // btn_AcceptIndicator
            // 
            btn_AcceptIndicator.BackColor = Color.LightGreen;
            btn_AcceptIndicator.Location = new Point(217, 55);
            btn_AcceptIndicator.Name = "btn_AcceptIndicator";
            btn_AcceptIndicator.Size = new Size(112, 29);
            btn_AcceptIndicator.TabIndex = 1;
            btn_AcceptIndicator.Text = "Accept";
            btn_AcceptIndicator.UseVisualStyleBackColor = false;
            btn_AcceptIndicator.Click += btn_AcceptIndicator_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 2;
            label1.Text = "Indicator Question";
            // 
            // prompt_AddIndicator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 87);
            Controls.Add(label1);
            Controls.Add(btn_AcceptIndicator);
            Controls.Add(tbox_Indicator);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "prompt_AddIndicator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Indicator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbox_Indicator;
        private Button btn_AcceptIndicator;
        private Label label1;
    }
}
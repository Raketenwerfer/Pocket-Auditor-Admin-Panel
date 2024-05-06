namespace Pocket_Auditor_Admin_Panel.Prompts
{
    partial class prompt_AddSubIndicator
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
            label1 = new Label();
            btn_AcceptSubIndicator = new Button();
            tbox_SubIndicator = new TextBox();
            cbox_SubIndType = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 6);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 5;
            label1.Text = "Sub-Indicator Question";
            // 
            // btn_AcceptSubIndicator
            // 
            btn_AcceptSubIndicator.BackColor = Color.FromArgb(119, 186, 27);
            btn_AcceptSubIndicator.FlatAppearance.BorderSize = 0;
            btn_AcceptSubIndicator.FlatStyle = FlatStyle.Flat;
            btn_AcceptSubIndicator.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AcceptSubIndicator.ForeColor = Color.White;
            btn_AcceptSubIndicator.Location = new Point(293, 54);
            btn_AcceptSubIndicator.Name = "btn_AcceptSubIndicator";
            btn_AcceptSubIndicator.Size = new Size(112, 29);
            btn_AcceptSubIndicator.TabIndex = 4;
            btn_AcceptSubIndicator.Text = "Accept";
            btn_AcceptSubIndicator.UseVisualStyleBackColor = false;
            btn_AcceptSubIndicator.Click += btn_AcceptSubIndicator_Click;
            // 
            // tbox_SubIndicator
            // 
            tbox_SubIndicator.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_SubIndicator.Location = new Point(13, 21);
            tbox_SubIndicator.Name = "tbox_SubIndicator";
            tbox_SubIndicator.Size = new Size(524, 27);
            tbox_SubIndicator.TabIndex = 3;
            // 
            // cbox_SubIndType
            // 
            cbox_SubIndType.FormattingEnabled = true;
            cbox_SubIndType.Items.AddRange(new object[] { "DETAILS", "OPTIONS" });
            cbox_SubIndType.Location = new Point(543, 23);
            cbox_SubIndType.Name = "cbox_SubIndType";
            cbox_SubIndType.Size = new Size(121, 23);
            cbox_SubIndType.TabIndex = 6;
            // 
            // prompt_AddSubIndicator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 87);
            Controls.Add(cbox_SubIndType);
            Controls.Add(label1);
            Controls.Add(btn_AcceptSubIndicator);
            Controls.Add(tbox_SubIndicator);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "prompt_AddSubIndicator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Sub-Indicator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_AcceptSubIndicator;
        private TextBox tbox_SubIndicator;
        private ComboBox cbox_SubIndType;
    }
}
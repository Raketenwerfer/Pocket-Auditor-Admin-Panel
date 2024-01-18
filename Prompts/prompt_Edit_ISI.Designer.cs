namespace Pocket_Auditor_Admin_Panel.Prompts
{
    partial class prompt_Edit_ISI
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
            lbl_itemname = new Label();
            tbox_EditIndicator = new TextBox();
            btn_ApplyEdit = new Button();
            btn_Delete = new Button();
            flp_subindicators = new FlowLayoutPanel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_itemname
            // 
            lbl_itemname.AutoSize = true;
            lbl_itemname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_itemname.Location = new Point(12, 11);
            lbl_itemname.Name = "lbl_itemname";
            lbl_itemname.Size = new Size(128, 15);
            lbl_itemname.TabIndex = 0;
            lbl_itemname.Text = "Edit Indicator Question";
            // 
            // tbox_EditIndicator
            // 
            tbox_EditIndicator.BackColor = SystemColors.ControlLightLight;
            tbox_EditIndicator.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_EditIndicator.Location = new Point(12, 28);
            tbox_EditIndicator.Multiline = true;
            tbox_EditIndicator.Name = "tbox_EditIndicator";
            tbox_EditIndicator.Size = new Size(523, 26);
            tbox_EditIndicator.TabIndex = 22;
            // 
            // btn_ApplyEdit
            // 
            btn_ApplyEdit.Location = new Point(162, 331);
            btn_ApplyEdit.Name = "btn_ApplyEdit";
            btn_ApplyEdit.Size = new Size(112, 29);
            btn_ApplyEdit.TabIndex = 23;
            btn_ApplyEdit.Text = "Apply Changes";
            btn_ApplyEdit.UseVisualStyleBackColor = true;
            btn_ApplyEdit.Click += btn_ApplyEdit_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.Salmon;
            btn_Delete.FlatStyle = FlatStyle.Popup;
            btn_Delete.Location = new Point(280, 331);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(112, 29);
            btn_Delete.TabIndex = 24;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // flp_subindicators
            // 
            flp_subindicators.AutoScroll = true;
            flp_subindicators.BackColor = SystemColors.InactiveBorder;
            flp_subindicators.FlowDirection = FlowDirection.TopDown;
            flp_subindicators.Location = new Point(12, 87);
            flp_subindicators.Margin = new Padding(8);
            flp_subindicators.Name = "flp_subindicators";
            flp_subindicators.Padding = new Padding(0, 3, 0, 6);
            flp_subindicators.Size = new Size(523, 233);
            flp_subindicators.TabIndex = 25;
            flp_subindicators.WrapContents = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 68);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 26;
            label1.Text = "Sub-Indicators";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkSeaGreen;
            pictureBox1.Location = new Point(515, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // prompt_Edit_ISI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(547, 372);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(flp_subindicators);
            Controls.Add(btn_Delete);
            Controls.Add(btn_ApplyEdit);
            Controls.Add(tbox_EditIndicator);
            Controls.Add(lbl_itemname);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "prompt_Edit_ISI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Item";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_itemname;
        private TextBox tbox_EditIndicator;
        private Button btn_ApplyEdit;
        private Button btn_Delete;
        private FlowLayoutPanel flp_subindicators;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
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
            flp_Display = new FlowLayoutPanel();
            btn_lbl_SI = new Label();
            btn_AddSubIndicator = new PictureBox();
            btn_lbl_SC = new Label();
            btn_pnl_SI = new Panel();
            btn_pnl_SC = new Panel();
            ((System.ComponentModel.ISupportInitialize)btn_AddSubIndicator).BeginInit();
            btn_pnl_SI.SuspendLayout();
            btn_pnl_SC.SuspendLayout();
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
            btn_ApplyEdit.BackColor = Color.LightGreen;
            btn_ApplyEdit.Location = new Point(162, 331);
            btn_ApplyEdit.Name = "btn_ApplyEdit";
            btn_ApplyEdit.Size = new Size(112, 29);
            btn_ApplyEdit.TabIndex = 23;
            btn_ApplyEdit.Text = "Apply Changes";
            btn_ApplyEdit.UseVisualStyleBackColor = false;
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
            // flp_Display
            // 
            flp_Display.AutoScroll = true;
            flp_Display.BackColor = SystemColors.InactiveBorder;
            flp_Display.FlowDirection = FlowDirection.TopDown;
            flp_Display.Location = new Point(12, 87);
            flp_Display.Margin = new Padding(8);
            flp_Display.Name = "flp_Display";
            flp_Display.Padding = new Padding(0, 3, 0, 6);
            flp_Display.Size = new Size(523, 233);
            flp_Display.TabIndex = 25;
            flp_Display.WrapContents = false;
            // 
            // btn_lbl_SI
            // 
            btn_lbl_SI.AutoSize = true;
            btn_lbl_SI.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_lbl_SI.Location = new Point(7, 5);
            btn_lbl_SI.Name = "btn_lbl_SI";
            btn_lbl_SI.Size = new Size(84, 15);
            btn_lbl_SI.TabIndex = 26;
            btn_lbl_SI.Text = "Sub-Indicators";
            btn_lbl_SI.Click += SelectSI;
            // 
            // btn_AddSubIndicator
            // 
            btn_AddSubIndicator.BackColor = Color.DarkSeaGreen;
            btn_AddSubIndicator.Image = Properties.Resources.icons8_add_new_20;
            btn_AddSubIndicator.Location = new Point(515, 66);
            btn_AddSubIndicator.Name = "btn_AddSubIndicator";
            btn_AddSubIndicator.Size = new Size(20, 20);
            btn_AddSubIndicator.TabIndex = 27;
            btn_AddSubIndicator.TabStop = false;
            btn_AddSubIndicator.Click += btn_AddSubIndicator_Click;
            // 
            // btn_lbl_SC
            // 
            btn_lbl_SC.AutoSize = true;
            btn_lbl_SC.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_lbl_SC.Location = new Point(6, 5);
            btn_lbl_SC.Name = "btn_lbl_SC";
            btn_lbl_SC.Size = new Size(88, 15);
            btn_lbl_SC.TabIndex = 28;
            btn_lbl_SC.Text = "Sub-Categories";
            btn_lbl_SC.Click += SelectSC;
            // 
            // btn_pnl_SI
            // 
            btn_pnl_SI.BackColor = Color.Silver;
            btn_pnl_SI.Controls.Add(btn_lbl_SI);
            btn_pnl_SI.Cursor = Cursors.Hand;
            btn_pnl_SI.Location = new Point(22, 62);
            btn_pnl_SI.Name = "btn_pnl_SI";
            btn_pnl_SI.Size = new Size(97, 25);
            btn_pnl_SI.TabIndex = 29;
            btn_pnl_SI.Click += SelectSI;
            // 
            // btn_pnl_SC
            // 
            btn_pnl_SC.BackColor = Color.Silver;
            btn_pnl_SC.Controls.Add(btn_lbl_SC);
            btn_pnl_SC.Cursor = Cursors.Hand;
            btn_pnl_SC.Location = new Point(119, 62);
            btn_pnl_SC.Name = "btn_pnl_SC";
            btn_pnl_SC.Size = new Size(100, 25);
            btn_pnl_SC.TabIndex = 30;
            btn_pnl_SC.Click += SelectSC;
            // 
            // prompt_Edit_ISI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(547, 372);
            Controls.Add(btn_pnl_SC);
            Controls.Add(btn_pnl_SI);
            Controls.Add(btn_AddSubIndicator);
            Controls.Add(flp_Display);
            Controls.Add(btn_Delete);
            Controls.Add(btn_ApplyEdit);
            Controls.Add(tbox_EditIndicator);
            Controls.Add(lbl_itemname);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "prompt_Edit_ISI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Item";
            ((System.ComponentModel.ISupportInitialize)btn_AddSubIndicator).EndInit();
            btn_pnl_SI.ResumeLayout(false);
            btn_pnl_SI.PerformLayout();
            btn_pnl_SC.ResumeLayout(false);
            btn_pnl_SC.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_itemname;
        private TextBox tbox_EditIndicator;
        private Button btn_ApplyEdit;
        private Button btn_Delete;
        private FlowLayoutPanel flp_Display;
        private Label btn_lbl_SI;
        private PictureBox btn_AddSubIndicator;
        private Label btn_lbl_SC;
        private Panel btn_pnl_SI;
        private Panel btn_pnl_SC;
    }
}
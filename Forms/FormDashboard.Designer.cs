namespace Pocket_Auditor_Admin_Panel.Forms
{
    partial class FormDashboard
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
            flp_Ranks = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            btn_ViewChapters = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HP Simplified", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 55);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flp_Ranks
            // 
            flp_Ranks.AutoScrollMargin = new Size(2, 2);
            flp_Ranks.Location = new Point(26, 185);
            flp_Ranks.Name = "flp_Ranks";
            flp_Ranks.Size = new Size(932, 418);
            flp_Ranks.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HP Simplified", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 159);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 5;
            label2.Text = "Rankings";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("HP Simplified", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(26, 20);
            label3.Name = "label3";
            label3.Size = new Size(468, 35);
            label3.TabIndex = 6;
            label3.Text = "CCYDC Pocket Auditor Admin Panel";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_ViewChapters
            // 
            btn_ViewChapters.Cursor = Cursors.Hand;
            btn_ViewChapters.FlatAppearance.BorderSize = 0;
            btn_ViewChapters.FlatStyle = FlatStyle.Flat;
            btn_ViewChapters.Font = new Font("HP Simplified Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ViewChapters.ForeColor = Color.White;
            btn_ViewChapters.Image = Properties.Resources.ChapterList_x32;
            btn_ViewChapters.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ViewChapters.Location = new Point(654, 104);
            btn_ViewChapters.Name = "btn_ViewChapters";
            btn_ViewChapters.Size = new Size(304, 40);
            btn_ViewChapters.TabIndex = 8;
            btn_ViewChapters.Text = "  View list of Chapters/Barangays";
            btn_ViewChapters.TextAlign = ContentAlignment.MiddleLeft;
            btn_ViewChapters.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ViewChapters.UseVisualStyleBackColor = true;
            btn_ViewChapters.Click += ShowChapters;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(984, 631);
            Controls.Add(btn_ViewChapters);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(flp_Ranks);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDashboard";
            Text = "FormDashboard";
            Leave += FormDashboard_Leave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flp_Ranks;
        private Label label2;
        private Label label3;
        private Button btn_ViewChapters;
    }
}
namespace Pocket_Auditor_Admin_Panel.Prompts
{
    partial class prompt_AddCategory
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
            btn_AcceptCategory = new Button();
            tbox_Category = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 6);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 5;
            label1.Text = "Category Name";
            // 
            // btn_AcceptCategory
            // 
            btn_AcceptCategory.BackColor = Color.FromArgb(119, 186, 27);
            btn_AcceptCategory.FlatAppearance.BorderSize = 0;
            btn_AcceptCategory.FlatStyle = FlatStyle.Flat;
            btn_AcceptCategory.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AcceptCategory.ForeColor = Color.White;
            btn_AcceptCategory.Location = new Point(132, 54);
            btn_AcceptCategory.Name = "btn_AcceptCategory";
            btn_AcceptCategory.Size = new Size(112, 29);
            btn_AcceptCategory.TabIndex = 4;
            btn_AcceptCategory.Text = "Accept";
            btn_AcceptCategory.UseVisualStyleBackColor = false;
            btn_AcceptCategory.Click += btn_AcceptCategory_Click;
            // 
            // tbox_Category
            // 
            tbox_Category.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_Category.Location = new Point(13, 21);
            tbox_Category.Name = "tbox_Category";
            tbox_Category.Size = new Size(348, 27);
            tbox_Category.TabIndex = 3;
            // 
            // prompt_AddCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 87);
            Controls.Add(label1);
            Controls.Add(btn_AcceptCategory);
            Controls.Add(tbox_Category);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "prompt_AddCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_AcceptCategory;
        private TextBox tbox_Category;
    }
}
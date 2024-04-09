namespace Pocket_Auditor_Admin_Panel.Prompts
{
    partial class prompt_Edit_SubCategory
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
            btn_Delete = new Button();
            label1 = new Label();
            btn_AcceptCategory = new Button();
            tbox_Category = new TextBox();
            SuspendLayout();
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.Salmon;
            btn_Delete.Location = new Point(190, 52);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(112, 29);
            btn_Delete.TabIndex = 13;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 6);
            label1.Name = "label1";
            label1.Size = new Size(159, 15);
            label1.TabIndex = 12;
            label1.Text = "Change Sub-Category Name";
            // 
            // btn_AcceptCategory
            // 
            btn_AcceptCategory.BackColor = Color.LightGreen;
            btn_AcceptCategory.Location = new Point(72, 52);
            btn_AcceptCategory.Name = "btn_AcceptCategory";
            btn_AcceptCategory.Size = new Size(112, 29);
            btn_AcceptCategory.TabIndex = 11;
            btn_AcceptCategory.Text = "Accept";
            btn_AcceptCategory.UseVisualStyleBackColor = false;
            // 
            // tbox_Category
            // 
            tbox_Category.BackColor = Color.PaleGreen;
            tbox_Category.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_Category.Location = new Point(12, 21);
            tbox_Category.Name = "tbox_Category";
            tbox_Category.Size = new Size(348, 27);
            tbox_Category.TabIndex = 10;
            // 
            // prompt_Edit_SubCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 87);
            Controls.Add(btn_Delete);
            Controls.Add(label1);
            Controls.Add(btn_AcceptCategory);
            Controls.Add(tbox_Category);
            ForeColor = SystemColors.ActiveCaptionText;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "prompt_Edit_SubCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Sub-Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Delete;
        private Label label1;
        private Button btn_AcceptCategory;
        private TextBox tbox_Category;
    }
}
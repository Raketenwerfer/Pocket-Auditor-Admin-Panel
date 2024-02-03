namespace Pocket_Auditor_Admin_Panel.Prompts
{
    partial class prompt_AddSubCategory
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
            tbox_SubCategory = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 6);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 8;
            label1.Text = "Sub-Category Name";
            // 
            // btn_AcceptCategory
            // 
            btn_AcceptCategory.Location = new Point(131, 52);
            btn_AcceptCategory.Name = "btn_AcceptCategory";
            btn_AcceptCategory.Size = new Size(112, 29);
            btn_AcceptCategory.TabIndex = 7;
            btn_AcceptCategory.Text = "Accept";
            btn_AcceptCategory.UseVisualStyleBackColor = true;
            btn_AcceptCategory.Click += InsertSubCategory;
            // 
            // tbox_SubCategory
            // 
            tbox_SubCategory.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_SubCategory.Location = new Point(12, 21);
            tbox_SubCategory.Name = "tbox_SubCategory";
            tbox_SubCategory.Size = new Size(348, 27);
            tbox_SubCategory.TabIndex = 6;
            // 
            // prompt_AddSubCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 87);
            Controls.Add(label1);
            Controls.Add(btn_AcceptCategory);
            Controls.Add(tbox_SubCategory);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "prompt_AddSubCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Sub-Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_AcceptCategory;
        private TextBox tbox_SubCategory;
    }
}
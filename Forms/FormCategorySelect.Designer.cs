﻿namespace Pocket_Auditor_Admin_Panel
{
    partial class FormCategorySelect
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
            lblCategories = new Label();
            pnl_ISI_View = new Panel();
            lblCatTitle = new Label();
            flpCategories = new FlowLayoutPanel();
            button1 = new Button();
            pnl_ISI_View.SuspendLayout();
            SuspendLayout();
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategories.Location = new Point(11, 13);
            lblCategories.Margin = new Padding(4, 0, 4, 0);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(131, 21);
            lblCategories.TabIndex = 0;
            lblCategories.Text = "Select a category ";
            // 
            // pnl_ISI_View
            // 
            pnl_ISI_View.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_ISI_View.BackColor = SystemColors.Control;
            pnl_ISI_View.Controls.Add(lblCatTitle);
            pnl_ISI_View.Location = new Point(284, 0);
            pnl_ISI_View.Margin = new Padding(4, 3, 4, 3);
            pnl_ISI_View.Name = "pnl_ISI_View";
            pnl_ISI_View.Size = new Size(700, 632);
            pnl_ISI_View.TabIndex = 2;
            // 
            // lblCatTitle
            // 
            lblCatTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCatTitle.AutoSize = true;
            lblCatTitle.Location = new Point(231, 21);
            lblCatTitle.Margin = new Padding(4, 0, 4, 0);
            lblCatTitle.Name = "lblCatTitle";
            lblCatTitle.Size = new Size(0, 15);
            lblCatTitle.TabIndex = 1;
            // 
            // flpCategories
            // 
            flpCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpCategories.FlowDirection = FlowDirection.TopDown;
            flpCategories.Location = new Point(0, 45);
            flpCategories.Margin = new Padding(0);
            flpCategories.Name = "flpCategories";
            flpCategories.Size = new Size(285, 587);
            flpCategories.TabIndex = 8;
            flpCategories.WrapContents = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(119, 186, 27);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(221, 5);
            button1.Name = "button1";
            button1.Size = new Size(55, 33);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormCategorySelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(984, 631);
            Controls.Add(button1);
            Controls.Add(lblCategories);
            Controls.Add(pnl_ISI_View);
            Controls.Add(flpCategories);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormCategorySelect";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AUDIT FORM";
            WindowState = FormWindowState.Maximized;
            pnl_ISI_View.ResumeLayout(false);
            pnl_ISI_View.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Panel pnl_ISI_View;
        private System.Windows.Forms.Label lblCatTitle;
        private System.Windows.Forms.FlowLayoutPanel flpCategories;
        private Button button1;
    }
}


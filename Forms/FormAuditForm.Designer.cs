namespace Pocket_Audior_Admin_Panel.Forms
{
    partial class FormAuditForm
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
            label2 = new Label();
            label3 = new Label();
            txtCategoryName = new TextBox();
            textBox2 = new TextBox();
            btnCatInsert = new Button();
            btnCatUpdate = new Button();
            btnCatDelete = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnSQuesDelete = new Button();
            btnSQuesUpdate = new Button();
            btnSQuesInsert = new Button();
            txtSubQuestion = new TextBox();
            label4 = new Label();
            cbxCategoryList = new ComboBox();
            btnQuesDelete = new Button();
            btnQuesUpdate = new Button();
            btnQuesInsert = new Button();
            dgvAuditForm = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditForm).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 1;
            label1.Text = "AUDIT FORM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 43);
            label2.Name = "label2";
            label2.Size = new Size(126, 18);
            label2.TabIndex = 2;
            label2.Text = "Category Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 95);
            label3.Name = "label3";
            label3.Size = new Size(82, 18);
            label3.TabIndex = 3;
            label3.Text = "Questions";
            // 
            // txtCategoryName
            // 
            txtCategoryName.BackColor = Color.Silver;
            txtCategoryName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoryName.Location = new Point(30, 64);
            txtCategoryName.Multiline = true;
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(221, 23);
            txtCategoryName.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Silver;
            textBox2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(158, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(284, 27);
            textBox2.TabIndex = 6;
            // 
            // btnCatInsert
            // 
            btnCatInsert.BackColor = Color.Lime;
            btnCatInsert.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCatInsert.Location = new Point(50, 171);
            btnCatInsert.Name = "btnCatInsert";
            btnCatInsert.Size = new Size(78, 27);
            btnCatInsert.TabIndex = 9;
            btnCatInsert.Text = "INSERT";
            btnCatInsert.UseVisualStyleBackColor = false;
            // 
            // btnCatUpdate
            // 
            btnCatUpdate.BackColor = Color.FromArgb(0, 192, 192);
            btnCatUpdate.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCatUpdate.Location = new Point(145, 171);
            btnCatUpdate.Name = "btnCatUpdate";
            btnCatUpdate.Size = new Size(78, 27);
            btnCatUpdate.TabIndex = 10;
            btnCatUpdate.Text = "UPDATE";
            btnCatUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCatDelete
            // 
            btnCatDelete.BackColor = Color.Red;
            btnCatDelete.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCatDelete.ForeColor = Color.White;
            btnCatDelete.Location = new Point(51, 214);
            btnCatDelete.Name = "btnCatDelete";
            btnCatDelete.Size = new Size(172, 27);
            btnCatDelete.TabIndex = 11;
            btnCatDelete.Text = "DELETE";
            btnCatDelete.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnCatDelete);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnCatUpdate);
            groupBox1.Controls.Add(txtCategoryName);
            groupBox1.Controls.Add(btnCatInsert);
            groupBox1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(28, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 301);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Category";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnSQuesDelete);
            groupBox2.Controls.Add(btnSQuesUpdate);
            groupBox2.Controls.Add(btnSQuesInsert);
            groupBox2.Controls.Add(txtSubQuestion);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cbxCategoryList);
            groupBox2.Controls.Add(btnQuesDelete);
            groupBox2.Controls.Add(btnQuesUpdate);
            groupBox2.Controls.Add(btnQuesInsert);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(312, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(520, 301);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add New Question/Sub-Question";
            // 
            // btnSQuesDelete
            // 
            btnSQuesDelete.BackColor = Color.Red;
            btnSQuesDelete.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSQuesDelete.ForeColor = Color.White;
            btnSQuesDelete.Location = new Point(396, 244);
            btnSQuesDelete.Name = "btnSQuesDelete";
            btnSQuesDelete.Size = new Size(78, 27);
            btnSQuesDelete.TabIndex = 22;
            btnSQuesDelete.Text = "DELETE";
            btnSQuesDelete.UseVisualStyleBackColor = false;
            // 
            // btnSQuesUpdate
            // 
            btnSQuesUpdate.BackColor = Color.FromArgb(0, 192, 192);
            btnSQuesUpdate.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSQuesUpdate.Location = new Point(291, 244);
            btnSQuesUpdate.Name = "btnSQuesUpdate";
            btnSQuesUpdate.Size = new Size(78, 27);
            btnSQuesUpdate.TabIndex = 21;
            btnSQuesUpdate.Text = "UPDATE";
            btnSQuesUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSQuesInsert
            // 
            btnSQuesInsert.BackColor = Color.Lime;
            btnSQuesInsert.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSQuesInsert.Location = new Point(186, 244);
            btnSQuesInsert.Name = "btnSQuesInsert";
            btnSQuesInsert.Size = new Size(78, 27);
            btnSQuesInsert.TabIndex = 20;
            btnSQuesInsert.Text = "INSERT";
            btnSQuesInsert.UseVisualStyleBackColor = false;
            // 
            // txtSubQuestion
            // 
            txtSubQuestion.BackColor = Color.Silver;
            txtSubQuestion.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubQuestion.Location = new Point(158, 194);
            txtSubQuestion.Name = "txtSubQuestion";
            txtSubQuestion.Size = new Size(284, 27);
            txtSubQuestion.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 200);
            label4.Name = "label4";
            label4.Size = new Size(117, 18);
            label4.TabIndex = 18;
            label4.Text = "Sub-Questions";
            // 
            // cbxCategoryList
            // 
            cbxCategoryList.BackColor = Color.Silver;
            cbxCategoryList.FormattingEnabled = true;
            cbxCategoryList.Location = new Point(15, 44);
            cbxCategoryList.Name = "cbxCategoryList";
            cbxCategoryList.Size = new Size(484, 26);
            cbxCategoryList.TabIndex = 15;
            cbxCategoryList.Text = "Select Category Name";
            // 
            // btnQuesDelete
            // 
            btnQuesDelete.BackColor = Color.Red;
            btnQuesDelete.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuesDelete.ForeColor = Color.White;
            btnQuesDelete.Location = new Point(400, 138);
            btnQuesDelete.Name = "btnQuesDelete";
            btnQuesDelete.Size = new Size(78, 27);
            btnQuesDelete.TabIndex = 14;
            btnQuesDelete.Text = "DELETE";
            btnQuesDelete.UseVisualStyleBackColor = false;
            // 
            // btnQuesUpdate
            // 
            btnQuesUpdate.BackColor = Color.FromArgb(0, 192, 192);
            btnQuesUpdate.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuesUpdate.Location = new Point(295, 138);
            btnQuesUpdate.Name = "btnQuesUpdate";
            btnQuesUpdate.Size = new Size(78, 27);
            btnQuesUpdate.TabIndex = 13;
            btnQuesUpdate.Text = "UPDATE";
            btnQuesUpdate.UseVisualStyleBackColor = false;
            // 
            // btnQuesInsert
            // 
            btnQuesInsert.BackColor = Color.Lime;
            btnQuesInsert.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuesInsert.Location = new Point(190, 138);
            btnQuesInsert.Name = "btnQuesInsert";
            btnQuesInsert.Size = new Size(78, 27);
            btnQuesInsert.TabIndex = 12;
            btnQuesInsert.Text = "INSERT";
            btnQuesInsert.UseVisualStyleBackColor = false;
            // 
            // dgvAuditForm
            // 
            dgvAuditForm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditForm.Location = new Point(28, 392);
            dgvAuditForm.Name = "dgvAuditForm";
            dgvAuditForm.RowTemplate.Height = 25;
            dgvAuditForm.Size = new Size(804, 207);
            dgvAuditForm.TabIndex = 14;
            // 
            // FormAuditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(915, 631);
            Controls.Add(dgvAuditForm);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAuditForm";
            Text = "FormAuditForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditForm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCategoryName;
        private TextBox textBox2;
        private Button btnCatInsert;
        private Button btnCatUpdate;
        private Button btnCatDelete;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnQuesDelete;
        private Button btnQuesUpdate;
        private Button btnQuesInsert;
        private ComboBox cbxCategoryList;
        private Button btnSQuesDelete;
        private Button btnSQuesUpdate;
        private Button btnSQuesInsert;
        private TextBox txtSubQuestion;
        private Label label4;
        private DataGridView dgvAuditForm;
    }
}
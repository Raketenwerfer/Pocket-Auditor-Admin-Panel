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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // textBox1
            // 
            textBox1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(30, 64);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(158, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(284, 27);
            textBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(50, 171);
            button1.Name = "button1";
            button1.Size = new Size(78, 27);
            button1.TabIndex = 9;
            button1.Text = "INSERT";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(145, 171);
            button2.Name = "button2";
            button2.Size = new Size(78, 27);
            button2.TabIndex = 10;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(51, 214);
            button3.Name = "button3";
            button3.Size = new Size(172, 27);
            button3.TabIndex = 11;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
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
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button6);
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
            // button7
            // 
            button7.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(396, 244);
            button7.Name = "button7";
            button7.Size = new Size(78, 27);
            button7.TabIndex = 22;
            button7.Text = "DELETE";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(291, 244);
            button8.Name = "button8";
            button8.Size = new Size(78, 27);
            button8.TabIndex = 21;
            button8.Text = "UPDATE";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(186, 244);
            button9.Name = "button9";
            button9.Size = new Size(78, 27);
            button9.TabIndex = 20;
            button9.Text = "INSERT";
            button9.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(158, 194);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(284, 27);
            textBox3.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 197);
            label4.Name = "label4";
            label4.Size = new Size(117, 18);
            label4.TabIndex = 18;
            label4.Text = "Sub-Questions";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(484, 26);
            comboBox1.TabIndex = 15;
            comboBox1.Text = "Select Category Name";
            // 
            // button4
            // 
            button4.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(400, 138);
            button4.Name = "button4";
            button4.Size = new Size(78, 27);
            button4.TabIndex = 14;
            button4.Text = "DELETE";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(295, 138);
            button5.Name = "button5";
            button5.Size = new Size(78, 27);
            button5.TabIndex = 13;
            button5.Text = "UPDATE";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(190, 138);
            button6.Name = "button6";
            button6.Size = new Size(78, 27);
            button6.TabIndex = 12;
            button6.Text = "INSERT";
            button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 392);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(804, 207);
            dataGridView1.TabIndex = 14;
            // 
            // FormAuditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(915, 631);
            Controls.Add(dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button4;
        private Button button5;
        private Button button6;
        private ComboBox comboBox1;
        private Button button7;
        private Button button8;
        private Button button9;
        private TextBox textBox3;
        private Label label4;
        private DataGridView dataGridView1;
    }
}
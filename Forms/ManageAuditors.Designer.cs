namespace Pocket_Audior_Admin_Panel.Forms
{
    partial class ManageAuditors
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 58);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(316, 19);
            label1.Name = "label1";
            label1.Size = new Size(119, 18);
            label1.TabIndex = 0;
            label1.Text = "Edit Auditors";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(189, 100);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(189, 142);
            label3.Name = "label3";
            label3.Size = new Size(55, 18);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(189, 183);
            label4.Name = "label4";
            label4.Size = new Size(85, 18);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(189, 222);
            label5.Name = "label5";
            label5.Size = new Size(105, 18);
            label5.TabIndex = 4;
            label5.Text = "Department";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(321, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(321, 219);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(321, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(212, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(321, 139);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(212, 27);
            textBox4.TabIndex = 8;
            // 
            // ManageAuditors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "ManageAuditors";
            Text = "ManageAuditors";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
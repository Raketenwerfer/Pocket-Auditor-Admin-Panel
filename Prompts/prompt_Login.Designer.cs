namespace Pocket_Auditor_Admin_Panel.Prompts
{
    partial class prompt_Login
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
            tbox_Username = new TextBox();
            tbox_Password = new TextBox();
            label2 = new Label();
            btn_Login = new Button();
            btn_Close = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HP Simplified Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // tbox_Username
            // 
            tbox_Username.Font = new Font("HP Simplified Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_Username.Location = new Point(12, 35);
            tbox_Username.Name = "tbox_Username";
            tbox_Username.Size = new Size(332, 26);
            tbox_Username.TabIndex = 1;
            // 
            // tbox_Password
            // 
            tbox_Password.Font = new Font("HP Simplified Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_Password.Location = new Point(12, 90);
            tbox_Password.Name = "tbox_Password";
            tbox_Password.PasswordChar = '•';
            tbox_Password.Size = new Size(332, 26);
            tbox_Password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HP Simplified Light", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(73, 19);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.MediumSeaGreen;
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("HP Simplified", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Login.Location = new Point(96, 135);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(80, 30);
            btn_Login.TabIndex = 4;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += Authenticate;
            // 
            // btn_Close
            // 
            btn_Close.BackColor = Color.IndianRed;
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Font = new Font("HP Simplified", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Close.Location = new Point(182, 135);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(80, 30);
            btn_Close.TabIndex = 5;
            btn_Close.Text = "Exit";
            btn_Close.UseVisualStyleBackColor = false;
            btn_Close.Click += btn_Close_Click;
            // 
            // prompt_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 177);
            Controls.Add(btn_Close);
            Controls.Add(btn_Login);
            Controls.Add(tbox_Password);
            Controls.Add(label2);
            Controls.Add(tbox_Username);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "prompt_Login";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbox_Username;
        private TextBox tbox_Password;
        private Label label2;
        private Button btn_Login;
        private Button btn_Close;
    }
}
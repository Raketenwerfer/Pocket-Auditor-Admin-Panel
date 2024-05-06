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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            btn_Login = new Button();
            btn_Close = new Button();
            tbox_Username = new Guna.UI2.WinForms.Guna2TextBox();
            tbox_Password = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(12, 103);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(12, 181);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.FromArgb(119, 186, 27);
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(44, 260);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(111, 30);
            btn_Login.TabIndex = 4;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += Authenticate;
            // 
            // btn_Close
            // 
            btn_Close.BackColor = Color.Salmon;
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Close.ForeColor = Color.White;
            btn_Close.Location = new Point(172, 260);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(111, 30);
            btn_Close.TabIndex = 5;
            btn_Close.Text = "Exit";
            btn_Close.UseVisualStyleBackColor = false;
            btn_Close.Click += btn_Close_Click;
            // 
            // tbox_Username
            // 
            tbox_Username.BorderColor = Color.Silver;
            tbox_Username.BorderRadius = 15;
            tbox_Username.CustomizableEdges = customizableEdges1;
            tbox_Username.DefaultText = "";
            tbox_Username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbox_Username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbox_Username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbox_Username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbox_Username.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbox_Username.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_Username.ForeColor = Color.Black;
            tbox_Username.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbox_Username.Location = new Point(12, 126);
            tbox_Username.Name = "tbox_Username";
            tbox_Username.PasswordChar = '\0';
            tbox_Username.PlaceholderText = "";
            tbox_Username.SelectedText = "";
            tbox_Username.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbox_Username.Size = new Size(298, 36);
            tbox_Username.TabIndex = 6;
            // 
            // tbox_Password
            // 
            tbox_Password.BorderColor = Color.Silver;
            tbox_Password.BorderRadius = 15;
            tbox_Password.CustomizableEdges = customizableEdges3;
            tbox_Password.DefaultText = "";
            tbox_Password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbox_Password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbox_Password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbox_Password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbox_Password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbox_Password.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_Password.ForeColor = Color.Black;
            tbox_Password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbox_Password.Location = new Point(12, 204);
            tbox_Password.Name = "tbox_Password";
            tbox_Password.PasswordChar = '*';
            tbox_Password.PlaceholderText = "";
            tbox_Password.SelectedText = "";
            tbox_Password.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tbox_Password.Size = new Size(298, 36);
            tbox_Password.TabIndex = 7;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(119, 186, 27);
            guna2HtmlLabel1.Location = new Point(65, 37);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(197, 39);
            guna2HtmlLabel1.TabIndex = 8;
            guna2HtmlLabel1.Text = "Ready to Login";
            // 
            // prompt_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 335);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(tbox_Password);
            Controls.Add(tbox_Username);
            Controls.Add(btn_Close);
            Controls.Add(btn_Login);
            Controls.Add(label2);
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
        private Label label2;
        private Button btn_Login;
        private Button btn_Close;
        private Guna.UI2.WinForms.Guna2TextBox tbox_Username;
        private Guna.UI2.WinForms.Guna2TextBox tbox_Password;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
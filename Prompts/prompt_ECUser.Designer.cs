namespace Pocket_Auditor_Admin_Panel.Prompts
{
    partial class prompt_ECUser
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
            lbl_EditType = new Label();
            label1 = new Label();
            tbox_Username = new TextBox();
            tbox_Password = new TextBox();
            label2 = new Label();
            cbox_UserType = new ComboBox();
            label3 = new Label();
            btn_Accept = new Button();
            btn_Alt = new Button();
            SuspendLayout();
            // 
            // lbl_EditType
            // 
            lbl_EditType.AutoSize = true;
            lbl_EditType.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_EditType.Location = new Point(10, 10);
            lbl_EditType.Name = "lbl_EditType";
            lbl_EditType.Size = new Size(50, 20);
            lbl_EditType.TabIndex = 0;
            lbl_EditType.Text = "label1";
            lbl_EditType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // tbox_Username
            // 
            tbox_Username.BackColor = Color.DimGray;
            tbox_Username.BorderStyle = BorderStyle.FixedSingle;
            tbox_Username.ForeColor = Color.White;
            tbox_Username.Location = new Point(12, 59);
            tbox_Username.Name = "tbox_Username";
            tbox_Username.Size = new Size(199, 23);
            tbox_Username.TabIndex = 2;
            // 
            // tbox_Password
            // 
            tbox_Password.BackColor = Color.DimGray;
            tbox_Password.BorderStyle = BorderStyle.FixedSingle;
            tbox_Password.ForeColor = Color.White;
            tbox_Password.Location = new Point(12, 106);
            tbox_Password.Name = "tbox_Password";
            tbox_Password.Size = new Size(199, 23);
            tbox_Password.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // cbox_UserType
            // 
            cbox_UserType.FormattingEnabled = true;
            cbox_UserType.Items.AddRange(new object[] { "USER", "ADMIN" });
            cbox_UserType.Location = new Point(12, 157);
            cbox_UserType.Name = "cbox_UserType";
            cbox_UserType.Size = new Size(121, 23);
            cbox_UserType.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 139);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "User Type";
            // 
            // btn_Accept
            // 
            btn_Accept.ForeColor = Color.Black;
            btn_Accept.Location = new Point(25, 215);
            btn_Accept.Name = "btn_Accept";
            btn_Accept.Size = new Size(84, 31);
            btn_Accept.TabIndex = 7;
            btn_Accept.Text = "button1";
            btn_Accept.UseVisualStyleBackColor = true;
            // 
            // btn_Alt
            // 
            btn_Alt.ForeColor = Color.Black;
            btn_Alt.Location = new Point(115, 215);
            btn_Alt.Name = "btn_Alt";
            btn_Alt.Size = new Size(84, 31);
            btn_Alt.TabIndex = 8;
            btn_Alt.Text = "button1";
            btn_Alt.UseVisualStyleBackColor = true;
            // 
            // prompt_ECUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(227, 258);
            Controls.Add(btn_Alt);
            Controls.Add(btn_Accept);
            Controls.Add(label3);
            Controls.Add(cbox_UserType);
            Controls.Add(tbox_Password);
            Controls.Add(label2);
            Controls.Add(tbox_Username);
            Controls.Add(label1);
            Controls.Add(lbl_EditType);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "prompt_ECUser";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Management Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_EditType;
        private Label label1;
        private TextBox tbox_Username;
        private TextBox tbox_Password;
        private Label label2;
        private ComboBox cbox_UserType;
        private Label label3;
        private Button btn_Accept;
        private Button btn_Alt;
    }
}
using Pocket_Auditor_Admin_Panel.Auxiliaries;
using Pocket_Auditor_Admin_Panel.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pocket_Auditor_Admin_Panel.Prompts
{
    public partial class prompt_Login : Form
    {
        List<mdl_Users> _Users;
        DataSharingService DSS;
        public prompt_Login(List<mdl_Users> list)
        {
            DSS = DataSharingService.GetInstance();
            _Users = list;
            InitializeComponent();
        }
        private void Authenticate(object sender, EventArgs e)
        {
            string encpass = EncryptionService(tbox_Password.Text);
            foreach (mdl_Users x in _Users)
            {
                if (x.Username == tbox_Username.Text && x.Password == encpass)
                {
                    if (x.UserType == "ADMIN")
                    {
                        DSS.SET_LOGGEDIN(true);
                        MessageBox.Show("Successfully logged in as " + x.Username + "!");
                        this.Close();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("This user is not authorized to use this panel!", "No authorization",
                            MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect!", "Incorrect credentials",
                        MessageBoxButtons.OK);
                    break;
                }
            }
        }

        public static string EncryptionService(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider class.
            using (MD5 md5 = MD5.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to a hexadecimal string.
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DSS.SET_LOGGEDIN(false);
            this.Close();
        }

        private void tbox_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

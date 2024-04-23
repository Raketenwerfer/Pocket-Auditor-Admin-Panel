using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Pocket_Auditor_Admin_Panel.Auxiliaries;
using Pocket_Auditor_Admin_Panel.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pocket_Auditor_Admin_Panel.Prompts
{
    public partial class prompt_ECUser : Form
    {
        DataSharingService DSS;
        DatabaseInitiator dbInit;
        string process_type;
        int? SelectedUser;
        AdminPanel AP;

        List<mdl_Users> _Users;
        public prompt_ECUser(string type, int? selectedUser, AdminPanel ap_pass)
        {
            DSS = DataSharingService.GetInstance();
            dbInit = DSS.GetDatabase();
            process_type = type;
            SelectedUser = selectedUser;
            AP = ap_pass;
            InitializeComponent();

            _Users = DSS.GET_U();
            cbox_UserType.SelectedIndex = 0;

            InitPrompt();
        }

        public void InitPrompt()
        {
            if (process_type == "create")
            {
                lbl_EditType.Text = "Create New User";
                Text = "Create User";
                btn_Accept.Text = "Create";
                btn_Accept.BackColor = Color.MediumSeaGreen;
                btn_Alt.Text = "Close";
            }
            else if (process_type == "edit")
            {
                foreach (mdl_Users x in _Users)
                {
                    if (SelectedUser == x.UserID)
                    {
                        tbox_Username.Text = x.Username;
                        cbox_UserType.Text = x.UserType;
                        break;
                    }
                }

                lbl_EditType.Text = "Edit User Details";
                Text = "Edit User";
                btn_Accept.Text = "Save";
                btn_Accept.BackColor = Color.SkyBlue;
                btn_Alt.Text = "Delete";
                btn_Alt.BackColor = Color.IndianRed;
            }
        }

        public void PressAccept(object sender, EventArgs e)
        {
            if (process_type == "create")
            {
                AddUser();
            }
            else if (process_type == "edit")
            {
                EditUser();
            }
            Close();
        }
        public void PressAlt(object sender, EventArgs e)
        {
            if (process_type == "edit")
            {
                DeleteUser();
            }
            Close();
        }


        public void AddUser()
        {
            string query = "INSERT INTO users (Username, Password, UserType, UserStatus) " +
                "VALUES (@Username, @Password, @UserType, @UserStatus)";
            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", tbox_Password.Text);
                    cmd.Parameters.AddWithValue("@Password", EncryptionService(tbox_Password.Text));
                    cmd.Parameters.AddWithValue("@UserType", cbox_UserType.Text);
                    cmd.Parameters.AddWithValue("@UserStatus", "ACTIVE");

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("User successfully created!");
                conn.Close();
                AP.PullUsers();
            }
        }
        public void EditUser()
        {
            string query = "UPDATE users SET Username = @Username, UserType = @UserType, Password = @Pass " +
                "WHERE UserID = @UserID";

            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", tbox_Username.Text);
                    cmd.Parameters.AddWithValue("Pass", EncryptionService(tbox_Password.Text));
                    cmd.Parameters.AddWithValue("@UserType", cbox_UserType.Text);
                    cmd.Parameters.AddWithValue("@UserID", SelectedUser);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Changes saved successfully!");
                conn.Close();
                AP.PullUsers();
            }
        }
        public void DeleteUser()
        {
            string query = "DELETE FROM users WHERE UserID = @UserID";

            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", SelectedUser);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Selected user has been removed!");
                conn.Close();
                AP.PullUsers();
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
    }
}

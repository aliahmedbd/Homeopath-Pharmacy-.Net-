using HomeoPathPhamacy.Entity;
using HomeopathPharmacy.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeoPathPharmacy
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        ChangePasswordCommand cmd = new ChangePasswordCommand();
        string user_name, old_password, new_password, confirm_password;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void UserNameTxt_TextChanged(object sender, EventArgs e)
        {
            user_name = UserNameTxt.Text;
        }

        private void oldPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            old_password = oldPasswordTxt.Text;
        }

        private void newPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            new_password = newPasswordTxt.Text;
        }

        private void confirmPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            confirm_password = confirmPasswordTxt.Text;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserNameTxt.Text) || string.IsNullOrEmpty(oldPasswordTxt.Text) || string.IsNullOrEmpty(confirmPasswordTxt.Text) || string.IsNullOrEmpty(newPasswordTxt.Text))
            {
                MessageBox.Show("Provide All The Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                LogInInfo ob = new LogInInfo();
                ob = cmd.GetUserName(user_name);
                if (ob.UserName == user_name && ob.Password == old_password && new_password == confirm_password)
                {
                    cmd.ChangePassword(user_name, new_password);
                }
                this.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

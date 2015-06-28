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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        string user_name, password, confirm_password;
        RegistrstionCommand cmd = new RegistrstionCommand();
        RegistrationInfo info=new RegistrationInfo();
        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void userNameTxt_TextChanged(object sender, EventArgs e)
        {
            user_name = userNameTxt.Text;
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            password = passwordTxt.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            confirm_password = confirmPasswordTxt.Text;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userNameTxt.Text) || string.IsNullOrEmpty(passwordTxt.Text) || string.IsNullOrEmpty(confirmPasswordTxt.Text))
            {
                MessageBox.Show("Provide All The Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                info = cmd.GetUserName(user_name);
                if (info.UserName == user_name)
                {
                    MessageBox.Show("Name Already Exist");
                }
                else
                {
                    if (password == confirm_password)
                    {
                        info.UserName = user_name;
                        info.Password = password;

                        cmd.Insert(info);
                        MessageBox.Show("Registration Successfull");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Password Not Match!");
                }
            }
        }

    }
}

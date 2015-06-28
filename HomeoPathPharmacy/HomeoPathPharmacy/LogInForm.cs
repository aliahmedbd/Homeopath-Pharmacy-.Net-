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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
        string userName;
        string password;
        LogInInfo ob = new LogInInfo();
        LogInCommand cmd = new LogInCommand();
        private void logInBtn_Click(object sender, EventArgs e)
        {
            ob = cmd.GetUserName(userName);
            if (ob.UserName == userName && ob.Password == password)
            {
                ActionForm af = new ActionForm();
                af.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid UserName and Password ");

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userNameTxt_TextChanged(object sender, EventArgs e)
        {
            userName = userNameTxt.Text;
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            password = passwordTxt.Text;
        }
    }
}

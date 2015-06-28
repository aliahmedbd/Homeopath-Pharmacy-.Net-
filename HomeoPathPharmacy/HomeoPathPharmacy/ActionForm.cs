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
    public partial class ActionForm : Form
    {
        public ActionForm()
        {
            InitializeComponent();
        }

        private void removePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchPatientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewPatientForm ob = new NewPatientForm();
            ob.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm ob = new SearchForm();
            ob.Show();
        }

        private void oldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OldPatientForm ob = new OldPatientForm();
            ob.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveForm ob = new RemoveForm();
            ob.Show();

        }

        private void searchPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm ob = new SearchForm();
            ob.Show();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            NewPatientForm ob = new NewPatientForm();
            ob.Show();
        }

        private void openToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OldPatientForm ob = new OldPatientForm();
            ob.Show();
        }

        private void openToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RemoveForm ob = new RemoveForm();
            ob.Show();
           
        }

        private void ActionForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Aplication_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ChangePassword ob = new ChangePassword();
            ob.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchForm ob = new SearchForm();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewPatientForm ob = new NewPatientForm();
            ob.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OldPatientForm ob = new OldPatientForm();
            ob.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegistrationForm ob = new RegistrationForm();
            ob.Show();
        }

        private void openToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            RemoveForm ob = new RemoveForm();
            ob.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Today_sOncome ob = new Today_sOncome();
            ob.Show();
        }
    }
}

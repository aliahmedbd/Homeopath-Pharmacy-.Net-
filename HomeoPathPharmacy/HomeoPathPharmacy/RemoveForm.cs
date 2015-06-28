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
    public partial class RemoveForm : Form
    {
        public RemoveForm()
        {
            InitializeComponent();
        }
        int id;
        RemoveCommand cmd=new RemoveCommand();
        private void RemoveForm_Load(object sender, EventArgs e)
        {

        }

        private void patientIdTxt_TextChanged(object sender, EventArgs e)
        {
            id = int.Parse(patientIdTxt.Text);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (patientIdTxt.Text != "")
            {
                cmd.RemovePatient(id);
                this.Close();
            }
            else 
            {
                MessageBox.Show("Patient Id Required");
            }
        }
    }
}

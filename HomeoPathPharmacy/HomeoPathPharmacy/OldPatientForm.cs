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
    public partial class OldPatientForm : Form
    {
        public OldPatientForm()
        {
            InitializeComponent();
        }
        int id, amount, paid;
        string  medicine_name;
        OldPatientInfo info = new OldPatientInfo();
        OldPatientCommnd cmd = new OldPatientCommnd();
        NewPatientInfo cd = new NewPatientInfo();
        private void OldPatientForm_Load(object sender, EventArgs e)
        {

        }

        private void patientIdTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(patientIdTxt.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Id Can not be Empty!!");
            }
        }

        private void medicineNameTxt_TextChanged(object sender, EventArgs e)
        {
            medicine_name = medicineNameTxt.Text;
        }

        private void amountTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                amount = int.Parse(amountTxt.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong");
            }
        }

        private void paidTxt_TextChanged(object sender, EventArgs e)
        {
            paid = int.Parse(paidTxt.Text);
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(patientIdTxt.Text) || string.IsNullOrEmpty(medicineNameTxt.Text) || string.IsNullOrEmpty(amountTxt.Text) || string.IsNullOrEmpty(paidTxt.Text))
            {
                MessageBox.Show("Provide All The Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                info.PatientId = id;
                info.MedicineName = medicine_name;
                info.Amount = amount + cd.Have_To_Paid;
                info.Paid = paid;
                if (amount >= paid)
                {
                    info.Have_To_Paid = amount - paid;
                }
                cmd.OldPatient(info);
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

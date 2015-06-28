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
    public partial class NewPatientForm : Form
    {
        public NewPatientForm()
        {
            InitializeComponent();
        }
        string patientName, medicine,symptom;
        int amount, paid;
        NewPatientCommand cmd = new NewPatientCommand();
        NewPatientInfo info = new NewPatientInfo();
        private void NewPatientForm_Load(object sender, EventArgs e)
        {
            newPatientGrid.Hide();
        }

        private void patientNameTxt_TextChanged(object sender, EventArgs e)
        {
            patientName = patientNameTxt.Text;
        }

        private void medicineNameTxt_TextChanged(object sender, EventArgs e)
        {
            medicine = medicineNameTxt.Text;
        }

        private void amountTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                amount = int.Parse(amountTxt.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong!!");
            }
        }

        private void paidTxt_TextChanged(object sender, EventArgs e)
        {
            paid = int.Parse(paidTxt.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        SearchCommand cd = new SearchCommand();
        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(medicineNameTxt.Text) || string.IsNullOrEmpty(amountTxt.Text) || string.IsNullOrEmpty(paidTxt.Text))
            {
                MessageBox.Show("Provide All The Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                info.PatientName = patientName;
                info.MedicineName = medicine;
                info.Amount = amount;
                info.Paid = paid;
                info.Symptom = symptom;
                if (amount >= paid)
                {

                    info.Have_To_Paid = amount - paid;
                }
                cmd.NewPatient(info);
                //this.Close();
                newPatientGrid.DataSource = cd.GetPatientDetailsName(patientName);
                newPatientGrid.Show();
                MessageBox.Show("Add Successfully..");

            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSymptom_TextChanged(object sender, EventArgs e)
        {
            symptom = txtSymptom.Text;
        }

        private void newPatientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}

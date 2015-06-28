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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            searchBookGrid.Visible = false;
        }
        int id;
        string name;
        private void patentIdTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(patentIdTxt.Text);
            }
            catch (FormatException )
            {
                MessageBox.Show("Wrong");
            }
        }
        SearchCommand sd = new SearchCommand();

        private void searchBtn_Click(object sender, EventArgs e)
        {
            
            if (patentIdTxt.Text != "")
            {
                searchBookGrid.Visible = true;
                searchBookGrid.DataSource = sd.GetPatientDetails(id);
            }
            else if (nameTxt.Text != "")
            {
                searchBookGrid.Visible = true;
                searchBookGrid.DataSource = sd.GetPatientDetailsName(name);

            }
            else 
            {
                MessageBox.Show("Name or Id required");
            }

            
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            searchBookGrid.Hide();
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            name = nameTxt.Text;
        }

        private void treatmentBtn_Click(object sender, EventArgs e)
        {
            OldPatientForm ob = new OldPatientForm();
            ob.Show();
            this.Close();
        }

    }
}

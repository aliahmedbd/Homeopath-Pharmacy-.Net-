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
    public partial class Today_sOncome : Form
    {
        public Today_sOncome()
        {
            InitializeComponent();
        }
        TotalIncomeCommand ob = new TotalIncomeCommand();
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Today_sOncome_Load(object sender, EventArgs e)
        {

        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if(ob.GetTotalIncome()!=null){
            //TotalIncomeCommand cmd = new TotalIncomeCommand();
            //totalIncomeDataGrid.DataSource = ob.GetTotalIncome();
            //SearchCommand ob = new SearchCommand();
            //ob.
           // totalIncomeDataGrid.DataSource = ob.GetPatientDetails(5);
            lblIncome.Text = ob.GetTotalIncome().TotalPaid.ToString("0.00");
            }
            
        }
    }
}

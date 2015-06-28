using HomeoPathPhamacy.Entity;
using HomeoPathPharmacy.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeopathPharmacy.DataAccess
{
    public class TotalIncomeCommand
    {
        TotalInfo GetData(SqlCommand cmd)
        {
            if(cmd.Connection.State==System.Data.ConnectionState.Closed)
                cmd.Connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            TotalInfo ob = new TotalInfo();
            using (reader)
            {
                while (reader.Read())
                {
                    //if()
                    
                    ob.TotalPaid = reader.GetInt32(0);                 
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return ob;
        }
        
           
       
            public TotalInfo  GetTotalIncome()
            {
                HomeoPathFramework da = new HomeoPathFramework();
                SqlCommand cmd = da.GetCommand("select SUM(Paid) from Patient_Medicine where CAST(Visit_Date as date)=@date");
                cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);                
                TotalInfo ob=GetData(cmd);
                return ob;
   
            }
        
    }
}

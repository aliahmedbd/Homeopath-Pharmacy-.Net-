using HomeoPathPhamacy.Entity;
using HomeoPathPharmacy.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeopathPharmacy.DataAccess
{
    public class OldPatientCommnd
    {
        public bool OldPatient(OldPatientInfo obj)
        {
            HomeoPathFramework ob = new HomeoPathFramework();
            SqlCommand cmd = ob.GetCommand("Update Patient_Medicine set Medicine_Name =@MedicineName,Amount=@Amount,Paid=@Paid,Have_To_Paid=@Have_To_Paid,Visit_Date=@Date where Patient_Id=@PatientId");
            SqlParameter p0 = new SqlParameter(@"PatientId", SqlDbType.Int);
            p0.Value = obj.PatientId;
            
            SqlParameter p1 = new SqlParameter(@"MedicineName", SqlDbType.VarChar, 50);
            p1.Value = obj.MedicineName;
            SqlParameter p2 = new SqlParameter(@"Amount", SqlDbType.Int);
            p2.Value = obj.Amount;
            SqlParameter p3 = new SqlParameter(@"Paid", SqlDbType.Int);
            p3.Value = obj.Paid;
            SqlParameter p4 = new SqlParameter(@"Have_To_Paid", SqlDbType.Int);
            p4.Value = obj.Have_To_Paid;
            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            cmd.Parameters.Add(p0);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);

            cmd.Connection.Open();

            int val = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return val > 0;
        }
    }
}

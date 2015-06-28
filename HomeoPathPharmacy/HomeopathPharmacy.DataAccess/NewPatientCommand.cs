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
    public class NewPatientCommand
    {
        public bool NewPatient(NewPatientInfo obj)
        {
            HomeoPathFramework hf = new HomeoPathFramework();
            SqlCommand cmd = hf.GetCommand("insert into [dbo].[Patient_Medicine] ([Patient_Name],[Medicine_Name],[Amount],[Paid],[Have_To_Paid],[Visit_Date],[Symptoms])" + "values(@PatientName,@MedicineName,@Amount,@Paid,@Have_To_Paid,@Date,@symptom)");
            SqlParameter p = new SqlParameter(@"PatientName",SqlDbType.VarChar,50 );
            p.Value = obj.PatientName;
            SqlParameter p1 = new SqlParameter(@"MedicineName",SqlDbType.VarChar,50);
            p1.Value = obj.MedicineName;
            SqlParameter p2 = new SqlParameter(@"Amount", SqlDbType.Int);
            p2.Value = obj.Amount;
            SqlParameter p3 = new SqlParameter(@"Paid", SqlDbType.Int);
            p3.Value = obj.Paid;
            SqlParameter p4 = new SqlParameter(@"Have_To_Paid", SqlDbType.Int);
            p4.Value = obj.Have_To_Paid;
            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            SqlParameter p5 = new SqlParameter(@"symptom",SqlDbType.VarChar,50);
            p5.Value = obj.Symptom;
            cmd.Parameters.Add(p);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Connection.Open();
            int val = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return val>0;
        }
        
    }
}

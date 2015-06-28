using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeoPathPhamacy.Entity;
using HomeoPathPharmacy.Framework;
using System.Data.SqlClient;

namespace HomeopathPharmacy.DataAccess
{
    public class SearchCommand
    {
        
        List <SearchInfo> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader=cmd.ExecuteReader();
            
            List<SearchInfo> list = new List<SearchInfo>();
            using (reader)
            {
                while(reader.Read())
                {
                    SearchInfo ob = new SearchInfo();
                    ob.PatientId=reader.GetInt32(0);
                    ob.PatientName=reader.GetString(1);
                    ob.MedicineName=reader.GetString(2);
                    ob.Amount=reader.GetInt32(3);
                    ob.Paid = reader.GetInt32(4);
                    ob.Have_To_Paid = reader.GetInt32(5);
                   
                    //ob.Sys_Date = Convert.ToString(reader.GetSqlDateTime(6));
                    //ob.Sys_Date = Convert.ToString(reader.GetDateTime(6));
                    ob.Sys_date = Convert.ToString(reader.GetDateTime(6));
                    ob.Symptom = reader.GetString(7);
                    list.Add(ob);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return list;
        }
        public List<SearchInfo> GetPatientDetails(int id) 
        {
            HomeoPathFramework da = new HomeoPathFramework();
            SqlCommand cmd = da.GetCommand("select * from  Patient_Medicine where  Patient_Id =" + id + "");
            List<SearchInfo> ob = GetData(cmd);
            return ob;
        }
        public List<SearchInfo> GetPatientDetailsName(string name)
        {
            HomeoPathFramework da = new HomeoPathFramework();
            SqlCommand cmd = da.GetCommand("select * from  Patient_Medicine where  Patient_Name like '%" + name + "%'");
            List<SearchInfo> ob = GetData(cmd);
            return ob;
        }
    }
    }


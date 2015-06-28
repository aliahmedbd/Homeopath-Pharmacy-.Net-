using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeoPathPhamacy.Entity
{
    public class NewPatientInfo
    {
        private string patientName;
        private string medicineName;
        private int amount;
        private int paid;
        private int have_To_Paid;
        private string symptoms;
        public string PatientName{ get{ return patientName;}set{patientName = value;}}
        public string MedicineName { get { return medicineName; } set { medicineName = value; } }
        public int Amount { get { return amount; } set { amount = value; } }
        public int Paid { get { return paid; } set { paid = value; } }
        public int Have_To_Paid { get { return have_To_Paid; } set {have_To_Paid = value; } }
        public string Symptom { get { return symptoms; } set { symptoms = value; } }
    }
}

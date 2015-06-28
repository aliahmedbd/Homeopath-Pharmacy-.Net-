using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeoPathPhamacy.Entity
{
    public class OldPatientInfo
    {
        private int patientId;
        private string medicineName;
        private int amount;
        private int paid;
        private int have_To_Paid;
        private string symptom;
        public int PatientId { get { return patientId; } set { patientId = value; } }
        public string MedicineName { get { return medicineName; } set { medicineName = value; } }
        public int Amount { get { return amount; } set { amount = value; } }
        public int Paid { get { return paid; } set { paid = value; } }
        public int Have_To_Paid { get { return have_To_Paid; } set { have_To_Paid = value; } }
        public string Symptom { get { return symptom; } set { symptom = value; } }
        
    }
}

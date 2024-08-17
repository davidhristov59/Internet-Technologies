using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3_rework.Models
{
    public class DoctorPatients
    {
        public int patientID { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }

        public int doctorID;
        public Doctor doctor { get; set; }

        public DoctorPatients()
        {
            Patients = new List<Patient>();
        }

    }
    
}
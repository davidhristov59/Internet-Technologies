using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class DoctorPatient
    {
        //many-to-many relationships

        public DoctorPatient() {
            Patients = new List<Patient>();
        }

        public int PatientID { get; set; }
        public int DoctorID { get; set; }


        public virtual ICollection<Patient> Patients { get; set; }
        public Doctor Doctor { get; set; }
    }
}
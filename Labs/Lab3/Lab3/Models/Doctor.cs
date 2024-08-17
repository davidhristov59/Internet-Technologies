using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class Doctor
    {

        public Doctor()
        {
           Patients = new List<Patient>();
        }

        [Key]
        public int DoctorID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; }

        public virtual Hospital Hospital { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3_rework.Models
{
    public class Doctor
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public Hospital hospital;

        [Display(Name ="Hospital")]
        public int hospitalID;
        public virtual ICollection<Patient> Patients { get; set; }

        public Doctor()
        {
            Patients = new List<Patient>();
        }
    }
}
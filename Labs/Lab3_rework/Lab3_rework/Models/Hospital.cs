using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3_rework.Models
{
    public class Hospital
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "HospitalName")]
        public string Name { get; set; }
        [Display(Name="HospitalAddress")]
        public string Address { get; set; }

        public string Image { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }

        public Hospital()
        {
            Doctors = new List<Doctor>();
        }
        
       

    }
}
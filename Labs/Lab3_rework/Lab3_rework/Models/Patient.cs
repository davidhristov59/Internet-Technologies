using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3_rework.Models
{
    public class Patient
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        [Required]
        [RegularExpression("^\\d{5}$", ErrorMessage = "The code must be 5 digits")]
        [Display(Name = "Код на пациентот")]
        public int patientCode { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    
        public Patient()
        {
            Doctors = new List<Doctor>();
        }
    }
}
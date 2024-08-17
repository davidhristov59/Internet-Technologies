using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class Patient
    {
        public Patient() {

            Doctors = new List<Doctor>();
        }

        [Key]
        public int PatientID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^\\d{5}$", ErrorMessage = "The patient's code must be 5 digits")]
        [Display(Name="Код на пациентот")]
        public int PatientCode { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public int Age { get; set; }
        public virtual Hospital hospital { get;set; }
        public virtual List<Doctor> Doctors { get; set; }
    }
}
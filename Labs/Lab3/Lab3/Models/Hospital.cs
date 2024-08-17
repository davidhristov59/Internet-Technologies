using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class Hospital
    {
        
        [Key]
        public int HospitalID { get; set; }

        [Required]
        public string Name { get; set; }
        public string Image { get; set; } //kako URL-se cuva
        public string Address { get; set; }
        public List<Doctor> Doctors { get; set; }
        
    }
}
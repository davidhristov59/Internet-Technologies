using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_MVC.Models
{
    public class Client
    {
        public int ID { get; set; }
        [Required]
        public string fullName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string MemberCart { get; set; }


    }
}
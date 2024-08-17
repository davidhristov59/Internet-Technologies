using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseExample2._5.Models
{
    public class Client
    {

        public Client()
        {
            movies = new List<Movie>();
        }
        
        [Key] // This designates ID as the primary key.
        public int ClientID { get; set; }
        [Required]
        [Range(1,99,ErrorMessage ="Age must be a positive number")]
        public int Age { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Telephone { get; set; }
        [Required]
        public string Address { get; set; }
        public bool isSubscribed { get; set; }

        public virtual ICollection<Movie> movies { get; set; }
    }
}
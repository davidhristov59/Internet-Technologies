using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseExample2.Models
{
    public class Client
    {

        public virtual ICollection<Movie> movies { get; set; } //virtual deka ke bide nekoja relacjija, nekoja megjutabela ke bide ovaa lista megju client i movie 

        public Client()
        {
            movies = new List<Movie>();
        }

        [Key] //ovaa promenliva ke e unique identifikator
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [Range(1, 99, ErrorMessage = "Age must be between 1 and 99")]
        public string Age { get; set; }
    }
}
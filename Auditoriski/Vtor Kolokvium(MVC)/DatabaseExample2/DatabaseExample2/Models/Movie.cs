using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseExample2.Models
{
    public class Movie
    {
        public virtual ICollection<Client> clients { get; set; }

        public Movie()
        {
           clients = new List<Client>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string MovieName { get; set; }
        [Required]
        public string DownloadURL { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Range(1, 5, ErrorMessage = "The value must be between 1 and 5")]
        public float Rating { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseExample2._5.Models
{
    public class Movie
    {

        public Movie()
        {
            clients = new List<Client>();
        }

        [Key]
        public int MovieID { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name= "Download URL")]
        public string DownloadUrl { get;set; }
        public float Rating { get; set; }
        [Display(Name="The image URL")]
        public string ImgUrl { get; set; }

        public virtual List<Client> clients { get; set; }
    }
}
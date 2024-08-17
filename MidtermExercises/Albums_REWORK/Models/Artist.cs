using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Albums_REWORK.Models
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }
        [Display(Name = "Artist Name")]
        [Required]
        public string Name { get; set; }
    }
}
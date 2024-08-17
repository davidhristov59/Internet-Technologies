using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AUD_MVC1.Models
{
    public class Movie
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string DownloadURL { get; set; }

        public string ImageUrl { get; set; }

        public float Rating { get; set; }

    }
}
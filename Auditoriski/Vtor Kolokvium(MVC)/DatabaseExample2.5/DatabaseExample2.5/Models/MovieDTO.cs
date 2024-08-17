using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseExample2._5.Models
{
    public class MovieDTO
    {
       
        public int MovieID { get; set; }
        public string Name { get; set; }
        public string DownloadUrl { get; set; }
        public float Rating { get; set; }
        public string ImgUrl { get; set; }
    }
}
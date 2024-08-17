using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Views_Example.Models
{
    public class Artist 
    {
        public int ArtistID { get; set; }
        public string Artist_Name { get; set; }

        public virtual List<Album> Albums { get; set; }

    }
}
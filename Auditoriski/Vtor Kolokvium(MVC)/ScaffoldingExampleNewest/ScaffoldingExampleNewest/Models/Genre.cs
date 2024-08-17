using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScaffoldingExampleNewest.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }
        public string Description { get; set; }

        public virtual List<Album> Albums { get; set; }
    }
}
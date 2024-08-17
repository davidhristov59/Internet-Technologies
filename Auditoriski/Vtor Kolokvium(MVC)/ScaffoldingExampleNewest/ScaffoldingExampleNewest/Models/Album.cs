using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScaffoldingExampleNewest.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        public int ArtistID { get; set; }

        public int GenreID { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public string AlbumArtUrl { get; set; }

        public virtual Artist Artist { get; }

        public virtual Genre Genre { get; set; }
    }
}
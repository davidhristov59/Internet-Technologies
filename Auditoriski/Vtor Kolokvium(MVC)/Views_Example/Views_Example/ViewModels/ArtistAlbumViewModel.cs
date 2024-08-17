using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Views_Example.Models;

namespace Views_Example.ViewModels
{
    public class ArtistAlbumViewModel
    {
        public Artist Artist { get; set; }

        public List<Album> albums { get; set; }

    }
}
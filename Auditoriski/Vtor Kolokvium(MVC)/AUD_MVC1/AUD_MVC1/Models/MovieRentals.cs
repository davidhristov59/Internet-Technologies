using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AUD_MVC1.Models
{
    public class MovieRentals //za koj film koi klienti go imaat iznajmeno
    {
        public Movie movie { get; set; }

        public List<Client> clients { get; set; }

        public MovieRentals() {
            clients = new List<Client>();
        }

    }
}
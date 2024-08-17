using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_MVC.Models
{
    public class MovieRental
    {
        public Movie RentedMovie { get; set; }
        public List<Client> clients { get; set; }

        public MovieRental()
        {
            clients = new List<Client>();
        }
    }
}
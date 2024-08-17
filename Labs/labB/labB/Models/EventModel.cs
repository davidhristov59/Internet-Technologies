using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace labB.Models
{
    public class EventModel
    {
        public int ID { get; set; }

        //[Required]
        public string Ime { get; set; }

        //[Required]
        //gr.B
        [StringLength (30, MinimumLength = 5, ErrorMessage = "Goleminata na lokacijata mora da bide od 5 do 30 karakteri")]
        public string Lokacija { get; set; }
    }
}
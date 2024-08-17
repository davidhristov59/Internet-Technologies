using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseExample2._5.Models
{
    public class AddRoleToModel
    {
        //dodadovme
        public string Email { get; set; }

        public List<string> Roles { get; set; }

        public string SelectedRole { get; set; }
    }
}
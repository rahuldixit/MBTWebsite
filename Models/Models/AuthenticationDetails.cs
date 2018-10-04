using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APICRUD.Models
{
    public class AuthenticationDetails
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string passwordSalt { get; set; }

        public AuthenticationDetails() { }
    }
}
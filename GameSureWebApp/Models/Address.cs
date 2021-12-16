using GameSureWebApp.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSureWebApp.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string Zipcode { get; set; }
        public GameSureWebAppUser GameSureWebAppUser { get; set; }

    }
}

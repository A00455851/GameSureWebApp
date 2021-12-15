using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameSureWebApp.Areas.Identity.Data;
using GameSureWebApp.Models;

namespace GameSureWebApp.Models.ViewModels
{
    public class UserForm
    {
       
        public String FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public int Phone { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public Province Province { get; set; }
        public Country Country { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}

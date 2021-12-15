using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GameSureWebApp.Areas.Identity.Data;
using GameSureWebApp.Models;

namespace GameSureWebApp.Models.ViewModels
{
    public class UserForm
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string EmailId { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public Province Province { get; set; }
        [Required]
        public Country Country { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Range(0,17)]
        public int CardNumber { get; set; }
        [Required]
        public string CardName { get; set; }
        [Required]
        public string CardType { get; set; }
        [Required]
        public DateTime CardExpiry { get; set; }
        [Range(0,4)]
        public int CardCvv { get; set; }


    }
}

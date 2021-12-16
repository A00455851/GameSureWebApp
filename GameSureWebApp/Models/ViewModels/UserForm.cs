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
        [Required(ErrorMessage ="First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage="Email Id is required")]
        public string EmailId { get; set; }
        [Required(ErrorMessage ="Phone number is required")]
        public int Phone { get; set; }
        [Required(ErrorMessage ="Address line 1 is required")]

        public string Addr1 { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$", ErrorMessage = "Please enter a valid address. ")]
        public string Addr2 { get; set; }

        [Required(ErrorMessage ="City is required")]
        public string City { get; set; }
        [Required(ErrorMessage ="Province is required")]
        public Province Province { get; set; }
        [Required(ErrorMessage ="Zip Code is required")]
        public string Zipcode { get; set; }
        [Required(ErrorMessage ="Country is required")]
        public Country Country { get; set; }
        [Required(ErrorMessage ="Start Date is required")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "End Date is required")]

        public DateTime EndDate { get; set; }
        [Required(ErrorMessage ="Card Number is required")]
        [StringLength(16,ErrorMessage ="Card length cannot exceed 16 digits")]
        [RegularExpression(@"^([0-9]{16})$",ErrorMessage ="Invalid card number format")]
        public string CardNumber { get; set; }
        [Required(ErrorMessage = "Card name not valid")]
        public string CardName { get; set; }
        [Required(ErrorMessage = "Card type is required")]
        public string CardType { get; set; }
        [Required(ErrorMessage = "Card Expiry date is required")]
        public DateTime CardExpiry { get; set; }
        [StringLength(3,ErrorMessage = "CVV cannot exceed 3 digits")]
        [RegularExpression(@"^([0-9]{16})$", ErrorMessage = "Invalid card CVV format")]
        public string CardCvv { get; set; }
        //[Required(ErrorMessage = "Equipment detail is required")]
        public string EquipmentDet { get; set; }


    }
}

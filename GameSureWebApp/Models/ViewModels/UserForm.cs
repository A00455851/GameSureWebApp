using System;
using System.ComponentModel.DataAnnotations;
using GameSureWebApp.Controllers;


namespace GameSureWebApp.Models.ViewModels
{
    public class UserForm
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage ="Please enter a valid first name - lowercase/Uppercase English Alphabets allowed. ")]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]\s+$", ErrorMessage = "Please enter a valid last name - lowercase/Uppercase English Alphabets allowed. ")]
        public string LastName { get; set; }
        [Required]
        [emailValidator(ErrorMessage ="Please enter a valid email.")]
        public string EmailId { get; set; }
        [Required]
        [StringLength(10)]
        [RegularExpression(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}", ErrorMessage = "Please enter a valid phone number. ")]
        public int Phone { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$", ErrorMessage = "Please enter a valid address. ")]
        public string Addr1 { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$", ErrorMessage = "Please enter a valid address. ")]
        public string Addr2 { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]\s+$", ErrorMessage = "Please enter a valid city name - lowercase/Uppercase English Alphabets allowed. ")]
        public string City { get; set; }
        [Required]
        public Province Province { get; set; }
        [Required]
        public Country Country { get; set; }
        [Required]
        [zipCodeValidator("Country")]
        public string ZipCode { get; set; }
        [Required]
        [RegularExpression(@"^([12] [0-9]|3[01])[- /.] (0[1-9]|1[012])[- /.] (19|20)\d\d$", ErrorMessage = "Please enter a date in MM-YYYY format.")]
        public DateTime StartDate { get; set; }
        [Required]
        [RegularExpression(@"^([12] [0-9]|3[01])[- /.] (0[1-9]|1[012])[- /.] (19|20)\d\d$", ErrorMessage = "Please enter a date in MM-YYYY format.")]
        [dateGreaterThan("StartDate")]
        public DateTime EndDate { get; set; }

    }
}

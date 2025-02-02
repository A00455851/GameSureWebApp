﻿using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GameSureWebApp.Areas.Identity.Data;
using GameSureWebApp.Controllers;
using GameSureWebApp.Models;


namespace GameSureWebApp.Models.ViewModels
{
    public class UserForm
    {
        [Required(ErrorMessage = "First Name is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please enter a valid first name - lowercase/Uppercase English Alphabets allowed. ")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please enter a valid last name - lowercase/Uppercase English Alphabets allowed. ")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email Id is required")]
        [emailValidator(ErrorMessage = "Please enter a valid email.")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Phone number is required in a valid format like (xxx)-xxx-xxxx")]
        [phoneValidator(ErrorMessage = "Please enter a valid phone number.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Address line 1 is required")]
        [RegularExpression(@"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$", ErrorMessage = "Please enter a valid address. ")]
        public string Addr1 { get; set; }

        //[RegularExpression(@"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$", ErrorMessage = "Please enter a valid address. ")]
        public string Addr2 { get; set; }

        [Required(ErrorMessage = "City is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please enter a valid city name - lowercase/Uppercase English Alphabets allowed. ")]
        public string City { get; set; }

        [Required(ErrorMessage = "Province is required")]
        public Province Province { get; set; }

        [Required(ErrorMessage = "Zip Code is required")]
        //[zipCodeValidator("Country")]
        [RegularExpression(@"^([ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9])$|^\d{5}(?:[-\s]\d{4})?$", ErrorMessage = "Please enter a valid postal code. ")]
        public string Zipcode { get; set; }

        [Required(ErrorMessage = "Country is required")]
        public Country Country { get; set; }

        [Required(ErrorMessage = "Start Date is required")]
        //[RegularExpression(@"^([12] [0-9]|3[01])[- /.] (0[1-9]|1[012])[- /.] (19|20)\d\d$", ErrorMessage = "Please enter a date in MM-YYYY format.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End Date is required")]
        //[RegularExpression(@"^([12] [0-9]|3[01])[- /.] (0[1-9]|1[012])[- /.] (19|20)\d\d$", ErrorMessage = "Please enter a date in MM-YYYY format.")]
        [dateGreaterThan("StartDate")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Card type is required")]

        public string CardType { get; set; }

        [Required(ErrorMessage = "Card Number is required")]
        [StringLength(16, ErrorMessage = "Card length cannot exceed 16 digits")]
        [cardValidator("CardType")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "Card name not valid")]
        [RegularExpression(@"^([a-zA-Z0-9]+|[a-zA-Z0-9]+\s{1}[a-zA-Z0-9]{1,}|[a-zA-Z0-9]+\s{1}[a-zA-Z0-9]{3,}\s{1}[a-zA-Z0-9]{1,})$", ErrorMessage = "Please enter a valid first name - lowercase/Uppercase English Alphabets allowed. ")]
        public string CardName { get; set; }

        [Required(ErrorMessage = "Card Expiry date is required")]
        //[RegularExpression(@"^((0[1-9]{1}[\/]{1}(201[6-9]{1}|202[0-9]{1}|203[0-1]{1}))|(1[0-2]{1}[\/]{1}(201[6-9]{1}|202[0-9]{1}|203[0-1]{1})))$", ErrorMessage = "Please enter date in MM/YYYY format.")]
        [RegularExpression(@"^((0[1-9]{1}[\/]{1}(201[6-9]{1}|202[0-9]{1}|203[0-1]{1}))|(1[0-2]{1}[\/]{1}(201[6-9]{1}|202[0-9]{1}|203[0-1]{1})))$", ErrorMessage = "Please enter a valid Expiry Date")]
        public string CardExpiry { get; set; }

        [StringLength(3, ErrorMessage = "CVV cannot exceed 3 digits")]
        [RegularExpression(@"^([0-9]{3})$", ErrorMessage = "Please enter a valid CVV")]
        public string CardCvv { get; set; }

        [Required(ErrorMessage = "Equipment detail is required")]
        public string EquipmentDet { get; set; }

        public string ProdPlan { get; set; }

        public string ProdPrice { get; set; }


    }
}

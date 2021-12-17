using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace GameSureWebApp.Controllers
{
    public class zipCodeValidator : ValidationAttribute
    {
        private Models.Country _countryPropertyName;
        public zipCodeValidator(Models.Country country)
        {
            _countryPropertyName = country;
        }

        public zipCodeValidator(string errorMessage) : base(errorMessage)
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //var propertyInfo = validationContext.ObjectType.GetProperty(_countryPropertyName.ToString());
            //var propertyValue = propertyInfo.GetValue(validationContext.ObjectInstance, null);
            if (value == null)
                return new ValidationResult("There is an error in zipCode.");
            string zipCode = value.ToString();
            if (true || _countryPropertyName == Models.Country.United_States)
            {
                if (string.IsNullOrWhiteSpace(zipCode))
                    return new ValidationResult("There is an error in zipCode."); ;
                var _usZipRegEx = @"^\d{5}(?:[-\s]\d{4})?$";
                var _caZipRegEx = @"^([ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9])$";
                if ((!Regex.Match(zipCode, _usZipRegEx).Success)|| (!Regex.Match(zipCode, _caZipRegEx).Success))
                {
                    return new ValidationResult("There is an error in zipCode.");
                }
                return ValidationResult.Success;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(zipCode))
                    return new ValidationResult("There is an error in zipCode."); ;
                var _caZipRegEx = @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$";
                if ((!Regex.Match(zipCode, _caZipRegEx).Success))
                {
                    return new ValidationResult("There is an error in zipCode.");
                }
                return ValidationResult.Success;
            }
        }
    }
}

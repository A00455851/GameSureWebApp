using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace GameSureWebApp.Controllers
{
    public class cardValidator : ValidationAttribute
    {
        private string _cardTypePropertyName;

        public cardValidator(string cardTypePropertyName)
        {
            _cardTypePropertyName = cardTypePropertyName;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value==null)
                return new ValidationResult("Invalid Value of card number.");

            var propertyInfo = validationContext.ObjectType.GetProperty(_cardTypePropertyName);
            var propertyValue = propertyInfo.GetValue(validationContext.ObjectInstance, null);

            string cardNumber = (string)value;
            string cardtype = (string)propertyValue;

            if (cardtype.Equals("Visa"))
            {
                var visaRegEx = @"^(?:4[0-9]{12}(?:[0-9]{3})?)$";          // Visa start with 4 size 16
                if ((!Regex.Match(cardNumber, visaRegEx).Success))
                {
                    return new ValidationResult("Invalid Value of Visa card number.");
                }
                return ValidationResult.Success;
            }
            else if(cardtype.Equals("Master"))
            {
                var masterCardRegEx = @"^(5[1-5][0-9]{14})$";              // MasterCard starts with 51-55 size 16
                if ((!Regex.Match(cardNumber, masterCardRegEx).Success))
                {
                    return new ValidationResult("Invalid Value of Master card number.");
                }
                return ValidationResult.Success;
            }
            else
            {
                var americanExpressRegEx = @"^(3[47][0-9]{13})$";          // American Express start with 34 or 37 size 15
                if ((!Regex.Match(cardNumber, americanExpressRegEx).Success))
                {
                    return new ValidationResult("Invalid Value of American Express card number.");
                }
                return new ValidationResult("Invalid Value of card number.");
            }
        }
    }
}

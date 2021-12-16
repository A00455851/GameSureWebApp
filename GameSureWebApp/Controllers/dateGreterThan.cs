using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GameSureWebApp.Controllers
{
    public class dateGreaterThan : ValidationAttribute
    {
        private string _startDatePropertyName;

        public dateGreaterThan(string startDatePropertyName)
        {
            _startDatePropertyName = startDatePropertyName;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var propertyInfo = validationContext.ObjectType.GetProperty(_startDatePropertyName);
            var propertyValue = propertyInfo.GetValue(validationContext.ObjectInstance, null);
            CultureInfo provider = CultureInfo.InvariantCulture;

            DateTime endDate = DateTime.ParseExact((string)value, "MM-yyyy", provider);
            DateTime startDate = DateTime.ParseExact((string)propertyValue, "MM-yyyy", provider);

            if (endDate > startDate)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("There is an error.");
            }
        }
    }
}

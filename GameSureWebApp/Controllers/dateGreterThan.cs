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

            DateTime endDate = (DateTime)value;// DateTime.ParseExact((string)value, "dd/MM/yyyy", provider);
            DateTime startDate = (DateTime)propertyValue;// DateTime.ParseExact((string)propertyValue, "dd/MM/yyyy", provider);

            if (endDate > startDate)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Start date cannot exceed End Date.");
            }
        }
    }
}

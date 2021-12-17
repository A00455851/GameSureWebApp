using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Globalization;

namespace GameSureWebApp.Controllers
{
    public class phoneValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;
            var inputPhoneNumber = value.ToString();

            if (string.IsNullOrWhiteSpace(inputPhoneNumber))
                return false;

            try
            {
                if (string.IsNullOrWhiteSpace(inputPhoneNumber))
                    return false;
                const string MatchPhonePattern = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
                ;
                var validPhoneNumber = true;
                if ((!Regex.Match(inputPhoneNumber, MatchPhonePattern).Success))
                {
                    validPhoneNumber = false;
                }
                return validPhoneNumber;
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }
        }
    }
}

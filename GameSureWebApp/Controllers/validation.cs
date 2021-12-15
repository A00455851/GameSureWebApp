using System;
using System.Text.RegularExpressions;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace GameSureWebApp.Controllers
{
    public class validation
    {
    /*
        isValidDateRange checks if checkout date is greater than checkin date and returns true if it is valid
    */
    public static bool isValidDateRange(DateTime checkin, DateTime checkout)
        {
            // DateTime date1 = new DateTime(2009, 8, 1, 0, 0, 0);
            // DateTime date2 = new DateTime(2009, 8, 1, 12, 0, 0);
            int result = DateTime.Compare(checkout, checkin);
            bool valCheck;

            if (result <= 0)
                 valCheck = false;//valCheck= "End date should exceed start date";
            else
                valCheck = true;//valCheck="Valid date"
            return valCheck;
        }

    /*
        isValidName checks if input name contains only alphabets with spaces allowed
        can be used for last name, first name, city, province/state, and credit card holder’s name
    */
    public static bool isValidName(String inputName)
        {
            if (string.IsNullOrWhiteSpace(inputName))
                return false;
            bool valCheck = Regex.IsMatch(inputName, @"^[a-zA-Z\s]+$");
            return valCheck;
        }

    /*
        IsUSZipCode checks if input string is a valid US zip code
    */    
    public static bool isUSZipCode(string zipCode)
        {
            if (string.IsNullOrWhiteSpace(zipCode))
                return false;
            var _usZipRegEx = @"^\d{5}(?:[-\s]\d{4})?$";
            var validZipCode = true;
            if ((!Regex.Match(zipCode, _usZipRegEx).Success))
            {
                validZipCode = false;
            }
            return validZipCode;

        }

    /*
        IsaCanadianZipCode checks if input string is a valid Canadian zip code
    */
    public static bool isaCanadianZipCode(string zipCode)
        {
            if (string.IsNullOrWhiteSpace(zipCode))
                return false;
            var _caZipRegEx = @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$";
            var validZipCode = true;
            if ((!Regex.Match(zipCode, _caZipRegEx).Success))
            {
                validZipCode = false;
            }
            return validZipCode;

        }    

    /*
        IsaCanadianZipCode checks if the selected country is USA or Canada,
        the phone number must be a valid US/Canadian phone number.
    */
    public static bool isUSorCanadaNumber(string inputPhoneNumber)
        {
            if (string.IsNullOrWhiteSpace(inputPhoneNumber))
                return false;
            const string MatchPhonePattern =@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
;
            var validPhoneNumber = true;
            if ((!Regex.Match(inputPhoneNumber, MatchPhonePattern).Success))
            {
                validPhoneNumber = false;
            }
            return validPhoneNumber;

        }
    /*
        isValidEmail checks if the email address is a valid Internet email address.
    */
    public static bool isValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    /*
        isValidCreditCard checks if the credit card is a valid Visa or MasterCard or American Express.
    */
    public static bool isValidCreditCard(string credCard)
        {
            if (string.IsNullOrWhiteSpace(credCard))
                return false;
            var visaRegEx = @"^(?:4[0-9]{12}(?:[0-9]{3})?)$";          // Visa start with 4 size 16
            var masterCardRegEx = @"^(5[1-5][0-9]{14})$";              // MasterCard starts with 51-55 size 16
            var americanExpressRegEx = @"^(3[47][0-9]{13})$";          // American Express start with 34 or 37 size 15
            var validCreditCard = true;
            if ((!Regex.Match(credCard, visaRegEx).Success) || (!Regex.Match(credCard, masterCardRegEx).Success) || (!Regex.Match(credCard, americanExpressRegEx).Success))
            {
                validCreditCard = false;
            }
            return validCreditCard;

        }
    // public static bool isRequiredFieldEntered(String textBox_text)
    // {
    //     if (String.IsNullOrEmpty(TextBox.Text))
    //     {
    //         MessageBox.Show("Enter Text Here.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Warning);
    //     }
    // }
    
    }
}
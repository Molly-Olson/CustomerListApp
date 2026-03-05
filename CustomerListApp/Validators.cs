using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomerListApp
{
    public class Validators
    {
        public static bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone)) || string.IsNullOrEmpty(phone))
                    {
                return false;
                
                };
            return true;
        }
        public static bool ContainsValue(string text)
        {
            if (string.IsNullOrWhiteSpace(text) || string.IsNullOrEmpty(text))
            {
                return false;
            };
            return true;
        }
        public static bool IsValidEmail(string email)
        {
            string pattern = @"^([a-zA-Z0-9._%-]+@[a-zA-Z0-9._]+\.[a-zA-Z]{2,6})*$";
            return Regex.IsMatch(email, pattern);
        }
    }
}

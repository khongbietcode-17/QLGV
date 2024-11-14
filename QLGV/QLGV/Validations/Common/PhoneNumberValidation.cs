using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace QLGV.Validations
{
    public class PhoneNumberValidation
    {
        private const string regex = @"0([0-9]{9})";
        public static bool Validate(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, regex);
        }
    }
}

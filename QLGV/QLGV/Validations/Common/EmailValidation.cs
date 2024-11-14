using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Validations
{
    public class EmailValidation
    {
        public static bool Validate(string emailAddress)
        {
            try
            {
                var email = new MailAddress(emailAddress);
                return email.Address == emailAddress;
            }
            catch
            {
                return false;
            }
        }
    }
}

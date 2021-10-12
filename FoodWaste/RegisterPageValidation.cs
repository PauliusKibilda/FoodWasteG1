using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace FoodWaste
{
   
    class RegisterPageValidation
    {


        private static string errorMessage;
        public static string getErrorMessage ()
        { 
            return errorMessage; 
        }

    public static bool ValidateUserName(string username)
     {
            string usernameTrimmed = Regex.Replace(username, @"\s", "");

            if (String.IsNullOrWhiteSpace(username))
            {
                errorMessage = "Username Can Not Be Empty";
                return false;
            }
            else if (username.Length < 4)
            {
                errorMessage = "Username Must Have At Least 4 Characters";
                return false;
            }

            else if (usernameTrimmed.Length != username.Length)
            {
                errorMessage = "Invalid Characters In Username";
                return false;
            }
            return true;
        }

        public static bool ValidateEmailAddress(string email)
        {
                try
                {
                    new System.Net.Mail.MailAddress(email);
                }
                catch (ArgumentNullException)
                {
                    errorMessage = "Email Address Can Not Be Empty";
                    return false;
                }
                catch (ArgumentException)
                {
                    errorMessage = "Email Address Can Not Be Empty";
                    return false;
                }
                catch (FormatException)
                {
                    errorMessage = "Invalid Format Of Email Address";
                    return false;
                }

                return true;
        }

        public static bool ValidatePassword(string password)
        {
            if (String.IsNullOrWhiteSpace(password))
            {
                errorMessage = "Password Can Not Be Empty";
                return false;
            }
            else
            {
                var hasNumber = new Regex(@"[0-9]+");
                var hasUpperChar = new Regex(@"[A-Z]+");
                var hasMinimum8Chars = new Regex(@".{8,}");
                bool isValidated;

                if (!(isValidated = hasMinimum8Chars.IsMatch(password)))
                {
                    errorMessage = "Password Should Contain 8 Characters";
                    return false;

                }
                else if (!(isValidated = hasUpperChar.IsMatch(password)))
                {
                    errorMessage = "Password Should Contain 1 Upper Case Letter";
                    return false;

                }
                else if (!(isValidated = hasNumber.IsMatch(password)))
                {
                    errorMessage = "Password Should Contain One Number";
                    return false;

                }

                return true;

            }

        }
        public static bool IsPasswordSame(string firstPassword, string secondPassword)
        {
            if(!firstPassword.Equals(secondPassword))
            {
                errorMessage = "Passwords Do Not Match";
                return false;
            }

            return true;
        }
    }
    
}

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
using System.IO;

namespace FoodWaste
{
    public static class RegisterPageValidation
    {
        private static string errorMessage;
        public static string GetErrorMessage()
        {
            return errorMessage;
        }
        public static bool IsValidUsername(this string username)
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
            else
            {
                List<User> users = FileManager.GetUsersFromFile();
                foreach (User oneUser in users)
                {
                    if (oneUser.UserName.Equals(username))
                    {
                        errorMessage = "This Username Already Exists";
                        return false;
                    }
                }
                return true;
            }
        }

        public static bool IsValidEmailAddress(this string email)
        {
            try
            {
                new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                errorMessage = "Invalid Format Of Email Address";
                return false;
            }
            return true;
        }
        public static bool IsValidPassword(this string password)
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
                if (!(hasMinimum8Chars.IsMatch(password)))
                {
                    errorMessage = "Password Must Contain 8 Characters";
                    return false;
                }
                else if (!(hasUpperChar.IsMatch(password)))
                {
                    errorMessage = "Password Must Contain 1 Upper Case Letter";
                    return false;
                }
                else if (!(hasNumber.IsMatch(password)))
                {
                    errorMessage = "Password Must Contain One Number";
                    return false;
                }
                return true;
            }
        }
        public static bool IsPasswordSame(string firstPassword, string secondPassword)
        {
            if (!firstPassword.Equals(secondPassword))
            {
                errorMessage = "Passwords Do Not Match";
                return false;
            }
            return true;
        }
    }
}
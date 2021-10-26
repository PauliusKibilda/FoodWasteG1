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
        private static readonly List<User> users = FileManager.GetUsersFromFile();
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
                return IsUsernameOrEmailUnique(username);
            }
        }
        public static bool IsValidEmailAddress(this string email)
        {
            try
            {
                new MailAddress(email);
            }
            catch
            {
                errorMessage = "Invalid Format Of Email Address";
                return false;
            }
            return IsUsernameOrEmailUnique(email);
        }
        public static bool IsUsernameOrEmailUnique(string parametre)
        {
            foreach (User oneUser in users)
            {
                if (oneUser.Email.ToLower() == parametre.ToLower())
                {
                    errorMessage = "This Email Already Exists";
                    return false;
                }
                if (oneUser.UserName.ToLower() == parametre.ToLower())
                {
                    errorMessage = "This Username Already Exists";
                    return false;
                }
            }
            return true;
        }
        public static bool IsValidPhoneNumber(this string phone)
        {
            if (string.IsNullOrEmpty(phone))
            {
                return true;
            }
            if (phone[0] == '+')
            {
                phone = phone.Remove(0, 1);
            }
            if (!(phone.Length == 11 || phone.Length == 9) || !IsDigit(phone))
            {
                errorMessage = "Invalid Phone Number";
                return false;
            }
            else if (!(phone.StartsWith("370") || phone.StartsWith("86"))) 
            {
                errorMessage = "Phone Number Should Be Lithuanian";
                return false;
            }
            return true;
        }
        static bool IsDigit(String input)
        {
            return Regex.IsMatch(input, @"^\d+$");
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
                var hasLowerChar = new Regex(@"[a-z]+");
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
                else if (!hasLowerChar.IsMatch(password))
                {
                    errorMessage = "Password Must Contain At Least One Lower Case Letter";
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
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
            else
            {
                string text = System.IO.File.ReadAllText(@"C:\Users\Mindaugas\source\repos\2.0\FoodWaste\Accounts.txt");     
                string[] values = text.Split(new char[] { ',', '\n' });
                for (int i = 0; i < values.Length; i++)
                {
                    if (values[i].Equals(username))
                    {
                        errorMessage = "This Username Already Exists";
                        return false;
                    }
                }     
                return true;
            }
    }
    public static bool ValidateEmailAddress(string email)
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
                errorMessage = "Password Must Contain 8 Characters";
                return false;
            }
            else if (!(isValidated = hasUpperChar.IsMatch(password)))
            {
                errorMessage = "Password Must Contain 1 Upper Case Letter";
                return false;
            }
            else if (!(isValidated = hasNumber.IsMatch(password)))
            {
                errorMessage = "Password Must Contain One Number";
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FoodWaste
{

    public class User
    {
        public string UserName { get; set; }
        public int Id {get ; set ; } 
        public String Email {get ; set ; }
        public String Mobile {get ; set ; }
        public String Password {get ; set ; } 
        public String Role {get ; set ; } 
        public String Status {get ; set ; }

        private static string UsersFile = "Users.txt";
        public static void RegisterUser(String pUserName, String pPassword, String pEmail, String optionalNumber = "no number provided")
        {
            StreamWriter sw = new StreamWriter(UsersFile);
            sw.Write(pUserName);
            sw.Write(pPassword);
            sw.Write(pEmail);
            sw.Write(optionalNumber);
            sw.Close();
        }
    }
}
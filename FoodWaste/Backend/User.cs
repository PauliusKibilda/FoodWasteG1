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
        public string Email {get ; set ; }
        public string Mobile {get ; set ; }
        public string Password {get ; set ; } 
        public string Role {get ; set ; } 
        public string Status {get ; set ; }

        public User(string UserName, string Email, string Password, string Role, string Mobile = "")
        {
            this.UserName = UserName;
            this.Email = Email;
            this.Password = Password;
            this.Mobile = Mobile;
            this.Role = Role;
        }
    }
}
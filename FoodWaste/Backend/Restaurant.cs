using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWaste
{
    public class Restaurant
    {
        public string RestaurantName { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; } 

        public string UserName { get; set; }

        public Restaurant(string RestaurantName, string PhoneNumber, string Adress, string UserName) 
        {
            this.RestaurantName = RestaurantName;
            this.PhoneNumber = PhoneNumber;
            this.Adress = Adress;
            this.UserName = UserName;
        }
    }
}

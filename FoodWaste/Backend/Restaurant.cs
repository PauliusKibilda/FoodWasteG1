using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWaste
{
    class Restaurant
    {
        public string Username { get; set; }
        public string RestaurantName { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; } 

        public Restaurant(string Username, string RestaurantName, string PhoneNumber, string Adress) 
        {
            this.Username = Username;
            this.RestaurantName = RestaurantName;
            this.PhoneNumber = PhoneNumber;
            this.Adress = Adress;
        }
    }
}

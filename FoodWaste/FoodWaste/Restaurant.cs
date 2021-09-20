using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWaste
{
    class Restaurant
    {
        public string RestaurantName;
        public string Adress;
        public string PhoneNumber;

        public void SetRestaurant(string pName, string pAdress, string pNumber) {
            RestaurantName = pName;
            Adress = pAdress;
            PhoneNumber = pNumber;
        }

        public string GetRestaurant()
        {
            return RestaurantName;
        }
    }
}

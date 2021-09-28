using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWaste
{
    class FileManager
    {
        private static string RestaurantsFile = "Restaurants.txt";
        private static string ProductsFile = "Products.txt";
        private static string UsersFile = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName + "\\" + "Users.txt";
        public FileManager()
        {
            RestaurantsFile = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName + "\\" + RestaurantsFile;
            ProductsFile = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName + "\\" + ProductsFile;
        }
        public List<Product> GetProductsFromFile() {
            List<Product> products = new List<Product>();
            using (StreamReader reader = new StreamReader(ProductsFile))
            {
                string[] parts = new string[3];
                while (!reader.EndOfStream) 
                {
                    parts = reader.ReadLine().Split(' ');
                    DateTime date;
                    if (DateTime.TryParseExact(parts[1], "yyyy-MM-dd", null, DateTimeStyles.None, out date))
                    {
                        products.Add(new Product(parts[0], date, (Product.ProductState)Enum.Parse(typeof(Product.ProductState), parts[2])));
                    }
                }
            }
            return products;
        }
        public List<Restaurant> GetRestaurantsFromFile()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            using (StreamReader reader = new StreamReader(RestaurantsFile))
            {
                string[] parts = new string[3];
                while (!reader.EndOfStream)
                {
                    parts = reader.ReadLine().Split(' ');
                    restaurants.Add(new Restaurant(parts[0], parts[1], parts[2]));
                }
            }
            return restaurants;
       }

        public static void RegisterUser(String pUserName, String pPassword, String pEmail, String optionalMobile = "no number provided")
        {
            using (StreamWriter sw = new StreamWriter(UsersFile))
            {
                sw.Write(pUserName);
                sw.Write(' ');
                sw.Write(pPassword);
                sw.Write(' ');
                sw.Write(pEmail);
                sw.Write(' ');
                sw.Write(optionalMobile);
                sw.Write('\n');
            }
        }
        public static void InsertProduct(String Name, DateTime ExpiryDate, Enum State)
        {
            using (StreamWriter sw = new StreamWriter(ProductsFile))
            {
                sw.Write(Name);
                sw.Write(' ');
                sw.Write(ExpiryDate);
                sw.Write(' ');
                sw.Write(State);
                sw.Write('\n');
            }
        }
        public static void InsertRestaurants(String RestaurantName, String PhoneNumber, String Adress)
        {
            using (StreamWriter sw = new StreamWriter(RestaurantsFile))
            {
                sw.Write(RestaurantName);
                sw.Write(' ');
                sw.Write(PhoneNumber);
                sw.Write(' ');
                sw.Write(Adress);
                sw.Write('\n');
            }
        }
    }
}

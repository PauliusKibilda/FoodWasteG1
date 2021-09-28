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
        private string RestaurantsFile = "Restaurants.txt";
        private string ProductsFile = "Products.txt";
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
    }
}

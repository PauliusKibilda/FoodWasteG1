using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWaste
{
    static class FileManager
    {
        private static string RestaurantsFile = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName + "\\" + "Restaurants.txt";
        private static string ProductsFile = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName + "\\" + "Products.txt";
        private static string AccountsFile = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName + "\\" + "Accounts.txt";

        public static List<Product> GetProductsFromFile()
        {
            List<Product> products = new List<Product>();
            using (StreamReader reader = new StreamReader(ProductsFile))
            {
                string[] parts = new string[4];
                while (!reader.EndOfStream)
                {
                    parts = reader.ReadLine().Split(',');
                    DateTime date;
                    if (DateTime.TryParseExact(parts[1], "yyyy-MM-dd", null, DateTimeStyles.None, out date))
                    {
                        products.Add(new Product(parts[0], date, (Product.ProductState)Enum.Parse(typeof(Product.ProductState), parts[2]), parts[3]));
                    }
                }
            }
            return products;
        }
        public static List<Restaurant> GetRestaurantsFromFile()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            using (StreamReader reader = new StreamReader(RestaurantsFile))
            {
                string[] parts = new string[3];
                while (!reader.EndOfStream)
                {
                    parts = reader.ReadLine().Split(',');
                    restaurants.Add(new Restaurant(parts[0], parts[1], parts[2]));
                }
            }
            return restaurants;
        }

        public static List<User> GetUsersFromFile()
        {
            List<User> users = new List<User>();
            using (StreamReader reader = new StreamReader(AccountsFile))
            {
                string[] parts = new string[5];
                while (!reader.EndOfStream)
                {
                    parts = reader.ReadLine().Split(',');
                    users.Add(new User(parts[0], parts[1], parts[2], parts[3], parts[4]));
                }
            }
            return users;
        }

        public static void InsertUser(string pUserName, string pEmail, string pPassword, string Role, string optionalMobile = "")
        {
            using (StreamWriter sw = new StreamWriter(AccountsFile, true))
            {
                sw.Write(pUserName);
                sw.Write(',');
                sw.Write(pEmail);
                sw.Write(',');
                sw.Write(pPassword);
                sw.Write(',');
                sw.Write(Role);
                sw.Write(',');
                sw.Write(optionalMobile);
                sw.Write('\n');
            }
        }
        public static void InsertProducts(List<Product> productList)
        {
            using (StreamWriter sw = new StreamWriter(ProductsFile))
            {
                foreach (Product product in productList)
                {
                    sw.Write(product.Name);
                    sw.Write(',');
                    sw.Write(String.Format("{0:yyyy-MM-dd}", product.ExpiryDate));
                    sw.Write(',');
                    sw.Write(product.State);
                    sw.Write(',');
                    sw.Write(product.ReservedUsername);
                    sw.Write('\n');
                }
            }
        }
        public static void InsertRestaurant(string RestaurantName, string PhoneNumber, string Adress)
        {
            using (StreamWriter sw = new StreamWriter(RestaurantsFile, true))
            {
                sw.Write(RestaurantName);
                sw.Write(',');
                sw.Write(PhoneNumber);
                sw.Write(',');
                sw.Write(Adress);
                sw.Write('\n');
            }
        }
        public static void InsertChangedUser(User pUser)
        {
            List<User> userList = GetUsersFromFile();

            using (StreamWriter sw = new StreamWriter(AccountsFile))
            {
                foreach (User user in userList)
                {
                    if (user.UserName.Equals(pUser.UserName))
                    {
                        sw.Write(pUser.UserName);
                        sw.Write(',');
                        sw.Write(pUser.Email);
                        sw.Write(',');
                        sw.Write(pUser.Password);
                        sw.Write(',');
                        sw.Write(pUser.Role);
                        sw.Write(',');
                        sw.Write(pUser.Mobile);
                        sw.Write('\n');
                    }
                    else
                    {
                        sw.Write(user.UserName);
                        sw.Write(',');
                        sw.Write(user.Email);
                        sw.Write(',');
                        sw.Write(user.Password);
                        sw.Write(',');
                        sw.Write(user.Role);
                        sw.Write(',');
                        sw.Write(user.Mobile);
                        sw.Write('\n');
                    }
                }
            }
        }
    }
}

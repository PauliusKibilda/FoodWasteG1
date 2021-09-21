using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWaste
{
    class Reader
    {
        private string RestaurantsFile = "Restaurants.txt";
        private string ProductsFile = "Products.txt";
        public Reader() 
        {
            RestaurantsFile = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName + "\\" + RestaurantsFile;
            ProductsFile = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName + "\\" + ProductsFile;
        }
        public List<Product> getProductsFromFile() {
            List<Product> products = new List<Product>();
            FoodWaste.Product.ProductState state;
            using (StreamReader reader = new StreamReader(ProductsFile))
            {
                string[] parts = new string[3];
                while (!reader.EndOfStream) 
                {
                    parts = reader.ReadLine().Split(' ');
                    products.Add(new Product(parts[0], parts[1], (Product.ProductState)Enum.Parse(typeof(Product.ProductState), parts[2])));
                }
            }
            return products;
        }
        public List<Restaurant> getRestaurantsFromFile()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            FoodWaste.Product.ProductState state;
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
    }
}

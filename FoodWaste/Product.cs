using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWaste
{
    class Product
    {
        public enum ProductState
        {
            expired,
            taken,
            reserved,
            listed
        }
        public string Name { get; set; }
        public string ExpiryDate { get; set; }//datetime nudatime
        public ProductState State { get; set; }

        public Product(string ProductName, string ExpiryDate) {
            this.Name = ProductName;
            this.ExpiryDate = ExpiryDate;
            this.State = ProductState.listed;
        }
        public Product(string ProductName, string ExpiryDate, ProductState State)
        {
            this.Name = ProductName;
            this.ExpiryDate = ExpiryDate;
            this.State = State;
        }
    }
}

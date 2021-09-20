using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWaste
{
    class Product
    {
        public string ProductName { get; set; }
        public int ExpiryDate { get; set; }
        public enum ProductState
        {
            expired,
            taken,
            reserved,
            listed
        }
        public ProductState State { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWaste
{
    class Product
    {
        public string ProductName;
        public enum ProductState
        {
            expired,
            taken,
            reserved,
            listed
        }
        public ProductState State {get; set;}
        public void SetProduct(string pName, ProductState pState)
        {
            
            ProductName = pName;
            State = pState;
        }

        public string GetProduct()
        {
            return ProductName;
        }
    }
}

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
            Expired,
            Taken,
            Reserved,
            Listed
        }
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }
        public ProductState State { get; set; }
        public string ReservedUsername { get; set; }
        public Product(string productName, DateTime expiryDate)
        {
            this.Name = productName;
            this.ExpiryDate = expiryDate;
            this.State = ProductState.Listed;
            this.ReservedUsername = "";
        }
        public Product(string productName, DateTime expiryDate, ProductState state)
        {
            this.Name = productName;
            this.ExpiryDate = expiryDate;
            this.State = state;
            this.ReservedUsername = "";
        }
        public Product(string productName, DateTime expiryDate, ProductState state, string username)
        {
            this.Name = productName;
            this.ExpiryDate = expiryDate;
            this.State = state;
            this.ReservedUsername = username;
        }
    }
}

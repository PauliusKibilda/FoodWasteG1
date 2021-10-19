using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWaste
{
    class ProductComparer : IComparer <Product>
    {
        public enum SortBy
        {
            Name,
            ExpiryDate,
            State
        }

        private SortBy compareField = SortBy.Name;

        int IComparer<Product>.Compare(Product x, Product y)
        {
            switch (compareField)
            {
                case SortBy.Name:
                    return x.Name.CompareTo(y.Name);
                    break;
                case SortBy.ExpiryDate:
                    return x.ExpiryDate.CompareTo(y.ExpiryDate);
                    break;
                case SortBy.State:
                    return x.State.CompareTo(y.State);
                    break;
                default:
                    break;
            }
            return x.Name.CompareTo(y.Name);
        }
    }
}

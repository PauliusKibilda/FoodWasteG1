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
            State,
            User,
            Restaurant
        }

        private SortBy compareField;
        private SortKey sortKey;

        public ProductComparer(SortKey sortKey)
        {
            compareField = GetColumnType(sortKey.columnIndex);
            this.sortKey.columnIndex = sortKey.columnIndex;
            this.sortKey.order = sortKey.order;
        }

        int IComparer<Product>.Compare(Product x, Product y)
        {
            if (sortKey.order == Order.desc)
            {
                Product temp = x;
                x = y;
                y = temp;
            }
            switch (compareField)
            {
                case SortBy.Name:
                    return x.Name.CompareTo(y.Name);
                case SortBy.ExpiryDate:
                    return x.ExpiryDate.CompareTo(y.ExpiryDate);
                case SortBy.State:
                    return x.State.CompareTo(y.State);
                case SortBy.User:
                    return x.ReservedUsername.CompareTo(y.ReservedUsername);
                case SortBy.Restaurant:
                    return x.RestaurantName.CompareTo(y.RestaurantName);
                default:
                    break;
            }
            return x.Name.CompareTo(y.Name);
        }

        private SortBy GetColumnType(int columnIndex)
        {
            switch (columnIndex)
            {
                case 0:
                    return SortBy.Name;
                case 1:
                    return SortBy.ExpiryDate;
                case 2:
                    return SortBy.State;
                case 3:
                    return SortBy.User;
                case 4:
                    return SortBy.Restaurant;
                default:
                    return SortBy.Name;
            }
        }
    }
}

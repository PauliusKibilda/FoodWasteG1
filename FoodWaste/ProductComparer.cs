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
                default:
                    return SortBy.Name;
            }
        }
    }
}

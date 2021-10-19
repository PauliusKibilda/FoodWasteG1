using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWaste
{
    class ProductList : IEnumerable<Product>
    {
        private List<Product> productList = new List<Product>();

        public ProductList()
        {
            productList = new List<Product>();
        }

        public ProductList(List<Product> list)
        {
            productList = list;
        }

        public Product this[int i]
        {
            get 
            {
                if (i < 0 && i >= productList.Count)
                    return null;
                return productList[i];
            }
            set { productList[i] = value; }
        }

        public static implicit operator ProductList(List<Product> list)
        {
            return new ProductList(list);
        }

        public void Sort(IComparer<Product> c)
        {
            productList.Sort(c);
        }

        public IEnumerator<Product> GetEnumerator()
        {
            return ((IEnumerable<Product>)productList).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)productList).GetEnumerator();
        }

        public List<Product> List { get => productList; set => productList = value; }
    }
}

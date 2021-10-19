using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWaste
{
    enum Order 
    {
        asc,
        desc
    }
    struct SortKey
    {
        public int columnIndex;
        public Order order;
    }
}

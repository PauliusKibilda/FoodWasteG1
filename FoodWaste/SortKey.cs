using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWaste
{
    enum OrderBy 
    {
        asc,
        desc
    }
    struct SortKey
    {
        public int type;
        public OrderBy order;
    }
}

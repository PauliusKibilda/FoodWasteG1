using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWaste
{
    class ObjectList<T> : IEnumerable<T>
    {
        private List<T> objectList = new List<T>();

        public ObjectList()
        {
            objectList = new List<T>();
        }

        public ObjectList(List<T> list)
        {
            objectList = list;
        }

        public T this[int i]
        {
            get
            {
                if (i < 0 && i >= objectList.Count)
                    return default(T);
                return objectList[i];
            }
            set { objectList[i] = value; }
        }

        public static implicit operator ObjectList<T>(List<T> list)
        {
            return new ObjectList<T>(list);
        }

        public void Sort(IComparer<T> c)
        {
            objectList.Sort(c);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)objectList).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)objectList).GetEnumerator();
        }

        public List<T> List { get => objectList; set => objectList = value; }
    }
}
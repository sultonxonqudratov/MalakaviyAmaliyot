using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Topshiriq
{
    public class OrderedList<T> : IEnumerable<T>
    {
        private List<T> list = new List<T>();
        public void Add(T item)
        {
            list.Add(item);
        }
        public T GetAndRemove()
        {
            var val = list.FirstOrDefault();
            if(val != null)
            {
                list.Remove(val);
            }
            return val;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }  
        
        public void Clear()
        {
            list.Clear();
        }

        public static OrderedList<T> Create()
        {
            return new OrderedList<T>();
        }

        private OrderedList()
        {
        }
    }
}

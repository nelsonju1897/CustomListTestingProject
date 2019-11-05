using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        //member variables
        private T[] items;
        private int capacity;
        private int count;

        public int Count
        {
            get
            {
                return count;
            }
        }

        //constructor
        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];
        }

        //member methods

        public void Add(T item)
        {
            items[0] = item;
        }


    }
}

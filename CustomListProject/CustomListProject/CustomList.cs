using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> :IEnumerable 

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

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public T this[int i]
        {
            get
            {
                return items[i];
            }
            set
            {
                items[i] = value;
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
            T[] tempArray;
            if (count == capacity)
            {
                capacity *= 2;
                tempArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = items[i];
                }
                items = tempArray;
            }
            items[count] = item;
            count++;
        }

        public void Remove(T item)
        {
            T[] tempArray;
            tempArray = new T[capacity];
            for (int i = 0, j = 0; i < count; i++, j++)
            {
                if (item.Equals(items[i]))
                {
                    j--;
                }
                else
                {
                    tempArray[j] = items[i];
                }
            }
            items = tempArray;
            count--;

        }

        public override string ToString()
        {
            string listString ="";
            for (int i = 0; i < Count; i++)
            {
                listString += items[i].ToString();
            }
            return listString;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < items.Length; i++)
            {
                yield return items[i];
            }
        }

        public static CustomList<T> operator +(CustomList<T> one, CustomList<T> two)
        {
            CustomList<T> customListAdded = new CustomList<T>();
            for (int i = 0; i < one.Count; i++)
            {
                
                customListAdded.Add(one[i]);
            }
            for (int i = 0; i < two.Count; i++)
            {
                customListAdded.Add(two[i]);
            }
            customListAdded.ToString();
            return customListAdded;
        }

        public static CustomList<T> operator -(CustomList<T> one, CustomList<T> two)
        {
            CustomList<T> customListSubtract = new CustomList<T>();            
            for (int i = 0, j = 0, k = 0; i < one.Count; i++)
            {
                if (one[i].Equals(two[j]))
                {
                    two.Remove(one[i]);
                }
                else
                {
                    customListSubtract[k] = one[i];
                    customListSubtract.count++;
                    k++;
                }
            }
            customListSubtract.ToString();
            return customListSubtract;
        }
    }
}

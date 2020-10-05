using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable<T>
    {
        //Member Variables
        int count;
        int capacity;

        private T[] _items;

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Index Out of Range");
                }
                
                return _items[index];
            }
            set
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException("Index Out of Range");
                _items[index] = value;

            }
        }
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

       public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _items[i];
            }
        }

        //Constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;

            _items = new T[capacity];
        }

        //Methods
        public void Add(T item)
        {
            if(count < capacity)
            {
                _items[count] = item;
                count++;
            }
            else
            {
                T[] tempItems = new T[capacity *= 2];
                for (int i = 0; i < count; i++)
                {
                    tempItems[i] = _items[i];
                }

                _items = tempItems;
                _items[count] = item;
                count++;
            }
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].Equals(item))
                {
                    int index;
                    for (index = i; index < (_items.Length - 1); index++)
                    {
                        _items[index] = _items[index + 1];
                    }
                    _items[count - 1] = default(T);
                    count--;
                    return true;
                }
            }
            return false;
          
        }

        public override string ToString()
        {
            string result = null;
            for (int i = 0; i < count; i++)
            {
               result += _items[i].ToString();
            }

            return result;
        }

        public static CustomList<T> operator +(CustomList<T> customList1, CustomList<T> customList2)
        {
            CustomList<T> customList3 = new CustomList<T>();

            for (int i = 0; i < customList1.Count; i++)
            {
                customList3.Add(customList1[i]);
            }

            for (int i = 0; i < customList2.Count; i++)
            {
                customList3.Add(customList2[i]);
            }

            return customList3;
        }

        public static CustomList<T> operator -(CustomList<T> c1, CustomList<T> c2)
        {
            CustomList<T> customList3 = new CustomList<T>();
            CustomList<T> tempList = new CustomList<T>();
            tempList = c1;

            foreach(T item in c2)
            {
                for (int i = 0; i < c1.Count; i++)
                {
                    if(c1[i].Equals(item))
                    {
                        tempList.Remove(item);
                        break;
                    }
                }
            }
            customList3 = tempList;
            return customList3;
        }

        public CustomList<T> ZipperMerge(CustomList<T> customList1, CustomList<T> customList2)
        {
            CustomList<T> customList3 = new CustomList<T>();
            int i1 = customList1.Count;
            int i2 = customList2.Count;
            int i3 = Math.Max(i1, i2);

            for (int i = 0; i < i3; i++)
            {
                while(i < i1)
                {
                    customList3.Add(customList1[i]);
                    break;
                }
                while (i < i2)
                {
                    customList3.Add(customList2[i]);
                    break;
                }
            }
            return customList3;
        }

        public CustomList<T> Sort()
        {
            T temp;
            for (int j = 0; j < Count - 2; ++) {
                for (int i = 0; i < Count - 2; i++)
                {
                    if(_items[i] > _items[i + 1])
                    {
                        temp = _items[i + 1];
                        _items[i + 1] = _items[i];
                        _items[i] = temp;
                    }
                }

            }


            return result;
        }

    } 
}

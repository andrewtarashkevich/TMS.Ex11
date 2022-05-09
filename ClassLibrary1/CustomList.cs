using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class CustomList<T> : IList<T>
    {        
        T[] customList;
        public CustomList()
        {            
            customList = new T[1];
        }
        public T this[int index] 
        {
            get
            {
                if (index <= customList.Length && index >= 0)
                    return customList[index];
                else
                    throw new IndexOutOfRangeException("Index out of CustomList");                     
            }
            set
            {
                customList[index-1] = value;
            }
        }        
        public int Count
        {
            get
            {
                return customList.Length;
            }            
        }

        //public int Capasity
        //{
        //    get
        //    {
        //        return customList.;
        //    }
        //    set 
        //    {

        //    }
        //}

        public bool IsReadOnly
        {
            get
            {
                return customList.IsReadOnly;
            }
        }
        
        public void Add(T item)
        {
            T[] newCustomList = new T[customList.Length+1];
            customList.CopyTo(newCustomList, 0);
            newCustomList[customList.Length] = item;
            customList = newCustomList;
        }

        public void Clear()
        {
            for (int i = 0; i < customList.Length; i++)
            {
                customList[i] = default(T);
            }
        }

        public bool Contains(T item)
        {
            if (item == null)
                return false;
            else
            {
                for (int i = 0; i < customList.Length; i++)
                {
                    if (customList[i].Equals(item))
                        return true;                    
                }
                return false;
            }

        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            customList.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)customList.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            if (item == null)
                return -1;
            else
            {
                for (int i = 0; i < customList.Length; i++)
                {
                    if (customList[i].Equals(item))
                        return i;                    
                }
                return -1;
            }
        }

        public void Insert(int index, T item)
        {
            T[] newCustomList = new T[customList.Length + 1];
            for (int i = 0; i < index; i++)
            {
                newCustomList[i] = customList[i];
            }
            newCustomList[index] = item;
            for (int i = index + 1; i < customList.Length; i++)
            {
                newCustomList[i] = customList[i+1];
            }
            customList = newCustomList;
        }
       

        public void RemoveAt(int index)
        {
            if (index <= customList.Length && index >= 0)
            {
                T[] newCustomList = new T[customList.Length - 1];                               
                for (int i = 0; i < index; i++)
                {
                    newCustomList[i] = customList[i];
                }
                for (int i = index+1; i < customList.Length; i++)
                {
                    newCustomList[i-1] = customList[i];
                }
                customList = newCustomList;
            }
            else
                throw new IndexOutOfRangeException("Index out of CustomList");
        }
        public bool Remove(T item)
        {
            if (item == null)
                return false;
            else
            {
                for (int i = 0; i < customList.Length; i++)
                {
                    if (customList[i].Equals(item))
                        return false;                   
                }
                return false;
            }                
        }       
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task_3._2
{
    internal class DynamicArray<T> : IEnumerable, IEnumerable<T>
    {
        public DynamicArray()
        {
            Capacity = 8;
            Arr = new T[Capacity];
        }

        public DynamicArray(int capacity)
        {
            if (capacity < 0)
            {
                throw new System.ArgumentException("You cannot create an array from a negative number of elements");
            }

            this.Capacity = capacity;
            Arr = new T[capacity];
        }

        public DynamicArray(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new System.ArgumentException("You can't create a collection that doesn't exist");
            }

            int count = collection.Count();
            Arr = new T[count];
            int k = 0;
            foreach (var i in collection)
            {
                Arr[k] = i;
                k++;
            }
        }

        public void Add(T item)
        {
            if (Length == Capacity)
            {
                Capacity *= 2;
            }

            Arr[Length++] = item;
        }


        public void AddRange(IEnumerable<T> ts)
        {
            if (ts == null)
            {
                throw new System.ArgumentException("This collection is not exist");
            }

            int count = ts.Count();
            while (Length + count > Capacity)
            {
                Capacity *= 2;
            }
            int k = Length;
            foreach (var i in ts)
            {
                Arr[k] = i;
                k++;
            }
            Length += count;
        }

        public T this[int index]
        {
            get
            {
                if (index >= Length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }

                if (index < 0)
                {
                    return Arr[Length + index];
                }

                return Arr[index];
            }
            set
            {
                if (index >= Length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }

                if (index < 0)
                {
                    Arr[Length + index] = value;
                }
                else
                {
                    Arr[index] = value;
                }
            }
        }


        public void RemoveAt(int index)
        {
            if (index > Length)
            {
                throw new ArgumentException("The specified index is larger than the list size");
            }
            else if (index >= 0)
            {
                Array.Copy(Arr, index + 1, Arr, index, Length - index);
            }
            else
            {
                Array.Copy(Arr, Length + index + 1, Arr, Length + index, -index);
            }

            Length--;
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < Length; i++)
            {
                if (Arr[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        public bool Insert(T item, int index)
        {
            if (index > Length || -index > Length)
            {
                throw new ArgumentOutOfRangeException("Choose other index");
            }
            else
            {
                if (Length + 1 > Capacity)
                {
                    Capacity *= 2;
                }

                if (index >= 0)
                {
                    for (int i = Length; i > index; i--)
                    {
                        Arr[i] = Arr[i - 1];
                    }

                    Arr[index] = item;
                }
                else
                {
                    for (int i = Length; i > Length + index; i--)
                    {
                        Arr[i] = Arr[i - 1];
                    }

                    Arr[Length + index] = item;
                }

                Length++;
                return true;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return Arr.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)Arr).GetEnumerator();
        }

        public int Capacity { get; set; }
        public int Length { get; set; }
        private T[] Arr { get; set; }
    }
}

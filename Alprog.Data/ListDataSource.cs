using Alprog.Data.Pipeline.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Alprog.Data.Pipeline
{
    public class ListDataSource<T> : IDataSource<T>
    {
        public ListDataSource()
        {
            Filtered = new List<T>();
            ThrownAway = new List<T>();
        }

        public T this[int index] { get { return Filtered[index]; } set { Filtered[index] = value; } }

        public IList<T> Filtered { get; set; }
        public IList<T> ThrownAway { get; set; }

        public int Count { get { return Filtered.Count; } }

        public bool IsReadOnly { get { return false; } }

        public void Add(T item)
        {
            Filtered.Add(item);
        }

        public void Clear()
        {
            Filtered.Clear();
        }

        public bool Contains(T item)
        {
            return Filtered.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Filtered.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Filtered.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return Filtered.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            Filtered.Insert(index, item);
        }

        public bool Remove(T item)
        {
            return Filtered.Remove(item);
        }

        public void RemoveAt(int index)
        {
            Filtered.RemoveAt(index);
        }

        public T[] ToArray()
        {
            return ((List<T>)Filtered).ToArray();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Filtered.GetEnumerator();
        }
    }
}

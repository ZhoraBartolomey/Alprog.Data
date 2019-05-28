using Alprog.Data.Pipeline.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alprog.Data.Pipeline
{
    public class ListDataSource<T> : IDataSource<T>
    {

        public List<T> Items { get; set; } = new List<T>();

        public void Add(T item)
        {
            Items.Add(item);
        }

        public void AddRange(T[] items)
        {
            Items.AddRange(items);
        }

        public void AddRange(IDataSource<T> data)
        {
            foreach (T d in data)
            {
                Items.Add(d);
            }
        }

        public void Clear()
        {
            Items.Clear();
        }

        public IDataSource<T> Create()
        {
            return new ListDataSource<T>();
        }

        public T Get(int index)
        {
            return Items[index];
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        public IDataSource<T> GetRange(int begin, int end)
        {
            ListDataSource<T> result = new ListDataSource<T>();
            for (int i = begin; i <= end; i++)
            {
                result.Add(Items[i]);   
            }
            return result;
        }

        public bool Remove(T item)
        {
            return Items.Remove(item);
        }

        public void RemoveAt(int index)
        {
            Items.RemoveAt(index);
        }

    }
}

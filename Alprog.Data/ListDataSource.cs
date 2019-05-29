using Alprog.Data.Pipeline.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alprog.Data.Pipeline
{
    public class ListDataSource : IDataSource
    {

        public List<object> Items { get; set; } = new List<object>();

        public void Add(object item)
        {
            Items.Add(item);
        }

        public void AddRange(object[] items)
        {
            Items.AddRange(items);
        }

        public void AddRange(IDataSource data)
        {
            foreach (object d in data)
            {
                Items.Add(d);
            }
        }

        public void Clear()
        {
            Items.Clear();
        }

        public IDataSource Create()
        {
            return new ListDataSource();
        }

        public object Get(int index)
        {
            return Items[index];
        }

        public IEnumerator<object> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        public IDataSource GetRange(int begin, int end)
        {
            ListDataSource result = new ListDataSource();
            for (int i = begin; i <= end; i++)
            {
                result.Add(Items[i]);   
            }
            return result;
        }

        public bool Remove(object item)
        {
            return Items.Remove(item);
        }

        public void RemoveAt(int index)
        {
            Items.RemoveAt(index);
        }

    }
}

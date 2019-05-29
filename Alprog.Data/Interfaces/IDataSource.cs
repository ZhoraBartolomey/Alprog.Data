using System;
using System.Collections;
using System.Collections.Generic;

namespace Alprog.Data.Pipeline.Interfaces
{
    public interface IDataSource
    {
        IEnumerator<object> GetEnumerator();
        void Add(object item);
        void AddRange(object[] items);
        void AddRange(IDataSource data);
        bool Remove(object item);
        void RemoveAt(int index);
        object Get(int index);
        IDataSource GetRange(int begin, int end);
        void Clear();
        IDataSource Create();
    }
}

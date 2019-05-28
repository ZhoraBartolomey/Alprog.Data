using System;
using System.Collections;
using System.Collections.Generic;

namespace Alprog.Data.Pipeline.Interfaces
{
    public interface IDataSource<T>
    {
        IEnumerator<T> GetEnumerator();
        void Add(T item);
        void AddRange(T[] items);
        void AddRange(IDataSource<T> data);
        bool Remove(T item);
        void RemoveAt(int index);
        T Get(int index);
        IDataSource<T> GetRange(int begin, int end);
        void Clear();
        IDataSource<T> Create();
    }
}

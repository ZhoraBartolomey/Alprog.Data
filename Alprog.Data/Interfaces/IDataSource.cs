using System;

namespace Alprog.Data.Interfaces
{
    public interface IDataSource<T>
    {
        void GetEnumerator();
        void Add(T item);
        void Remove(T item);
        void RemoveAt(int index);
        void Get(int index);
        void GetRange(int begin, int end);
        void Clear();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Alprog.Data.Interfaces
{
    public interface IDataProcessor<T>
    {
        Guid Id { get; set; }
        IDataSource<T> Process(IDataSource<T> input);
    }
}

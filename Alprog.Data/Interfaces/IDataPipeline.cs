using System;
using System.Collections.Generic;
using System.Text;

namespace Alprog.Data.Interfaces
{
    public interface IDataPipeline<T>
    {
        ICollection<IDataProcessor<T>> Processors { get; set; }
        void LoadHere(IDataSource<T> someData);
        void StartAndContinueToEnd();
        IDataSource<T> NextProcessor(out IDataProcessor<T> processor);
    }
}

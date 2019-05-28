using System;
using System.Collections.Generic;
using System.Text;

namespace Alprog.Data.Pipeline.Interfaces
{
    public interface IDataPipeline<T>
    {
        int CurrentProcessorIndex { get; set; }
        IDataProcessor<T> CurrentProcessor { get; set; }
        IDataSource<T> CurrentData { get; set; }
        IList<IDataProcessor<T>> Processors { get; set; }
        void StartAndContinueToEnd();
        IDataSource<T> NextProcessor();
    }
}

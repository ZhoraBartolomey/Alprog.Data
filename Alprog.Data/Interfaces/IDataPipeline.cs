using System;
using System.Collections.Generic;
using System.Text;

namespace Alprog.Data.Pipeline.Interfaces
{
    public interface IDataPipeline
    {
        int CurrentProcessorIndex { get; set; }
        IDataProcessor CurrentProcessor { get; set; }
        IDataSource CurrentData { get; set; }
        IList<IDataProcessor> Processors { get; set; }
        void StartAndContinueToEnd();
        IDataSource NextProcessor();
        void Add(IDataProcessor processor);
    }
}

using Alprog.Data.Pipeline.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alprog.Data.Pipeline
{
    public class StandardDataPipeline<T> : IDataPipeline<T>
    {
        public StandardDataPipeline()
        {
            Processors = new List<IDataProcessor<T>>();
        }


        public IList<IDataProcessor<T>> Processors { get; set; }
        public int CurrentProcessorIndex { get; set; } = -1;
        public IDataProcessor<T> CurrentProcessor { get; set; }
        public IDataSource<T> CurrentData { get; set; }
        IDataSource<T> DataSource { get; set; }


        public IDataSource<T> NextProcessor()
        {
            CurrentProcessorIndex++;
            CurrentProcessor = Processors[CurrentProcessorIndex];
            CurrentData = CurrentProcessor.Process(CurrentData);
            return CurrentData;
        }

        public void StartAndContinueToEnd()
        {
            for (int i = 0; i < Processors.Count; i++)
            {
                NextProcessor();
            }
        }
    }
}

using Alprog.Data.Pipeline.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alprog.Data.Pipeline
{
    public class StandardDataPipeline : IDataPipeline
    {
        public StandardDataPipeline()
        {
            Processors = new List<IDataProcessor>();
        }


        public IList<IDataProcessor> Processors { get; set; }
        public int CurrentProcessorIndex { get; set; } = -1;
        public IDataProcessor CurrentProcessor { get; set; }
        public IDataSource CurrentData { get; set; }
        IDataSource DataSource { get; set; }

        public void Add(IDataProcessor processor)
        {
            Processors.Add(processor);
        }

        public IDataSource NextProcessor()
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

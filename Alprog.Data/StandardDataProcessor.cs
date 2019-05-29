using Alprog.Data.Pipeline.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alprog.Data.Pipeline
{
    public class StandardDataProcessor<T> : IDataProcessor
    {
        public StandardDataProcessor() { }
        public StandardDataProcessor(Func<IDataSource, IDataSource> processor)
        {
            Processor = processor;
        }
        public Guid Id { get; set; } = Guid.NewGuid();
        public Func<IDataSource, IDataSource> Processor { get; set; }
        public IDataSource Process(IDataSource input)
        {
            return Processor(input);
        }
    }
}

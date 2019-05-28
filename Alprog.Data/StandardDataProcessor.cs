using Alprog.Data.Pipeline.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alprog.Data.Pipeline
{
    public class StandardDataProcessor<T> : IDataProcessor<T>
    {
        public StandardDataProcessor() { }
        public StandardDataProcessor(Func<IDataSource<T>, IDataSource<T>> processor)
        {
            Processor = processor;
        }
        public Guid Id { get; set; } = Guid.NewGuid();
        public Func<IDataSource<T>, IDataSource<T>> Processor { get; set; }
        public IDataSource<T> Process(IDataSource<T> input)
        {
            return Processor(input);
        }
    }
}

using Alprog.Data.Pipeline.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alprog.Data.Pipeline
{
    public class SingleItemDataProcessor<T> : IDataProcessor<T>
    {
        public SingleItemDataProcessor()
        {

        }

        public SingleItemDataProcessor(Func<T, T> processor)
        {
            Processor = processor;
        }

        public Guid Id { get; set; }
        Func<T, T> Processor { get; set; }
        public IDataSource<T> Process(IDataSource<T> input)
        {
            IDataSource<T> dataSource = input.Create();
            foreach (T item in input)
            {
                dataSource.Add(Processor(item));
            }
            return dataSource;
        }
    }
}

using Alprog.Data.Pipeline.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alprog.Data.Pipeline
{
    public class SingleItemDataProcessor : IDataProcessor
    {
        public SingleItemDataProcessor()
        {

        }

        public SingleItemDataProcessor(Func<object, object> processor)
        {
            Processor = processor;
        }

        public Guid Id { get; set; }
        Func<object, object> Processor { get; set; }
        public IDataSource Process(IDataSource input)
        {
            IDataSource dataSource = input.Create();
            foreach (object item in input)
            {
                dataSource.Add(Processor(item));
            }
            return dataSource;
        }
    }
}

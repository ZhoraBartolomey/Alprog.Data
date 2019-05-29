using Alprog.Data.Pipeline.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alprog.Data.Pipeline
{
    public class HistogramItem
    {
        object key;
        int enters;
        public HistogramItem(object key, int enters)
        {
            this.key = key; this.enters = enters;
        }

        public object Key { get { return key; } set { key = value; } }
        public int Enters { get { return enters; } set { enters = value; } }
    }
    public class HistogramAnalyser : IDataProcessor
    {
        public Guid Id { get; set; }

        public IDataSource Process(IDataSource data)
        {
            ListDataSource result = new ListDataSource();
            foreach (object input in data)
            {
                bool enter = false;
                for (int i = 0; i < result.Items.Count; i++)
                {
                    HistogramItem item = (HistogramItem)result.Get(i);
                    if (item.Key.Equals(input))
                    {
                        item.Enters++;
                        enter = true;
                        break;
                    }
                }
                if (!enter)
                    result.Add(new HistogramItem(input, 1));
            }
            return result;
        }

    }
}

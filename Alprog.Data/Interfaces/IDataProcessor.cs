using System;
using System.Collections.Generic;
using System.Text;

namespace Alprog.Data.Pipeline.Interfaces
{
    public interface IDataProcessor
    {
        Guid Id { get; set; }
        IDataSource Process(IDataSource input);
    }
}

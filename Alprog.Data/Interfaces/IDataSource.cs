using System;
using System.Collections.Generic;
using System.Text;

namespace Alprog.Data.Pipeline.Interfaces
{
    public interface IDataSource<T> : IList<T>
    {
        IList<T> Filtered { get; set; }
        IList<T> ThrownAway { get; set; }
    }
}

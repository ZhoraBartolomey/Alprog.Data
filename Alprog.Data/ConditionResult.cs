using System;
using System.Collections.Generic;
using System.Text;

namespace Alprog.Data.Pipeline
{
    public class ConditionResult<T>
    {
        public ConditionResult() { }
        public ConditionResult(bool? result, T value)
        {
            Success = result; Value = value;
        }
        public virtual bool? Success { get; set; }
        public virtual T Value { get; set; }
        
    }
}

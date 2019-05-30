using System;
using System.Collections.Generic;
using System.Text;

namespace Alprog.Data.Pipeline
{
    public static class ConditionExtension
    {
        public static ConditionResult<T> If<T>(this T value, Func<T, bool> condition)
        {
            return new ConditionResult<T>(condition(value), value);
        }

        public static ConditionResult<T> Then<T>(this ConditionResult<T> value, Action<T> action)
        {
            if (value.Success == true)
            {
                action(value.Value);
                return new ConditionResult<T>(null, value.Value);
            }
            return value;
        }

        public static ConditionResult<T> Else<T>(this ConditionResult<T> value, Action<T> action)
        {
            if (value.Success == false)
                action(value.Value);
            return value;
        }

        public static ConditionResult<T> ElseIf<T>(this ConditionResult<T> value, Func<T, bool> condition)
        {
            if (value.Success == false)
            {
                return new ConditionResult<T>(condition(value.Value), value.Value);
            }
            return value;
        }
    }
}

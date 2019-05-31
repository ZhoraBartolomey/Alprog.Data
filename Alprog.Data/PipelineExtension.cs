using Alprog.Data.Pipeline.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alprog.Data.Pipeline
{
    public static class PipelineExtension
    {
        public static IDataSource<T> EveryItem<T>(this IEnumerable<T> enumerable, Action<T> processor, bool dispose = true)
        {
            foreach (T item in enumerable)
            {
                processor(item);
            }
            
            var a = new ListDataSource<T>() { Filtered = new List<T>(enumerable) };
            if (dispose)
                enumerable = null;
            return a;
        }

        public static IDataSource<T> Process<T>(this IEnumerable<T> enumerable, Func<T, T> processor, bool dispose = true)
        {
            ListDataSource<T> output = new ListDataSource<T>();
            foreach (T item in enumerable)
            {
                output.Add(processor(item));
            }
            if (dispose)
                enumerable = null;
            return output;
        }

        public static IDataSource<TOutput> Transform<TInput, TOutput>(this IEnumerable<TInput> enumerable, 
            Func<TInput, TOutput> transormer, bool dispose = true) {

            ListDataSource<TOutput> output = new ListDataSource<TOutput>();
            foreach (TInput input in enumerable)
            {
                output.Add(transormer(input));
            }
            if (dispose)
                enumerable = null;
            return output;
        }
        
        
        public static IDataSource<T> FilterBy<T>(this IEnumerable<T> enumerable, Func<T, bool> condition, bool dispose = true)
        {
            ListDataSource<T> output = new ListDataSource<T>();
            foreach (T item in enumerable)
            {
                if (condition(item))
                    output.Add(item);
                else
                    output.ThrownAway.Add(item);
            }
            if (dispose)
                enumerable = null;
            return output;
        }
    }
}

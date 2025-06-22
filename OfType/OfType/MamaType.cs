using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfType
{
    internal class MamaType : IOfType
    {
        public IEnumerable<T> GetOfType<T>(IEnumerable enumerable)
        {
            List<T> list = new List<T>();
            foreach (var item in enumerable) {
                if (item is T  t)
                {
                    list.Add(t);
                }
            }
            return list;
        }

        public IEnumerable<TOutput> GetOfType<TSource, TOutput>(IEnumerable<TSource> enumerable)
        {
            List<TOutput> list = new List<TOutput>();
            foreach (TSource item in enumerable)
            {
                if (item is TOutput output)
                {
                    list.Add(output);
                }
            }
            return list;
        }

        public IEnumerable<TBase> OfBase<TBase, TDerived>(IEnumerable<TDerived> derivedItems) where TDerived : TBase
        {
            List<TBase> list = new List<TBase>();
            foreach (var derivedItem in derivedItems)
            {
               if(derivedItem is TBase derivedDerived)
                    list.Add(derivedItem);
            }
            return list;
        }
    }
}

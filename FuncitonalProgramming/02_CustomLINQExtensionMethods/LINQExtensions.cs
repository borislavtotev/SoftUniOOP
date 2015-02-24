using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CustomLINQExtensionMethods
{
    public static class LINQExtensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate) 
        {
            var results = 
                from item in collection
                where !predicate(item)
                select item;

            return results;
        }
 
        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count) 
        {
            IEnumerable<T> results = collection;

            for (int i = 0; i < count-1; i++)
            {
                results = results.Concat(collection);
            }

            return results;
        } 

        public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection, IEnumerable<string> suffixes)
        {
            var results =
                from item in collection
                    from suffix in suffixes
                    where item.EndsWith(suffix)
                    select item;

            return results;
        } 
    }
}

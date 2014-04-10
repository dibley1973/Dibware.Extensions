using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dibware.System.Extensions.System.Collections.Generic
{
    /// <summary>
    /// Provides extensionn methods to the IEnumerable class
    /// </summary>
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="action"></param>
        public static void ForEach<T>(this IEnumerable<T> source,
            Action<T> action)
        {
            foreach (T element in source)
            {
                action(element);
            }
        }
    }
}

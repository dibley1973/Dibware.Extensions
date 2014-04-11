using System;
using System.Collections.Generic;

namespace Dibware.Extensions.System.Collections
{
    /// <summary>
    /// Provides extensionn methods to the IEnumerable class
    /// </summary>
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Performs the specified action on each element of the IEnumerable<T>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="action">The Action<T> delegate to perform on each element of the List<T>.</param>
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

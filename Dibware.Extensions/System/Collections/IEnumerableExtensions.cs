using System;
using System.Collections.Generic;
using System.Text;

namespace Dibware.Extensions.System.Collections
{
    /// <summary>
    /// Provides extensionn methods to the IEnumerable class
    /// </summary>
    public static class IEnumerableExtensions
    {
        #region ForEach

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

        #endregion

        #region AppendAll

        /// <summary>
        /// Appends all of the Strings in the collection.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <returns></returns>
        public static String AppendAll(this IEnumerable<String> collection)
        {
            return AppendAll(collection, String.Empty);
        }

        /// <summary>
        /// Appends all of the Strings in the collection using the specied seperator.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <param name="seperator">The seperator.</param>
        /// <returns></returns>
        public static String AppendAll(this IEnumerable<String> collection, String seperator)
        {
            using (var enumerator = collection.GetEnumerator())
            {
                if (!enumerator.MoveNext())
                {
                    return String.Empty;
                }

                var builder = new StringBuilder().Append(enumerator.Current);

                while (enumerator.MoveNext())
                {
                    builder.Append(seperator).Append(enumerator.Current);
                }

                return builder.ToString();
            }
        }

        #endregion
    }
}
using System;

namespace Dibware.System.Extensions
{
    /// <summary>
    /// Extend methods for the System.String object
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Indicates if the instance has a value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Returns <c>true</c> if this instance has a value, otherwise <c>false</c>.</returns>
        public static Boolean HasValue(this String value)
        {
            return !String.IsNullOrEmpty(value);
        }

        /// <summary>
        /// Indicates if the instance is null or empty.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Returns <c>true</c> if this instance is null or empty, otherwise <c>false</c>.</returns>
        public static Boolean IsNullOrEmpty(this String value)
        {
            return String.IsNullOrEmpty(value);
        }

        /// <summary>
        /// Indicates if the instance is null or white space.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Returns <c>true</c> if this instance is null or white space, otherwise <c>false</c>.</returns>
        public static Boolean IsNullOrWhiteSpace(this String value)
        {
            return String.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        /// Indicates if the instance is null, empty or white space.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Returns <c>true</c> if this instance is null, empty or white space, otherwise <c>false</c>.</returns>
        public static Boolean IsNullOrEmptyOrWhiteSpace(this String value)
        {
            return String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value);
        }
    }
}
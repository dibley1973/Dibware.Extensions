using System;
using System.Text.RegularExpressions;

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
        /// Determines whether this instance of a <see cref="string" /> is a <see cref="DateTime" />.
        /// </summary>
        /// <param name="value">This instance</param>
        /// <returns>
        /// 	<c>true</c> if the specified value is System.DateTime; otherwise, <c>false</c>.
        /// </returns>
        public static Boolean IsDateTime(this String value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return false;
            }
            DateTime output;
            return DateTime.TryParse(value, out output);
        }

        /// <summary>
        /// Determines whether this instance of a <see cref="string" /> is a 16 bit integer.
        /// </summary>
        /// <param name="value">This instance</param>
        /// <returns>
        /// 	<c>true</c> if the specified value is a 16 bit integer; otherwise, <c>false</c>.
        /// </returns>
        public static Boolean IsInt16(this String value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            Int16 output;
            return Int16.TryParse(value, out output);
        }

        /// <summary>
        /// Determines whether this instance of a <see cref="string" /> is a 32 bit integer.
        /// </summary>
        /// <param name="value">This instance</param>
        /// <returns>
        /// 	<c>true</c> if the specified value is a 32 bit integer; otherwise, <c>false</c>.
        /// </returns>
        public static Boolean IsInt32(this String value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            int output;
            return Int32.TryParse(value, out output);
        }

        /// <summary>
        /// Determines whether this instance of a <see cref="string" /> is a 64 bit integer.
        /// </summary>
        /// <param name="value">This instance</param>
        /// <returns>
        /// 	<c>true</c> if the specified value is a 64 bit integer; otherwise, <c>false</c>.
        /// </returns>
        public static Boolean IsInt64(this String value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            Int64 output;
            return Int64.TryParse(value, out output);
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

        /// <summary>
        /// Determines whether this instance of a <see cref="string" /> is numeric.
        /// </summary>
        /// <param name="value">This instance</param>
        /// <returns>
        /// 	<c>true</c> if the specified s is numeric; otherwise, <c>false</c>.
        /// </returns>
        public static Boolean IsNumeric(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            double output;
            return double.TryParse(value, out output);
        }

        /// <summary>
        /// Determines whether the specified text is in a valid comma sperated string.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>
        /// 	<c>true</c> if the specified value is in a valid format; otherwise, <c>false</c>.
        /// </returns>
        public static Boolean IsNumericCsv(this String value)
        {
            // Return true if text is in valid e-mail format.
            return Regex.IsMatch(value, "^[0-9, ]+$");
        }

        /// <summary>
        /// Determines whether the specified text is in a valid email address format.
        /// </summary>
        /// <param name="value">The text to check.</param>
        /// <returns>
        /// 	<c>true</c> if text is in a valid format; otherwise, <c>false</c>.
        /// </returns>
        public static Boolean IsValidEmailAddressFormat(this string value)
        {
            // Return true if text is in valid e-mail format.
            // Ref: http://msdn.microsoft.com/en-us/library/01escwtf.aspx
            return Regex.IsMatch(value, "^(?(\")(\".+?\"@)|(([0-9a-zA-Z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-zA-Z])@))" + "(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,6}))$");
        }
    }
}
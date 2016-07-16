
namespace Dibware.Extensions.System
{
    /// <summary>
    /// Extension methods for the System.Int32 object
    /// </summary>
    public static class Int32Extensions
    {
        /// <summary>
        /// Clamps the specified value between specified min and max values.
        /// </summary>
        /// <param name="value">The instance of the value to clamp.</param>
        /// <param name="min">The minimum value. If value is less than min, min will be returned.</param>
        /// <param name="max">The maximum value. If value is greater than max, max will be returned.</param>
        /// <returns>The clamped value.
        /// If value is greater than max, then max will be returned.
        /// If value is less than min, then min will be returned.
        /// If value is between both min and max then value will be returned.
        /// </returns>
        public static int Clamp(this int value, int min, int max)
        {
            if (value > max) return max;
            if (value < min) return min;

            return value;
        }
    }
}
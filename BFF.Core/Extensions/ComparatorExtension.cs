using System;

namespace BFF.Core.Extensions
{
    public static class ComparatorExtension
    {
        public static bool IsEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsEmpty(this Guid value)
        {
            return Guid.Empty == value;
        }

        public static bool IsEmpty(this DateTime value)
        {
            return value == DateTime.MinValue;
        }
    }
}

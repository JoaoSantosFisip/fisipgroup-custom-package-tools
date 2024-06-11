using UnityEngine;

namespace FisipGroup.CustomPackage.Tools.Extensions
{
    /// <summary>
    /// Float component extensions.
    /// </summary>
    public static class ExtensionsFloat
    {
        private static float Minutes;
        private static float Seconds;
        private static float Milliseconds;

        /// <summary>
        /// Converts value to a timer string. ex: 01:35:84
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToTimeString_Min_Sec_Mil(this float value)
        {
            Minutes = Mathf.FloorToInt(value / 60);
            Seconds = Mathf.FloorToInt(value % 60);
            Milliseconds = Mathf.FloorToInt((value * 100) % 100);

            return $"{Minutes:00}:{Seconds:00}:{Milliseconds:00}";
        }
        /// <summary>
        /// Converts value to a timer string. ex: 02:35
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToTimeString_Min_Sec(this float value)
        {
            Minutes = Mathf.FloorToInt(value / 60);
            Seconds = Mathf.FloorToInt(value % 60);

            return $"{Minutes:00}:{Seconds:00}";
        }
        /// <summary>
        /// Remaps value from one range to another.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="minRemaped"></param>
        /// <param name="maxRemaped"></param>
        /// <returns></returns>
        public static float Remap(this float value, float min, float max, float minRemaped, float maxRemaped)
        {
            if(min > max)
            {
                Debug.LogWarning("FisipGroup.CustomPackage.Tools.ExtensionsFloat: " +
                    "min value is higher than the max value");
            }
            if(max < min)
            {
                Debug.LogWarning("FisipGroup.CustomPackage.Tools.ExtensionsFloat: " +
                    "max value is lower than the min value");
            }
            if (minRemaped > maxRemaped)
            {
                Debug.LogWarning("FisipGroup.CustomPackage.Tools.ExtensionsFloat: " +
                    "minRemaped value is higher than the maxRemaped value");
            }
            if (maxRemaped < minRemaped)
            {
                Debug.LogWarning("FisipGroup.CustomPackage.Tools.ExtensionsFloat: " +
                    "maxRemaped value is lower than the minRemaped value");
            }

            value = Mathf.Clamp(value, min, max);

            return Mathf.Lerp(minRemaped, maxRemaped, (value - min) / (max - min));
        }
    }
}
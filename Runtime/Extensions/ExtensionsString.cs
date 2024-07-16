using System.Text.RegularExpressions;
using UnityEngine;

namespace FisipGroup.CustomPackage.Tools.Extensions
{
    /// <summary>
    /// String component extensions.
    /// </summary>
    public static class ExtensionsString
    {
        /// <summary>
        /// Removes extra text whenever a object is copied and pasted. ex: (1) ...
        /// Also removes extra text whenever an object is instantiated via code. ex (Clone) ...
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string RemoveDuplicatedObjectText(this string source)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                EmptyStringWarningMessage();

                return string.Empty;
            }

            var newString = Regex.Replace(source, @"\(\d+\)", "").Trim();

            return newString.Replace("(Clone)", "");
        }

        /// <summary>
        /// Removes the extra Hash code text from the Unity Authentication Player's ID.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string RemovePlayerHashCode(this string source)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                EmptyStringWarningMessage();

                return string.Empty;
            }

            return source.Split('#')[0];
        }

        /// <summary>
        /// Removes all spaces, new lines and tabs from text.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string RemoveWhitespaceLinesAndTabs(this string source)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                EmptyStringWarningMessage();

                return string.Empty;
            }

            // Use Regex to replace all whitespace characters (spaces, new lines, tabs) with an empty string
            return Regex.Replace(source, @"\s+", "");
        }

        private static void EmptyStringWarningMessage()
        {
            Debug.LogWarning("FisipGroup.CustomPackage.Tools.Extensions.ExtensionsString: " +
                "String is null or empty, returning empty string");
        }
    }
}

using System;
using System.Globalization;
using System.Linq;
using UnityEngine;

namespace FisipGroup.CustomPackage.Tools.Helpers
{
    /// <summary>
    /// Helper for currency related issues.
    /// </summary>
    public static class HelperCurrency
    {
        /// <summary>
        /// Converts currency ISO to currency symbol. ex USD -> $
        /// </summary>
        /// <param name="isoCurrencyCode"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string GetCurrencySymbol(string isoCurrencyCode)
        {
            try
            {
                // Get the culture associated with the ISO currency code
                var cultureInfo = CultureInfo
                    .GetCultures(CultureTypes.SpecificCultures)
                    .FirstOrDefault(c => new RegionInfo(c.Name).ISOCurrencySymbol == isoCurrencyCode);

                if (cultureInfo != null)
                {
                    // Return the currency symbol
                    return new RegionInfo(cultureInfo.Name).CurrencySymbol;
                }
                else
                {
                    throw new ArgumentException("FisipGroup.CustomPackage.Tools.Helpers.HelperCurrency: Invalid ISO currency code.");
                }
            }
            catch (Exception ex)
            {
                Debug.LogError($"FisipGroup.CustomPackage.Tools.Helpers.HelperCurrency: Error converting ISO currency code to symbol: {ex.Message}");

                return null;
            }
        }
    }
}
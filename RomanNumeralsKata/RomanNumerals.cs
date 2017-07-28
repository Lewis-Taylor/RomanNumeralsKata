using System;
using System.Collections.Generic;

namespace RomanNumeralsKata
{
    public static class RomanNumerals
    {
        private static readonly Dictionary<int, string> ArabicToRomanNumeral= new Dictionary<int, string>
        {
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };

        public static string Convert(int number)
        {
            foreach ( var arabic in ArabicToRomanNumeral.Keys)
            {
                if (number >= arabic)
                {
                    return ArabicToRomanNumeral[arabic] + Convert(number - arabic);
                }
            }
            
            return string.Empty;
        }
    }
}

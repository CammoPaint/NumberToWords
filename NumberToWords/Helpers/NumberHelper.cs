using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace NumberToWords.Helpers
{
    public static class NumberHelper
    {
        /// <summary>
        /// Return the string representation of a decimal value with units
        /// </summary>
        /// <param name="Number">Decimal number to convert</param>
        /// <param name="WholeUnit">Unit of measurement of the whole number component</param>
        /// <param name="FractionUnit">Unit of measure of the fractional component</param>
        /// <returns></returns>
        public static string ConvertNumberToCurrency(double Number, string WholeUnit, string FractionUnit)
        {
            var result = "";

            // split the dollars and cents
            var dollarValue = Math.Truncate(Number);
            var centValue = (Number - Math.Truncate(Number)) * 100;

            var dollars = Helpers.NumberHelper.ConvertNumberToWords((int)dollarValue);
            var cents = Helpers.NumberHelper.ConvertNumberToWords((int)centValue);

            var dollarString = string.Format("{0} {1}{2}", dollars, WholeUnit, dollarValue > 1 ? "s" : "");
            var centString = string.Format("{0} {1}{2}", cents, FractionUnit, centValue > 1 ? "s" : "");

            if (dollarValue > 0 && centValue > 0)
                result = string.Format("{0} and {1}", dollarString, centString);
            else if (centValue > 0)
                result = centString;
            else if (dollarValue > 0)
                result = dollarString;

            return result;
        }

        /// <summary>
        /// Return the string representation of a whole number
        /// </summary>
        /// <param name="Number">number to convert</param>
        /// <returns></returns>
        public static string ConvertNumberToWords(int Number)
        {
            StringBuilder word = new StringBuilder();

            var ones = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tens = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            var units = new[] { "hundred", "thousand", "million", "billion", "trillion" };

            // zero - nineteen
            if (Number < 20)
                word.Append(ones[Number]);

            // one hundred and over
            else if (Number > 99)
            {
                int log = (int)Math.Log(Number, 1000);
                int pow = (int)Math.Pow(1000, log);

                if (pow > 1)
                    word.Append(ConvertNumberToWords(Number / pow) + " " + units[log]);
                else // hundreds
                {
                    pow = 100;
                    word.Append(ones[Number / 100] + " " + units[0]);
                }

                // handle the remainder
                if (Number % pow > 0)
                {
                    Number = Number % pow;
                    word.Append(Number < 100 ? " and " : " ");
                    word.Append(ConvertNumberToWords(Number));
                }

            }
            // twenty - ninety-nine
            else if(Number > 19)
            {
                word.Append(tens[Number / 10]);
                // handle the remainder
                if(Number % 10 > 0)
                    word.Append("-" + ConvertNumberToWords(Number % 10));
            }

            return word.ToString();

        }
    }
}
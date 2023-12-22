using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsMethods
{
    public static class CustomExtensions
    {
        public static double GetSquare(this int value)
        {
            return Math.Pow(value, 2);
        }

        public static double GetPower(this int value, int power) => Math.Pow(value, power);

        public static string ToTitleCase(this string value)
        {
            var wordsArray = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < wordsArray.Length; i++)
            {
                wordsArray[i] = wordsArray[i].Substring(0, 1).ToUpper() + wordsArray[i].Substring(1);
            }

            return string.Join(" ", wordsArray);

        }

        public static char? NextChar(this Random random, bool isLower = true)
        {
            return isLower ? (char)random.Next(97, 123) : (char)random.Next(65, 90);
        }

        public static string NextWord(this Random value, int length, bool isLower = true)
        {
            string result = string.Empty;
            for (int i = 0; i < length; i++)
            {
                result += value.NextChar(isLower);
            }
            return result;

        }
    }
}

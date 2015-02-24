using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_StringBuilderExtensions
{
    public static class StringBulderExtensions
    {
        public static string Substring(this StringBuilder builder, int startIndex, int length)
        {
            string inputString = builder.ToString();

            if (startIndex < 0 || (startIndex +length) > inputString.Length - 1)
            {
                throw new ArgumentOutOfRangeException("The startIndex and length are not valid");
            }

            return inputString.Substring(startIndex, length);
        }

        public static void RemoveText(this StringBuilder builder, string text)
        {
            string inputString = builder.ToString();
            string outputString = Regex.Replace(inputString, text, "", RegexOptions.IgnoreCase);
            builder.Clear();
            builder.Append(outputString);
        }

        public static void AppendAll<T>(this StringBuilder builder, IEnumerable<T> items) 
        {
            foreach (var item in items)
            {
                builder.Append(item.ToString());
            }
        }
    }
}

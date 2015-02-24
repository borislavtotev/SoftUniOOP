using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_StringBuilderExtensions
{
    class Program
    {
        static void Main(string[] args)
        {          
            StringBuilder builder = new StringBuilder();
            builder.Append("alabalanica");
            int startIndex = 3;
            int length = 5;
            Console.WriteLine("Substring of {0} from index: {1} with length: {2} is: {3}", builder, startIndex, length, builder.Substring(startIndex, length));

            builder.RemoveText("a");
            Console.WriteLine(builder);

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            builder.AppendAll(numbers);
            Console.WriteLine(builder);
        }
    }
}

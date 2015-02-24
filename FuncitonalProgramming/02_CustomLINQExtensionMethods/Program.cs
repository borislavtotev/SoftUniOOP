using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CustomLINQExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // test where not            
            int[] numbers = new int[] { 1, 2, 23, 32, 45, 4, 6, 43, 435, 32 };
            var smallNumbers = numbers.WhereNot(x => x > 10);

            foreach (var num in smallNumbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            // test Repeat collection
            var repeatCollection = numbers.Repeat(2);
            foreach (var num in repeatCollection)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            // test WhereEndsWith
            List<string> strings = new List<string>() { "ala", "bal", "nica", "gore", "dolu", "duma" };
            var endsWirthCollection = strings.WhereEndsWith(new string[] { "la", "ore", "u" });

            foreach (var item in endsWirthCollection)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}

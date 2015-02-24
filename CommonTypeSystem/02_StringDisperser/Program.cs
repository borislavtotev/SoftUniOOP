using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StringDisperser
{
    class Program
    {
        static void Main(string[] args)
        {
            StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "tanio");
            StringDisperser stringDisperser1 = new StringDisperser("gosho", "pesho", "tanio");

            // test == and Equal
            if (stringDisperser == stringDisperser1)
            {
                Console.WriteLine(stringDisperser);
            }

            Console.WriteLine();

            // test clone
            StringDisperser stringDisperser2 = (StringDisperser)stringDisperser1.Clone();
            stringDisperser1.Add("tralala");
            Console.WriteLine(stringDisperser1);
            Console.WriteLine(stringDisperser2);

            Console.WriteLine();

            // test compareTo by sorting array with StringDisperser
            StringDisperser stringDisperser3 = new StringDisperser("ala", "bala");
            StringDisperser[] stringDispersers = new StringDisperser[] { stringDisperser2, stringDisperser1, stringDisperser, stringDisperser3 };
            Array.Sort(stringDispersers);
            for (int i = 0; i < stringDispersers.Length; i++)
            {
                Console.WriteLine(stringDispersers[i]);
            }

            Console.WriteLine();

            // test IEnumerable
            foreach (var item in stringDispersers)
            {
                Console.WriteLine(item);
            }
        }
    }
}

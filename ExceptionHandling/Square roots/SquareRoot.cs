using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            String input;
            input = Console.ReadLine();

            try
            {
                int value = Int32.Parse(input);
                
                if (value<0)
                {
                    throw new Exception(); 
                }

                double result = Math.Sqrt(value);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AsynchronousTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            // method to print the current time to file (for testing) 
            Action method = delegate()
            {
                using (System.IO.StreamWriter file = System.IO.File.AppendText(@"../../test.txt"))
                {
                    file.WriteLine(DateTime.Now);
                }
            };

            // create the timer to call the method 10 times on each 1 sec
            AsyncTimer timer = new AsyncTimer(method, 10, 1000);

            // Just to test the timer we can wait for user input. The current date time will be printed in the consol
            Console.ReadLine();
        }
    }
}

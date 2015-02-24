using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intList = new GenericList<int>(1);
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            Console.WriteLine("Elements: {0}", intList);
            Console.WriteLine("The second element is: {0}", intList[1]);
            Console.WriteLine("Remove the second element.");
            intList.RemoveElementByIndex(1);
            Console.WriteLine("Elements: {0}", intList);
            intList.InsertElementAtPosition(2, 1);
            Console.WriteLine("Inset 2 at position 1.");
            Console.WriteLine("Elements: {0}", intList);
            Console.WriteLine("Clear elements.");
            intList = intList.Clear();
            Console.WriteLine("Elements: {0}", intList);
            intList.Add(2);
            intList.Add(3);
            intList.Add(1);
            Console.WriteLine("Elements: {0}", intList);
            Console.WriteLine("The index of {0} is {1}.", 2,intList.FindElementIndex(2));
            Console.WriteLine("Check whether the list contains 2: {0}", intList.Contains(2));
            Console.WriteLine("The minimum value is:{0}", intList.Min<int>());
            Console.WriteLine("The maximum value is:{0}", intList.Max<int>());
        }
    }
}

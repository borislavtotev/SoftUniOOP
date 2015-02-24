using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EnterNumbers
{      
    public static int ReadNumber(int start, int end)
    {
        String input;
        input = Console.ReadLine();
        int result;

        try
        {
            result = Int32.Parse(input);
        }
        catch
        {
            throw new ArgumentException("Not a integer number is entered.");
        }

        if (result<start || result>end)
        {
            string exception = string.Format("The number is not in this range[{0}...{1}]",start.ToString(),end.ToString());
            throw new ArgumentException(exception);
        }

        return result;
    }
    static void Main(string[] args)
    {
        List<Int32> list = new List<Int32>();
            
        while (list.Count<10)
        {
            try
            {
                int number = ReadNumber(1, 100);

                if (list.Count == 0 || (number > list.Last()))
                {
                    list.Add(number);
                }
                else
                {
                    throw new Exception("This value is not greater than the previous one");
                }
                    
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        Console.WriteLine(String.Join(", ",list.ToArray()));
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_WeakStudents
{
    public static class Extensions
    {
        public static bool ContainThisTimes(this IList<int> list, int num, int times)
        {
            int count = 0;
            foreach (var item in list)
            {
                if (item == num)
                {
                    count++;
                }
            }

            return count == times;
        }
    }
}

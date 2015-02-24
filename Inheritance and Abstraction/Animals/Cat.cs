using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat: Animal, ISound
    {
        public Cat(string name, uint age, string gender):base(name,age,gender)
        {
        }
         
        public Cat(string name, uint age):base(name,age)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("May May");
        }
    }
}

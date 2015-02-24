using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog: Animal, ISound
    {
        public Dog(string name, uint age, string gender):base(name,age,gender)
        {
        }

        public Dog(string name, uint age):base(name,age)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Bay Bay");
        }
    }
}

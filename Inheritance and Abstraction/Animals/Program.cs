using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cat rijko = new Cat("rijko", 5, "male");
                Console.WriteLine(rijko.ToString());
                rijko.ProduceSound();

                Tomcat darko = new Tomcat("darko", 3);
                Console.WriteLine(darko.ToString());
                darko.ProduceSound();

                Frog kikerana = new Frog("kikerana", 1, "female");
                Console.WriteLine(kikerana.ToString());
                kikerana.ProduceSound();

                Dog sharo = new Dog("sharo", 9);
                Console.WriteLine(sharo.ToString());
                sharo.ProduceSound();

                Animal[] animals = new Animal[] {
                    rijko,
                    darko,
                    kikerana,
                    sharo,
                    new Cat("tom",2),
                    new Dog("zoro",9),
                    new Cat("kotka",4,"male")
                };

                Console.WriteLine();

                foreach (var animal in animals)
                {
                    Console.WriteLine(animal.ToString());
                }

                Console.WriteLine();


                var groupAnimals =
                    from animal in animals
                    group animal by animal.GetType().Name into typeGroup
                    select new 
                    {
                        typeGroup.Key,
                        AverageValue = Math.Round(typeGroup.Average(i => i.Age),2)
                    };

                foreach (var typeGroup in groupAnimals)
                {
                    Console.WriteLine("{0}s: average age is:{1}",typeGroup.Key,typeGroup.AverageValue);
                }

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

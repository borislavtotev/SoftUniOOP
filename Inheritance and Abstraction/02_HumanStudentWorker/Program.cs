using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_HumanStudentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivan", "Ivanov", "12345"),
                new Student("Ivanka", "Ivanova", "abcdefgh"),
                new Student("Alex", "Alexandrov", "2343242342"),
                new Student("Borisla", "Borislawow", "3242343"),
                new Student("Ginka", "Palowa", "52342"),
                new Student("Georgi", "Georgie", "43557"),
                new Student("Dragomir", "Dragomirov", "56756234"),
                new Student("Angel", "Indrov", "asfasdg435"),
                new Student("Setlin", "Naxandrov", "afagfdfg43"),
                new Student("Jana", "Petrova", "3455egd2")
            };

            var output = from element in students
                         orderby element.FaultyNumber ascending
                         select element;

            
            Console.WriteLine("Students sorted by faulty number:\n");
            foreach (var student in output)
            {
                Console.WriteLine(student.ToString());
            }




            List<Worker> workers = new List<Worker>()
            {
                new Worker("Ivan", "Dragono",1000,8),
                new Worker("Ivanka", "Ivanova", 2000, 5),
                new Worker("Alex", "Todor", 1345, 4.5),
                new Worker("Borisla", "Yordano", 123, 1),
                new Worker("Ginka", "Ginkoa", 1253, 6.3),
                new Worker("Georgi", "Georgie", 356, 3),
                new Worker("Dragomir", "Abadjie", 3000, 10),
                new Worker("Angel", "Angelo", 3500, 12),
                new Worker("Setlin", "Warea", 3200, 11),
                new Worker("Jana", "Troafadd", 4800, 10)
            };

            IEnumerable<Worker> query = workers.OrderBy(Worker => Worker.MoneyPerHour());


            Console.WriteLine();
            Console.WriteLine("Workers sorted by money per Hour:\n");
            
            foreach (var worker in query)
            {
                Console.WriteLine(worker.ToString());
            }

            
            
            List<Human> studentsAndWorkers = new List<Human>();

            studentsAndWorkers.AddRange(students);
            studentsAndWorkers.AddRange(workers);
            studentsAndWorkers.Sort();

            Console.WriteLine();
            Console.WriteLine("Students and Workers sorted by first and last name:\n");

            foreach (var human in studentsAndWorkers)
            {
                Console.WriteLine(human.ToString());
            }
        }
    }
}

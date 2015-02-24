using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    class Test
    {
        static void Main(string[] args)
        {
            Students alexander = new Students("Alexander", 1);
            Students alexandra = new Students("Alexandra", 1);
            Students borislav = new Students("Borislav", 2);
            Students borislava = new Students("Borislava", 2);

            Discipline maths = new Discipline("maths", 12, "Advanced Mathermatics");
            Discipline literature = new Discipline("literature", 10, "Bulgarian literatures");
            Discipline english = new Discipline("english", 15);

            Teachers dimitrov = new Teachers("Mr. Dimitrov",new List<Discipline>{maths,english},"The best teacher");
            Teachers hadjiev = new Teachers("Mr. Hadjiev", new List<Discipline> {literature, english }, "Good teacher");

            Class class12a = new Class("12a", "Last Year Class");
            Class class12b = new Class("11b");
            //Class class11a = new Class("11b"); //throw an exception because class with indent 11b is already created

            try
            {
                class12a.AddStudent(alexander);
                class12a.AddStudent(borislav);
                //class12a.AddStudent(alexandra); //throw an Exception because student with number 1 is added
                class12a.AddTeacher(dimitrov);
                class12a.AddTeacher(hadjiev);

                class12b.AddStudent(alexandra);
                class12b.AddStudent(borislava);
                class12b.AddTeacher(hadjiev);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine(class12a);
                Console.WriteLine(class12b);
            }
        }
    }
}

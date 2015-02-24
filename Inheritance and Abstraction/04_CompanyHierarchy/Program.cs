using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CompanyHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Sale sale1 = new Sale("Beer", DateTime.Parse("2014-01-01"), 2.48);
                Sale sale2 = new Sale("Cola", DateTime.Parse("2012-12-01"), 2.08);
                Sale sale3 = new Sale("Fanta", DateTime.Parse("2013-02-21"), 2.08);
                Sale sale4 = new Sale("Water", DateTime.Parse("2015-01-31"), 1.53);
                Sale sale5 = new Sale("Rakia", DateTime.Parse("2012-12-01"), 5.68);
                Sale sale6 = new Sale("Wine", DateTime.Parse("2013-11-07"), 4.44);
                Sale sale7 = new Sale("Vodka", DateTime.Parse("2015-01-15"), 6.00);

                SalesEmployee petkoSelsa = new SalesEmployee(1, "Petko", "Selsa", 1000, "Marketing", new List<Sale> { sale1, sale2, sale3 });
                SalesEmployee ginkaJunioara = new SalesEmployee(1, "Ginka", "Juniora", 543.45, "Production", new List<Sale> { sale3, sale4, sale5 });
                SalesEmployee goshoHubaveca = new SalesEmployee(1, "Gosho", "Hubaveca", 735.54, "Accounting", new List<Sale> { sale1, sale3, sale5 });
                //Console.WriteLine(goshoHubaveca);

                //Console.WriteLine();

                Project project1 = new Project("Project1", DateTime.Parse("2014-01-01"), "open");
                Project project2 = new Project("Project2", DateTime.Parse("2015-01-21"), "closed", "finised project");
                Project project3 = new Project("Project3", DateTime.Parse("2013-11-21"), "open");
                Project project4 = new Project("Project4", DateTime.Parse("2014-12-21"), "closed");
                Project project5 = new Project("Project5", DateTime.Parse("2011-11-11"), "open");
                Project project6 = new Project("Project6", DateTime.Parse("2008-01-21"), "closed");

                Developer developer1 = new Developer(1, "Developer1", "Devski1", 2000, "Production", new List<Project> { project1, project2, project3 });
                Developer developer2 = new Developer(2, "Developer2", "Devski2", 3000, "Production", new List<Project> { project3, project4, project5 });
                Developer developer3 = new Developer(3, "Developer3", "Devski3", 4000, "Production", new List<Project> { project1, project3, project5 });
                //Console.WriteLine(developer1);

                Manager manager1 = new Manager(1, "Manager1", "Shefski1", 4000, "Accounting", new List<Employee> { petkoSelsa, developer1, goshoHubaveca });
                Manager manager2 = new Manager(2, "Manager2", "Shefski2", 5000, "Accounting", new List<Employee> { ginkaJunioara, developer2, developer3 });
                //Console.WriteLine(manager2); 

                List<Employee> employees = new List<Employee>{
                    petkoSelsa,
                    ginkaJunioara,
                    goshoHubaveca,
                    developer1,
                    developer2,
                    developer3,
                    manager1,
                    manager2
                };

                foreach (var employee in employees)
                {
                    Console.WriteLine(employee);
                    Console.WriteLine();
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

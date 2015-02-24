using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CommonTypeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer penka = new Customer("Penka", "Penkova", "Penkova", 89342342254, "Sofia, Dyrvenica bl.47",
                                          "+3598822352435", "penka@abv.bg", new List<Payment>() { new Payment("beer", 2), 
                                          new Payment("rakia", 5.60) }, CustomerType.Regular);

            Customer ginka = new Customer("Ginka", "Ginkova", "Ginkova", 8934342254, "Sofia, Mladost bl.47",
                                          "+35988223452435", "ginka@abv.bg", new List<Payment>() { new Payment("cola", 2), 
                                          new Payment("bread", 0.85) }, CustomerType.Golden);

            Customer pesho = new Customer("Pesho", "Petrov", "Petrov", 8934342254, "Bourgas, Mladost bl.21",
                                          "+359871152435", "pesho66@abv.bg", new List<Payment>() { new Payment("victory", 5.9), 
                                          new Payment("salata", 0.65) }, CustomerType.Diamond);

            // test equal
            if (penka == ginka)
            {
                Console.WriteLine("They are equal, because they have the same ID:{0}", penka.ID);
            }
            
            if (penka != ginka)
            {
                Console.WriteLine("They are not equal, because they have different IDs:{0} and {1}", penka.ID, ginka.ID);
            }

            Console.WriteLine();

            // make the ID the same and test equal again
            ginka.ID = penka.ID;

            if (penka == ginka)
            {
                Console.WriteLine("They are equal, because they have the same ID:{0}", penka.ID);
            }

            if (penka != ginka)
            {
                Console.WriteLine("They are not equal, because they have different IDs:{0} and {1}", penka.ID, ginka.ID);
            }

            Console.WriteLine();

            // test ToString()
            Console.WriteLine(pesho);

            Console.WriteLine();

            // test getHashCode
            Console.WriteLine(pesho.GetHashCode());

            Console.WriteLine();

            // test Copy
            Customer penka2 = (Customer)penka.Clone();
            Console.WriteLine(penka2);

            // test the deep copy - add new payment and change the price of existing payments
            Console.WriteLine();
            Console.WriteLine("Add payment zele 1,45 to penka2 and change the prices of penka payments:");
            foreach (var payment in penka.Payments)
            {
                payment.Price += 100;
            }
            penka.Payments.Add(new Payment("zele", 1.45));
            
            Console.WriteLine(penka);
            Console.WriteLine(penka2);

            Customer[] customers = new Customer[] {
                penka,
                penka2,
                pesho,
                ginka
            };

            Console.WriteLine();

            // test compare by name
            penka2.FirstName = "Penkb";

            if (penka > penka2)
            {
                Console.WriteLine("{0} {1} > {2} {3}", penka.FullName, penka.ID, penka2.FullName, penka2.ID);
            } 
            else if (penka < penka2)
            {
                Console.WriteLine("{0} {1} < {2} {3}", penka.FullName, penka.ID, penka2.FullName, penka2.ID);
            }
            else
            {
                Console.WriteLine("{0} {1} == {2} {3}", penka.FullName, penka.ID, penka2.FullName, penka2.ID);
            }


            // test compare by ID when the name is the same
            penka2.FirstName = "Penka";
            penka2.ID = 89142342254;
            if (penka > penka2)
            {
                Console.WriteLine("{0} {1} > {2} {3}", penka.FullName, penka.ID, penka2.FullName, penka2.ID);
            }
            else if (penka < penka2)
            {
                Console.WriteLine("{0} {1} < {2} {3}", penka.FullName, penka.ID, penka2.FullName, penka2.ID);
            }
            else
            {
                Console.WriteLine("{0} {1} == {2} {3}", penka.FullName, penka.ID, penka2.FullName, penka2.ID);
            }
        
        }
    }
}

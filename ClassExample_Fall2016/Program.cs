using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample_Fall2016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the beginning of our class example.");

            ////our first person instance
            //Person thisPerson = new Person();
            //thisPerson.Greet("Jarryd");

            //Console.WriteLine();

            ////Our second person instance
            //Person secondPerson = new Person(25, "Lupe", "Purple", "Whattup?");
            //secondPerson.greeting = "How's it going?";
            //secondPerson.Greet("Clone Jarryd");

            Student freshman = new Student("John Doe", 19, "University School", "Underwater Basket Weaving", 3.0);

        }
    }
}

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

            Person thisPerson = new Person();

            thisPerson.Greet("Jarryd");

            Console.WriteLine();

            Person secondPerson = new Person();

            secondPerson.Greet("Clone Jarryd");
        }
    }
}

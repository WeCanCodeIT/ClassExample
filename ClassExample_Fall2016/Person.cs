using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample_Fall2016
{
    class Person
    {
        //fields
        private int age;
        private string name;

        private string eyeColor;

        public string greeting;

        //Properties

        //Constructors
        public Person()
        {
            age = 20;
            name = "John Doe";
            eyeColor = "Brown";
            greeting = "Nice to meet you.";
        }

        //Methods

        //This method takes a string input, then prints out a greeting for a person
        public void Greet(string name)
        {
            //provide the output for this method
            Console.WriteLine("Hello " + name + ". "+ greeting);
            Console.WriteLine(Description());
        }

        // returns the person's name and age in a description in a string
        private string Description()
        {
            int age;
            age = 20;

            //the temporary string we're using to build our return
            string tempString;

            //building our temporary string
            tempString = "I am " + name + " and I am " + age + " years old.";

            //returning the result
            return tempString;
        }
    }
}

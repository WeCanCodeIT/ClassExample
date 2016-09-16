using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample_Fall2016
{
    class Student
    {
        //Fields
        private string fullName;
        private int age;
        private string university;
        private string major;
        private float gpa;       

        //Properties



        //Constructors
        public Student()
        {

        }

        public Student(string fullName, int age, string university, string major, float gpa)
        {
            this.fullName = fullName;
            this.age = age;
            this.university = university;
            this.major = major;
            this.gpa = gpa;
        }

        //Methods
    }
}

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
        private float gpa;       

        //Properties
        public string Name
        {
            get{ return this.fullName; }
            set { this.fullName = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string University
        {
            get { return this.university; }
        }

        public string Major
        {
            get;
            set;
        }

        public float GPA
        {
            get { return this.gpa; }
            set { this.gpa = value; }  
        }

        //Constructors
        public Student()
        {

        }

        public Student(string fullName, int age, string university, string major, float gpa)
        {
            this.fullName = fullName;
            this.age = age;
            this.university = university;
            this.Major = major;
            this.gpa = gpa;
        }

        //Methods
    }
}

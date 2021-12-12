using System;
using System.Collections.Generic;
using System.Text;

namespace UpcastDowncast.Models
{
    class Student : Teacher
    {
        private int age;
        private string name;

        public int Age
        {
            get { return age; }
            set
            {
                if(value < 18)
                {
                    age = 18;
                }
                else
                {
                    age = value;
                }
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int BookCount { get; set; }
        public override void Drink()
        {
            Console.WriteLine("Student is drinking");
        }
        public override void Work()
        {
            Console.WriteLine("Student is working");
        }
    }
}

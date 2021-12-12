using System;
using System.Collections.Generic;
using System.Text;

namespace UpcastDowncast.Models
{
    abstract class Person
    {
        public string Name;
        public abstract void Drink();
        public virtual void Work()
        {
            Console.WriteLine("Person's work");
        }

        
    }
}

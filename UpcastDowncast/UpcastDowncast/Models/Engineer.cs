using System;
using System.Collections.Generic;
using System.Text;

namespace UpcastDowncast.Models
{
    class Engineer : Man
    {
        public bool IsRich { get; set; }

        public override void Work()
        {
            Console.WriteLine("Engineer is working");
        }
        public override void Drink()
        {
            Console.WriteLine("Engineer is drinking");
        }
    }
}

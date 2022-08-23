using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Car
    { 
        // static constructor
        static Car()
        {
            Console.WriteLine("Static Constructor");
        }
        // parameterless constructor
        Car()
        {
            Console.WriteLine("Default Constructor");
        }
        static void Main(string[] args)
        {
            // call parameterless constructor
            Car car1 = new Car();
            // call parameterless constructor again
            Car car2 = new Car();
            Console.ReadLine();
        }
    }
}

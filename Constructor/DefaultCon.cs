using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class DefaultCon
    {
        int number;
       public static void Main(string[] args)
        {
            DefaultCon con = new DefaultCon();
            Console.WriteLine("The value of number is " + con.number);
            Console.ReadLine();
        }
    }
}

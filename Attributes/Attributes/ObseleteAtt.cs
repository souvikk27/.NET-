using System;
using System.Diagnostics;

namespace Attributes
{
    public class Solution
    {
        [Obsolete("Dont use old method, use new method instead!" , true)]
        static void OldMethod()
        {
            Console.WriteLine("This is old method!");
        }
        static void NewMethod()
        {
            Console.WriteLine("This is new method!");
        }

        public static void Main()
        {
            OldMethod();
        }
    }
}

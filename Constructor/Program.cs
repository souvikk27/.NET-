using System;

namespace Constructor
{
    public class Con
    {
        int someNumber;
        public Con(int num)
        {
            someNumber = num;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter random Number ");
            int someNumber = int.Parse(Console.ReadLine());
            Con x = new(someNumber);
            Console.WriteLine("This Number " + x.someNumber);
        }
    }
}
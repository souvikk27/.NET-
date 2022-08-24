using System;


namespace Async_Function_Lambda_Expression
{
    class Example
    {
        public static void Main(string[] args)
        {
            Func<int, int, int> multi = (x, y) => { return x * y; };
            Console.WriteLine(multi(5, 2));
        }
    }
}

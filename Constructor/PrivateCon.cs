namespace Constructor
{
    class PrivateCon
    {
        // private constructor
        private PrivateCon()
        {
            Console.WriteLine("Private Constructor");
        }
    }
    class SecondClass
    {
        static void Main(string[] args)
        {
            // call private constructor
            PrivateCon car1 = new PrivateCon();
            Console.ReadLine();
        }
    }
}

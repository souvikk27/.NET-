using System;

namespace Property
{
    class PropertyExample
    {
        private string name;
        public string Name
        {
            get { 
                return name; 
            }
            set { 
                name = value; 
            }
        }
        public static void Main(string[] args)
        {
            var prop = new PropertyExample();
            prop.Name = "Souvik";
            Console.WriteLine(prop.Name);
            Console.ReadLine();
        }
    }
}
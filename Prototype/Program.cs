using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Person original = new Person
            {
                FirstName = "Denys",
                LastName = "Senkov",
                Age = 20
            };
            Person clone = (Person)original.Clone();

            Console.WriteLine("Original: " + original.ToString());
            Console.WriteLine("Clone: " + clone.ToString());

            Console.ReadKey();
        }
    }
}

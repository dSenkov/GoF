using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            Console.WriteLine("Hash of the 1st - " + s1.GetHashCode());
            Console.WriteLine("Hash of the 2nd - " + s2.GetHashCode());

            Console.ReadKey();
        }
    }
}

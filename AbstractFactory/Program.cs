using AbstractFactory.Factories;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------- ELFS -------------------------");
            CreateAndUseSoldiers(new ElfFactory());

            Console.WriteLine("\n\n------------------------ HOBBITS ------------------------");
            CreateAndUseSoldiers(new HobbitFactory());

            Console.WriteLine("\n\n------------------------- ORKS -------------------------");
            CreateAndUseSoldiers(new OrkFactory());

            Console.ReadKey();
        }

        static void CreateAndUseSoldiers(AbstractSoldierFactory factory)
        {
            var archer = factory.CreateArcher();
            var mage = factory.CreateMage();
            var warrior = factory.CreateWarrior();

            Console.WriteLine(archer.ShootAnArrow());
            Console.WriteLine(mage.CastSpell());
            Console.WriteLine(warrior.Fight());
        }
    }
}

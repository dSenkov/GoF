using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Soldiers;
using AbstractFactory.Soldiers.Elfs;

namespace AbstractFactory.Factories
{
    class ElfFactory : AbstractSoldierFactory
    {
        public Archer CreateArcher()
        {
            return new ElfArcher();
        }

        public Mage CreateMage()
        {
            return new ElfMage();
        }

        public Warrior CreateWarrior()
        {
            return new ElfWarrior();
        }
    }
}

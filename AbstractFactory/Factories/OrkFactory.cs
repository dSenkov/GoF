using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Soldiers;
using AbstractFactory.Soldiers.Orks;

namespace AbstractFactory.Factories
{
    class OrkFactory : AbstractSoldierFactory
    {
        public Archer CreateArcher()
        {
            return new OrkArcher();
        }

        public Mage CreateMage()
        {
            return new OrkMage();
        }

        public Warrior CreateWarrior()
        {
            return new OrkWarrior();
        }
    }
}

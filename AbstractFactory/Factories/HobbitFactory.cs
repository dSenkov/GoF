using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Soldiers;
using AbstractFactory.Soldiers.Hobbits;

namespace AbstractFactory.Factories
{
    class HobbitFactory : AbstractSoldierFactory
    {
        public Archer CreateArcher()
        {
            return new HobbitArcher();
        }

        public Mage CreateMage()
        {
            return new HobbitMage();
        }

        public Warrior CreateWarrior()
        {
            return new HobbitWarrior();
        }
    }
}

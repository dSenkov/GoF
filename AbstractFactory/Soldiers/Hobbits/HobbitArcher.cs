using AbstractFactory.Soldiers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Soldiers.Hobbits
{
    class HobbitArcher : Archer
    {
        public string ShootAnArrow()
        {
            return "Hobbit archer is shooting";
        }
    }
}

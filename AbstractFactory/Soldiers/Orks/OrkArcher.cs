using AbstractFactory.Soldiers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Soldiers.Orks
{
    class OrkArcher : Archer
    {
        public string ShootAnArrow()
        {
            return "Ork archer is shooting";
        }
    }
}

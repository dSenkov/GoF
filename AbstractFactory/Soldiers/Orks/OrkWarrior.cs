using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Soldiers.Orks
{
    class OrkWarrior : Warrior
    {
        public string Fight()
        {
            return "Ork warrior is fighting";
        }
    }
}

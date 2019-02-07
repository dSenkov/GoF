using AbstractFactory.Soldiers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Soldiers.Hobbits
{
    class HobbitMage : Mage
    {
        public string CastSpell()
        {
            return "Hobbit mage is casting spells";
        }
    }
}

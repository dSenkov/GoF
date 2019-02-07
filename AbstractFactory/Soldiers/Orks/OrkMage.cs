using AbstractFactory.Soldiers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Soldiers.Orks
{
    class OrkMage : Mage
    {
        public string CastSpell()
        {
            return "Ork mage is casting spells";
        }
    }
}

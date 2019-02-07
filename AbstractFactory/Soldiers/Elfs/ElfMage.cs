using AbstractFactory.Soldiers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Soldiers.Elfs
{
    class ElfMage : Mage
    {
        public string CastSpell()
        {
            return "Elf mage is casting spells";
        }
    }
}

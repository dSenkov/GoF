using AbstractFactory.Soldiers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Soldiers.Elfs
{
    class ElfArcher : Archer
    {
        public string ShootAnArrow()
        {
            return "Elf archer is shooting";
        }
    }
}

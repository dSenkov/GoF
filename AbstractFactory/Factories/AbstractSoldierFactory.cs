using AbstractFactory.Soldiers;

namespace AbstractFactory.Factories
{
    public interface AbstractSoldierFactory
    {
        Archer CreateArcher();
        Mage CreateMage();
        Warrior CreateWarrior();
    }
}

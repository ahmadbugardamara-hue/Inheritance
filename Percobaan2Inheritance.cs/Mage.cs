using System;

namespace GameInheritanceDemo
{
    public class Mage : Character
    {
        public int spellPower;

        // Konstruktor Default
        public Mage()
        {
            Console.WriteLine("----> Konstruktor default Mage <----");
        }

        // Konstruktor Berparameter
        public Mage(int spellPower, string id, string name, int basePower, string address)
            : base(id, name, basePower, address)
        {
            Console.WriteLine("----> Konstruktor berparameter Mage <----");
            this.spellPower = spellPower;
        }

        public void DisplayData()
        {
            base.DisplayBaseData();

            Console.WriteLine("SPELL POWER    : " + spellPower);
            Console.WriteLine("TOTAL POWER    : " + (GetBasePower() + spellPower));
            Console.WriteLine("========================");
        }
    }
}
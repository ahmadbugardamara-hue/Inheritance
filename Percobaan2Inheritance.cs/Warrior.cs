using System;

namespace GameInheritanceDemo
{
    public class Warrior : Character
    {
        public int bonus;

        // Konstruktor Default
        public Warrior() : base()
        {
            Console.WriteLine("----> Konstruktor default Warrior <----");
        }

        // Konstruktor Berparameter
        public Warrior(int bonus, string id, string name, int basePower, string address)
            : base(id, name, basePower, address)
        {
            Console.WriteLine("----> Konstruktor berparameter Warrior <----");
            this.bonus = bonus;
        }

        // Method untuk menampilkan data Warrior
        public void DisplayData()
        {
            base.DisplayBaseData();

            Console.WriteLine("BONUS          : " + bonus);
            Console.WriteLine("TOTAL POWER    : " + (GetBasePower() + bonus));
            Console.WriteLine("========================");
        }
    }
}
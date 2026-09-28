using System;

namespace GameInheritanceDemo
{
    public class Character
    {
        // Atribut private (encapsulated)
        private string characterID;
        private string name;
        private int basePower;
        private string address;

        // Konstruktor Default
        public Character()
        {
            Console.WriteLine("----> Konstruktor default Character <----");
        }

        // Konstruktor Berparameter
        public Character(string id, string name, int basePower, string address)
        {
            Console.WriteLine("----> Konstruktor berparameter Character <----");

            this.characterID = id;
            this.name = name;
            this.basePower = basePower;
            this.address = address;
        }

        // Method untuk menampilkan data dasar
        public void DisplayBaseData()
        {
            Console.WriteLine("CHARACTER ID   : " + characterID);
            Console.WriteLine("NAME           : " + name);
            Console.WriteLine("BASE POWER     : " + basePower);
            Console.WriteLine("ADDRESS        : " + address);
        }

        // Getter untuk atribut yang dibutuhkan oleh subclass
        public int GetBasePower()
        {
            return basePower;
        }
    }
}
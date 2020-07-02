using System;
using System.Collections.Generic;
namespace ExamenLMR
{
    public class Player : Person
    {
        private int attack;
        private int defense;
        private int number;
        private string position;
        private bool injury;
        public Player(int attack, int defense, int number, string position, string name, int age, string nation, string salary) : base (name, age, nation, salary)
        {
            this.attack = attack;
            this.defense = defense;
            this.number = number;
            this.position = position;
        }
        public string GetName()
        {
            return name;
        }
        public string GetNation()
        {
            return nation;
        }
        public int GetAge()
        {
            return age;
        }
        public string GetSalary()
        {
            return salary;
        }
    }
}

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
        private bool injury = false;
        public Player(int attack, int defense, int number, string position, bool injury, string name, int age, string nation, string salary) : base (name, age, nation, salary)
        {
            this.attack = attack;
            this.defense = defense;
            this.number = number;
            this.position = position;
            this.injury = injury;
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
        public string GetPosition()
        {
            return position;
        }
        public delegate void InjuryEventHandler(object source, InjuryEventArgs args);
        public event InjuryEventHandler Injuried;
        protected virtual void OnInjuried(bool injury)
        {
            if (Injuried != null)
            {
                Injuried(this, new InjuryEventArgs() { Injury = injury });
            }
        }
        public void checkinjury()
        {
            if(injury == true)
            {
                Console.WriteLine("Estoy Lesionado necesito un cambio!");
                OnInjuried(injury);
            }
        }
        public void heal()
        {
            injury = false;
        }
    }
}

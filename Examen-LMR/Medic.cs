using System;
using System.Collections.Generic;
namespace ExamenLMR
{
    public class Medic : Person,IEvaluation,IHealing
    {
        private int exp;

        public Medic(int exp, string name, int age, string nation, string salary) : base (name, age, nation, salary)
        {
            this.exp = exp;
        }
        public string evaluation(Player player)
        {
            string name = player.GetName();
            string evaluation = $"Estoy evaluando a {name}";
            return evaluation;
        }
        public string Healing(Player player)
        {
            string name = player.GetName();
            string healing = $"Estoy curando a {name}";
            return healing;
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

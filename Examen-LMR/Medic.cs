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
        public void evaluation(List<Player> players)
        {
            Console.WriteLine("Evaluando Plantel...");
            foreach(Player player in players)
            {
                if (player.GetInjury() == true)
                {
                    Console.WriteLine($"{player.GetName()} tiene una lesion. Voy a curarlo...");
                    player.heal();
                    Console.WriteLine("Jugador curado con exito");
                }
                else
                {
                    Console.WriteLine($"{player.GetName()} no tiene ninguna lesion.");
                }
                
            }
            
        }
        public string Healing(Player player)
        {
            string name = player.GetName();
            string healing = $"Estoy curando a {name}";
            player.heal();
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

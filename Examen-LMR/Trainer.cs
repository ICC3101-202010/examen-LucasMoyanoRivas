using System;
using System.Collections.Generic;
namespace ExamenLMR
{
    public class Trainer : Person, IChange
    {
        private int tactics;

        public Trainer(int tactics, string name, int age, string nation, string salary) : base(name, age, nation, salary)
        {
            this.tactics = tactics;
        }
        public string change(Player player1, Player player2)
        {
            string jugador1 = player1.GetName();
            string jugador2 = player2.GetName();
            string change = $"Se ha cambiado a {jugador1} por {jugador2}";
            return change;
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
        public void OnInjuriedChange(object source, EventArgs args)
        {
            Console.WriteLine("Realizando cambio de jugador!");
        }
    }
}

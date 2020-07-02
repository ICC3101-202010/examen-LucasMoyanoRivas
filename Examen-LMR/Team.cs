using System;
using System.Collections.Generic;
namespace ExamenLMR
{
    public class Team
    {
        private List<Player> team = new List<Player>();
        private Trainer trainer;
        private Medic medic;
        private string name;
        private string typeofteam;
        public Team(List<Player> team, string name, string typeofteam, Medic medic, Trainer trainer)
        {
            this.team = team;
            this.name = name;
            this.typeofteam = typeofteam;
            this.medic = medic;
            this.trainer = trainer;
        }
        public bool nationteam (List<Player> team)
        {
            int a = 0;
            bool result = true;
            if (typeofteam == "Nacional")
            {
                
                foreach (Player player in team)
                {
                    if (player.GetNation() != name)
                    {
                        a = 1;
                        break;
                    }
                }
                if (a == 1)
                {
                    result = false;

                }
                if (a == 0)
                {
                    result = true;
                }
                return result;
            }
            else
            {
                result = false;
                return result;
            }
        }
        public string GetTypeOfTeam()
        {
            return typeofteam;
        }
        public void addplayerteam(Player player)
        {
            if(team.Count < 15)
            {
                team.Add(player);
            }
            else
            {
                Console.WriteLine("Ya hay un total de 15 jugadores en el equipo");
            }         
        }
        public List<Player> GetTeam()
        {
            return team;
        }
        public Trainer GetTrainer()
        {
            return trainer;
        }
        public Medic GetMedic()
        {
            return medic;
        }
        public string GetName()
        {
            return name;
        }
        public void InformationTeam()
        {
            Console.WriteLine("El equipo se conforma por 15 jugadores:");
            foreach(Player player in team)
            {
                Console.WriteLine($"Nombre: {player.GetName()} Posicion: {player.GetPosition()}");
            }
            Console.WriteLine("El medico del equipo es:");
            Console.WriteLine(medic.GetName());
            Console.WriteLine("El entrenador del equipo es:");
            Console.WriteLine(trainer.GetName());
        }
        public List<Player> CreateTeam()
        {
            List<Player> team1 = new List<Player>();

            foreach (Player player in team)
            {
                if (team1.Count < 12)
                {
                    team1.Add(player);

                }
            }
            return team1;
        }
    }
}

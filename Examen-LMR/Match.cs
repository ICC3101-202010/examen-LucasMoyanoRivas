using System;
using System.Collections.Generic;
namespace ExamenLMR
{
    public class Match
    {
        private List<Team> Teams = new List<Team>();
        private int minutes;
        private string result;
        private string typeofmatch;
        public Match(List<Team> Teams, int minutes, string result, string typeofmatch)
        {
            this.Teams = Teams;
            this.minutes = minutes;
            this.result = result;
            this.typeofmatch = typeofmatch;
        }
        public bool checkteam ()
        {
            List <string> teams = new List<string>();
            foreach (Team team in Teams)
            {
                teams.Add(team.GetTypeOfTeam());
            }
            if(teams[0] == teams[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void creatematch()
        {
            bool check = true;
            List<string> teams = new List<string>();
            foreach (Team team in Teams)
            {
                teams.Add(team.GetTypeOfTeam());
            }
            if (teams[0] == teams[1])
            {
                check = true;
            }
            else
            {
                check = false;
            }
            if (check == true)
            {
                Console.WriteLine("Creando partido...\n");
                Console.WriteLine("Equipo1: \n");
                foreach(Player player in Teams[0].CreateTeam())
                {
                    Console.WriteLine($"Nombre: {player.GetName()} Posicion: {player.GetPosition()}");
                }

                Console.WriteLine("Equipo2: \n");
                foreach (Player player in Teams[1].CreateTeam())
                {
                    Console.WriteLine($"Nombre: {player.GetName()} Posicion: {player.GetPosition()}");
                }
            }
            else
            {
                Console.WriteLine("No se pudo crear el partido ya que son equipos mezclados.");
            }
        }
        public List<Team> GetTeams()
        {
            return Teams;
        }
    }
}
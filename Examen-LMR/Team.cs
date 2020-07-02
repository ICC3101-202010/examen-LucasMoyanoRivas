using System;
using System.Collections.Generic;
namespace ExamenLMR
{
    public class Team
    {
        private List<Player> team = new List<Player>();
        private string name;
        private string typeofteam;
        public Team(List<Player> team, string name, string typeofteam)
        {
            this.team = team;
            this.name = name;
            this.typeofteam = typeofteam;
        }
        public bool nationteam (List<Player> team)
        {
            int a = 0;
            bool result = true;
            List<string> nacionalidad = new List<string>();
            foreach (Player player in team)
            {
                nacionalidad.Add(player.GetNation());
            }
            foreach (string nation in nacionalidad)
            {
                if (nacionalidad.Contains(nation))
                {
                }
                else
                {
                    a = 1;
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
        public string GetTypeOfTeam()
        {
            return typeofteam;
        }
        public 
    }
}

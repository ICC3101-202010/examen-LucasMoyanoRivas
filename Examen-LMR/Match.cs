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
        public bool checkteam (List<Team> Teams)
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

    }
}

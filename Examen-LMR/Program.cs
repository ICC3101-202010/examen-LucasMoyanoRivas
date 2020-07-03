using System;
using System.Collections.Generic;
namespace ExamenLMR
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Solo para probar cree esto.
            List <Team> listofteams = new List<Team>();
            //Equipo1 misma nacionalidad
            List <Player> team11 = new List<Player>();
            Medic medic1 = new Medic(100, "Lia", 25, "Chile", "$20.000");
            Trainer trainer1 = new Trainer(100, "Jorge Sampaoli", 40, "Argentina", "$40.000");
            Team team1 = new Team(team11, "Chile", "Nacional", medic1, trainer1);
            Player player1 = new Player(1, 60, 1, "Arquero", false, "Justin", 20, "Chile", "$2.000");
            Player player2 = new Player(5, 30, 3, "Defensa", false, "Andres", 20, "Chile", "$8.000");
            Player player3 = new Player(6, 40, 4, "Defensa", false, "Carlos", 20, "Chile", "$7.000");
            Player player4 = new Player(10, 20, 2, "Defensa", false, "Agustin", 20, "Chile", "$15.000");
            Player player5 = new Player(20, 10, 7, "Mediocampista", false, "Lucas", 20, "Chile", "$20.000");
            Player player6 = new Player(4, 40, 5, "Mediocampista", false, "Daslav", 20, "Chile", "$6.000");
            Player player7 = new Player(3, 30, 6, "Mediocampista", false, "Branko", 20, "Chile", "$3.000");
            Player player8 = new Player(2, 50, 8, "Mediocampista", false, "Alex", 20, "Chile", "$1.000");
            Player player9 = new Player(30, 5, 9, "Delantero", false, "Diego", 20, "Chile", "$30.000");
            Player player10 = new Player(40, 5, 10, "Delantero", false, "Jose Tomas", 20, "Chile", "$10.000");
            Player player11 = new Player(45, 5, 11, "Delantero", false, "Luis", 20, "Chile", "$5.000");
            Player player12 = new Player(20, 10, 22, "Mediocampista", false, "Esteban", 20, "Chile", "$1.000");
            Player player13 = new Player(30, 5, 15, "Mediocampista", false, "Mirko", 20, "Chile", "$2.000");
            Player player14 = new Player(40, 5, 14, "Delantero", false, "Hernan", 20, "Chile", "$3.000");
            Player player15 = new Player(45, 5, 18, "Delantero", false, "Joaquin", 20, "Chile", "$4.000");
            //Equipo2 distinta nacionalidad
            List<Player> team12 = new List<Player>();
            Medic medic2 = new Medic(100, "Vignys", 55, "Chile", "$30.000");
            Trainer trainer2 = new Trainer(100, "Juan Antonio Pizzi", 45, "Argentina", "$30.000");
            Team team2 = new Team(team12, "Colo-Colo", "Liga", medic2, trainer2);
            Player player16 = new Player(1, 60, 1, "Arquero", false, "Justin", 20, "Chile", "$2.000");
            Player player17 = new Player(5, 30, 3, "Defensa", false, "Andres", 20, "Chile", "$8.000");
            Player player18 = new Player(6, 40, 4, "Defensa", false, "Carlos", 20, "Chile", "$7.000");
            Player player19 = new Player(10, 20, 2, "Defensa", false, "Edgardo", 20, "Peru", "$15.000");
            Player player20 = new Player(20, 10, 7, "Mediocampista", false, "Lucas", 20, "Argentina", "$20.000");
            Player player21 = new Player(4, 40, 5, "Mediocampista", false, "Daslav", 20, "Chile", "$6.000");
            Player player22 = new Player(3, 30, 6, "Mediocampista", false, "Branko", 20, "Venezuela", "$3.000");
            Player player23 = new Player(2, 50, 8, "Mediocampista", false, "Alex", 20, "Chile", "$1.000");
            Player player24 = new Player(30, 5, 9, "Delantero", false, "Diego", 20, "Brasil", "$30.000");
            Player player25 = new Player(40, 5, 10, "Delantero", false, "Jose Tomas", 20, "Chile", "$10.000");
            Player player26 = new Player(45, 5, 11, "Delantero", false, "Luis", 20, "Chile", "$5.000");
            Player player27 = new Player(20, 10, 22, "Mediocampista", false, "Esteban", 20, "Chile", "$1.000");
            Player player28 = new Player(30, 5, 15, "Mediocampista", false, "Mirko", 20, "Chile", "$2.000");
            Player player29 = new Player(40, 5, 14, "Delantero", false, "Hernan", 20, "Brasil", "$3.000");
            Player player30 = new Player(45, 5, 18, "Delantero", false, "Guillermo", 20, "Chile", "$4.000");
            team1.addplayerteam(player1);
            team1.addplayerteam(player2);
            team1.addplayerteam(player3);
            team1.addplayerteam(player4);
            team1.addplayerteam(player5);
            team1.addplayerteam(player6);
            team1.addplayerteam(player7);
            team1.addplayerteam(player8);
            team1.addplayerteam(player9);
            team1.addplayerteam(player10);
            team1.addplayerteam(player11);
            team1.addplayerteam(player12);
            team1.addplayerteam(player13);
            team1.addplayerteam(player14);
            team1.addplayerteam(player15);
            team2.addplayerteam(player16);
            team2.addplayerteam(player17);
            team2.addplayerteam(player18);
            team2.addplayerteam(player19);
            team2.addplayerteam(player20);
            team2.addplayerteam(player21);
            team2.addplayerteam(player22);
            team2.addplayerteam(player23);
            team2.addplayerteam(player24);
            team2.addplayerteam(player25);
            team2.addplayerteam(player26);
            team2.addplayerteam(player27);
            team2.addplayerteam(player28);
            team2.addplayerteam(player29);
            team2.addplayerteam(player30);
            listofteams.Add(team1);
            listofteams.Add(team2);
            Match match = new Match(listofteams, 90, "2-1", "Nacional");
            player1.Injuried += trainer1.OnInjuriedChange;
            player1.Injuried += match.OnInjuriedChange;
            if (team1.nationteam(team1.GetTeam()) == true)
            {
                Console.WriteLine("Es un equipo nacional");

            }
            else
            {
                Console.WriteLine("No es un equipo nacional");
            }
            team1.InformationTeam();
            if (match.checkteam() == true)
            {
                Console.WriteLine("Es un partido valido");
                if(match.GetTeams()[0].GetTypeOfTeam() == "Nacional")
                {
                    Console.WriteLine("Nacional");
                }
                if (match.GetTeams()[0].GetTypeOfTeam() == "Liga")
                {
                    Console.WriteLine("de Liga");
                }

            }
            else
            {
                Console.WriteLine("No es un partido valido");
            }
            match.creatematch();
        }
    }
}

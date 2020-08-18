using LSPPrinciple.GoodPractice;
using System;

namespace LSPPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayer player = new TennisPlayer();
            //ITeamPlayer player = new FootballPlayer();
            player.FirstName = "Faustino";
            player.LastName = "Asprilla";
            //player.AssignTeam(new Team { Name = "Atl. Nacional." });
            player.SetCategory(PlayerCategory.Professional);

            Console.WriteLine($"{player.FirstName}, {player.LastName} Category {player.Category}");

            Console.ReadLine();
        }
    }
}

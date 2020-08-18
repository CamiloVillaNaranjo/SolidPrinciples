using System;
using System.Collections.Generic;
using System.Text;

namespace LSPPrinciple.GoodPractice
{
    public class FootballPlayer: Player, ITeamPlayer
    {
        private Team Team { get; set; }
        public string GetTeam() => Team.Name;
        public virtual void AssignTeam(Team team)
        {
            Team = team;
        }
        public string GetMarketValue(PlayerCategory category)
        {
            string marketValue = "";
            switch (category)
            {
                case PlayerCategory.Amateur:
                    marketValue = "100";
                    break;
                case PlayerCategory.Professional:
                    marketValue = "1000";
                    break;
            }
            return marketValue;
        }
    }
}

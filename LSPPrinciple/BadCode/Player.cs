using System;
using System.Collections.Generic;
using System.Text;

namespace LSPPrinciple.BadPractice
{
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private Team Team { get; set; }
        public PlayerCategory Category { get; set; }
        public string GetTeam() => Team.Name;
        public virtual void AssignTeam(Team team)
        {
            Team = team;
        }

        public virtual void SetCategory(PlayerCategory category)
        {
            Category = category;
        }
    }
}

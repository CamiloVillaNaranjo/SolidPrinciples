using System;
using System.Collections.Generic;
using System.Text;

namespace LSPPrinciple.GoodPractice
{
    public interface ITeamPlayer : IPlayer
    {
        public void AssignTeam(Team team);
        public string GetTeam();
    }
}

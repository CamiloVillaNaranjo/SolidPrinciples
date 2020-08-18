using System;
using System.Collections.Generic;
using System.Text;

namespace LSPPrinciple.BadPractice
{
    public class TennisPlayer: Player
    {
        public override void AssignTeam(Team team)
        {
            base.AssignTeam(team);
            throw new NotImplementedException("I am Tennis Player, I do not need a Team.");
        }
    }
}

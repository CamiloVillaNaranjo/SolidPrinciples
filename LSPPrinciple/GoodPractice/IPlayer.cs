using System;
using System.Collections.Generic;
using System.Text;

namespace LSPPrinciple.GoodPractice
{
    public interface IPlayer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PlayerCategory Category { get; set; }
        public void SetCategory(PlayerCategory category);
    }
}

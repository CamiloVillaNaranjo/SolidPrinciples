using System;
using System.Collections.Generic;
using System.Text;

namespace LSPPrinciple.GoodPractice
{
    public class Player : IPlayer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PlayerCategory Category { get; set; }
        public virtual void SetCategory(PlayerCategory category)
        {
            Category = category;
        }
    }
}

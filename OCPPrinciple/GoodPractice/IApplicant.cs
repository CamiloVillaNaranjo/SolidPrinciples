﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OCPPrinciple.GoodPractice
{
    public interface IApplicant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccountService Identifier { get; set; }

    }
}

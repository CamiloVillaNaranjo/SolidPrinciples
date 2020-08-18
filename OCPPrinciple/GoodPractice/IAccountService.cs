using System;
using System.Collections.Generic;
using System.Text;

namespace OCPPrinciple.GoodPractice
{
    public interface IAccountService
    {
        Staff Create(IApplicant person);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OCPPrinciple.GoodPractice
{
    public class AccountDoctor : IAccountService
    {
        public Staff Create(IApplicant person)
        {
            Staff newStaff = new Staff();

            newStaff.FirstName = person.FirstName;
            newStaff.LastName = person.LastName;
            newStaff.Email = $"{person.FirstName}.{person.LastName}@doctor.com";

            return newStaff;
        }
    }
}

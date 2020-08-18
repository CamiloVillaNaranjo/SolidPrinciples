using System;
using System.Collections.Generic;
using System.Text;

namespace OCPPrinciple.BadPractice
{
    public class AccountService
    {
        public Staff Create(Person person)
        {
            Staff newStaff = new Staff();

            newStaff.FirstName = person.FirstName;
            newStaff.LastName = person.LastName;
            newStaff.Email = $"{person.FirstName}.{person.LastName}@staff.com";

            return newStaff;
        }
    }
}

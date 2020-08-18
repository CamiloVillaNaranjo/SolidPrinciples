using System;
using System.Collections.Generic;
using System.Text;

namespace DIPPrinciple.GoodCode
{
    public interface IEmployeeQueryable
    {
        int GetCountOfEmployeesByGenderAndRole(Gender gender, Role role);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DIPPrinciple.GoodCode
{
    public class EmployeeSearch
    {
        private readonly IEmployeeQueryable _employeeManager;

        public EmployeeSearch(IEmployeeQueryable employeeManager)
        {
            this._employeeManager = employeeManager;
        }

        public int GetMaleExecutives()
        {
            return _employeeManager.GetCountOfEmployeesByGenderAndRole(Gender.Male,Role.Executive);
        }
    }
}

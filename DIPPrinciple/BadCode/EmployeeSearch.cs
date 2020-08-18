using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DIPPrinciple.BadCode
{
    public class EmployeeSearch
    {
        private readonly EmployeeManager _employeeManager;
        public EmployeeSearch(EmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        public int GetMaleExecutives()
        {
            return _employeeManager.Employees.Count(x => x.Gender== Gender.Male && x.Role == Role.Executive);
        }
    }
}

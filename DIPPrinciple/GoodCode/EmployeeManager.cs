using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPPrinciple.GoodCode
{
    public class EmployeeManager : IEmployeeQueryable
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public void Save(Employee employee)
        {
            _employees.Add(employee);
        }

        public int GetCountOfEmployeesByGenderAndRole(Gender gender, Role role)
        {
            return _employees.Count(x => x.Gender == gender && x.Role == role);
        }
    }
}

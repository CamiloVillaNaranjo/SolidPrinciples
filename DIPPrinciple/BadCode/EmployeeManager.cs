using System;
using System.Collections.Generic;
using System.Text;

namespace DIPPrinciple.BadCode
{
    public class EmployeeManager
    {
        public readonly List<Employee> _employees = new List<Employee>();

        public void Save(Employee employee)
        {
            _employees.Add(employee);
        }

        public List<Employee> Employees => _employees;
    }
}

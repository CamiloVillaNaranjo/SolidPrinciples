using System;
using System.Collections.Generic;

namespace DIPPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            BadCodeApproach();
            GoodCodeApproach();
        }

        static void BadCodeApproach()
        {
            var employees = new List<BadCode.Employee>()
            {
                new BadCode.Employee{Name = "Roberto", Gender= BadCode.Gender.Male, Role = BadCode.Role.Developer},
                new BadCode.Employee{Name = "Claudia", Gender= BadCode.Gender.Female, Role = BadCode.Role.Executive},
                new BadCode.Employee{Name = "Paulo", Gender= BadCode.Gender.Male, Role = BadCode.Role.Executive},
                new BadCode.Employee{Name = "Emmanuel", Gender= BadCode.Gender.Male, Role = BadCode.Role.Executive}
            };

            var employeeManager = new BadCode.EmployeeManager();

            foreach (var employee in employees)
            {
                employeeManager.Save(employee);
            }

            var search = new BadCode.EmployeeSearch(employeeManager);

            Console.WriteLine($"Cantidad de Empleados Ejecutivos y de genero Masculino:{search.GetMaleExecutives()}");

            Console.ReadLine();
        }

        static void GoodCodeApproach()
        {
            var employees = new List<GoodCode.Employee>
            {
                new GoodCode.Employee{Name="Ruben", Gender=GoodCode.Gender.Male, Role = GoodCode.Role.Developer},
                new GoodCode.Employee{Name="Dorian", Gender=GoodCode.Gender.Male, Role = GoodCode.Role.Executive},
                new GoodCode.Employee{Name="Luisa", Gender=GoodCode.Gender.Female, Role = GoodCode.Role.Executive},
                new GoodCode.Employee{Name="Arturo", Gender=GoodCode.Gender.Male, Role = GoodCode.Role.Executive},
            };

            var employeeManager = new GoodCode.EmployeeManager();
            foreach (var employee in employees)
            {
                employeeManager.Save(employee);
            }

            var searchEmployee = new GoodCode.EmployeeSearch(employeeManager);

            Console.WriteLine($"Cantidad de Empleados Ejecutivos y de genero Masculino:{searchEmployee.GetMaleExecutives()}");

            Console.ReadLine();
        }
    }
}

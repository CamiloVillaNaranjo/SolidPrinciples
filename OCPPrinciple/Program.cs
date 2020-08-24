using System;
using System.Collections.Generic;
using OCPPrinciple.GoodPractice;

namespace OCPPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            //BadCode();
            GoodCode();
            Console.ReadLine();
        }
    
        public static void BadCode()
        {
            var persons = new List<BadPractice.Person>()
            {
                new BadPractice.Person{ FirstName = "Rodrigo", LastName="Morales"},
                new BadPractice.Person{ FirstName = "Miguel", LastName="Sandoval"},
                new BadPractice.Person{ FirstName = "Robert", LastName="Martin"}
            };

            List<BadPractice.Staff> staffs = new List<BadPractice.Staff>();

            foreach (var staff in persons)
            {
                staffs.Add(new BadPractice.AccountService().Create(staff));
            }

            foreach (var staff in staffs)
            {
                Console.WriteLine($"Bienvenido {staff.FirstName}, {staff.LastName} , {staff.Email}");
            }
        }

        public static void GoodCode()
        {
            List<IApplicant> persons = new List<IApplicant>()
            {
                new Person{ FirstName = "Rodrigo", LastName="Morales"},
                new Doctor{ FirstName = "Miguel", LastName="Sandoval"},
                new Nurse{ FirstName = "Robert", LastName="Martin"}
            };

            List<Staff> staffs = new List<Staff>();

            foreach (var staff in persons)
            {
                staffs.Add(staff.Identifier.Create(staff));
            }

            foreach (var staff in staffs)
            {
                Console.WriteLine($"Bienvenido {staff.FirstName}, {staff.LastName} , {staff.Email}");
            }
        }
    }
}

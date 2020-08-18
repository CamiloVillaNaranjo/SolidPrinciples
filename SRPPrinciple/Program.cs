using SRPPrinciple.BadCode;
using SRPPrinciple.GoodCode;
using System;

namespace SRPPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usin Bad Code.
            //Console.WriteLine(new AppointmentService().Create("","",DateTime.MinValue));
            //Console.WriteLine(new AppointmentService().Create("Rodrigo Velez", "Rodrigo.Velez_gmail.com", new DateTime(2020,08,13,15,00,00)));
            //Console.WriteLine(new AppointmentService().Create("Margarita Bedoya", "Margarita.Bedoya@gmail.com", new DateTime(2020, 08, 13, 15, 00, 00)));

            //Using Good Code approach.
            var appointment = new Appointment
            {
                Patient = new Patient
                {
                    Name = "Juan Pelaez",
                    Email = "Juan.Pelaez@dominio.com"
                },
                Time = new DateTime(2020, 08, 13, 15, 00, 00)
            };

            Console.WriteLine(new GoodCode.AppointmentService().Create(appointment));

            Console.ReadLine();
        }
    }
}

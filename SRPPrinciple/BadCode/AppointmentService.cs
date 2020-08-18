using System;
using System.Collections.Generic;
using System.Text;

namespace SRPPrinciple.BadCode
{
    public class AppointmentService
    {
        //This is Bad Code, because the Class it self may handle only creation of appointment, 
        // the validations must be located in another class, a helper class, that I call here and
        // Depending on valditation results, this part creates or not the appointment, thats all.
        public string Create(string name, string email, DateTime time)
        {
            StringBuilder message = new StringBuilder();
            bool isValid = true;
            message.Append($"Iniciando cita {DateTime.Now.ToLongTimeString()}");

            if (string.IsNullOrEmpty(name))
            {
                message.Append("La cita no puede ser agendada, debido a que debe proporcionar un nombre de paciente.");
                isValid = false;
            }

            if (time.Equals(DateTime.MinValue))
            {
                message.Append("La cita no puede ser agendada, debido a que debe proporcionar la hora de la cita.");
                isValid = false;
            }

            if(!email.Contains("@") || string.IsNullOrEmpty(email))
            {
                message.Append("La cita no puede ser agendada, debido a que debe proporcionar un email valido.");
                isValid = false;
            }

            if (isValid)
            {
                message.Append($"La cita quedó agendada para el paciente {name}.");
            }

            return message.ToString().Replace(".", Environment.NewLine);
        }
    }
}

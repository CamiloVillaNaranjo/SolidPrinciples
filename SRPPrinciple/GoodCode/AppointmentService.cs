using System;
using System.Collections.Generic;
using System.Text;

namespace SRPPrinciple.GoodCode
{
    public class AppointmentService
    {
        public string Create(Appointment appointment)
        {
            var validation = AppointmentServiceValidator.Validate(appointment);

            return validation.IsValid ?
                $"La cita quedo agendada para el paciente {appointment.Patient.Name}." :
                string.Join(Environment.NewLine, validation.ErrorMessages);
        }
    }
}

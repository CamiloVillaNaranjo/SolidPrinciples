using System;

namespace SRPPrinciple.GoodCode
{
    public static class AppointmentServiceValidator
    {
        public static ValidationResult Validate(Appointment appointment)
        {
            var validation = new ValidationResult();

            if (string.IsNullOrEmpty(appointment.Patient.Name))
                validation.ErrorMessages.Add("La cita no puede ser agendada, debido a que debe proporcionar un nombre de paciente.");

            if (appointment.Time.Equals(DateTime.MinValue))
                validation.ErrorMessages.Add("La cita no puede ser agendada, debido a que debe proporcionar la hora de la cita.");

            if (!appointment.Patient.Email.Contains("@") || string.IsNullOrEmpty(appointment.Patient.Email))
                validation.ErrorMessages.Add("La cita no puede ser agendada, debido a que debe proporcionar un email valido.");

            return validation;

        }
    }
}

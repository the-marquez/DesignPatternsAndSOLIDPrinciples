using System;

namespace DesignPatternsAndSOLIDPrinciples.Solid.SRP.AppointmentSystem;

public class AppointmentService
{
    public static string Create(Appointment appointment)
    {
        ValidatorResult validator = AppointmentServiceValidator.Validate( appointment );

        return validator.IsValid 
            ? $"Cita agendada para el paciente {appointment.Patient.Name} con fecha {appointment.Date}"
            : string.Join(Environment.NewLine, validator.Errors);
    }
}
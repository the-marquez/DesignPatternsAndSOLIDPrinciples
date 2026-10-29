using System;

namespace DesignPatternsAndSOLIDPrinciples.Solid.SRP.AppointmentSystem;

public static class AppointmentServiceValidator
{
    public static ValidatorResult Validate(Appointment appointment)
    {
        var validation = new ValidatorResult();

        if( string.IsNullOrEmpty( appointment.Patient.Name ) )
            validation.Errors.Add("Es requerido el nombre del paciente!");

        if( string.IsNullOrEmpty( appointment.Patient.Email ) )
            validation.Errors.Add("El email es requerido!");

        if( ! appointment.Patient.Email.Contains("@"))
            validation.Errors.Add("Email invalido!");

        if( appointment.Date.Equals( DateTime.MinValue ))
            validation.Errors.Add("No es posible agendar una cita para el presente pasado!");

        return validation;
    }
}

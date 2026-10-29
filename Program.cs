using System;
using DesignPatternsAndSOLIDPrinciples.Solid.SRP.AppointmentSystem;

Console.WriteLine("---------------------------------");
Console.WriteLine("Appointment System");
Console.WriteLine("---------------------------------");

var marc = new Patient
{
    Name = "Marc",
    Email = null
};


var appointment = new Appointment
{
    Patient = marc,
    Date = new DateTime(year: 2026, month: 10, day: 29, hour: 9, minute: 30, second: 0)
};

var response = AppointmentService.Create( appointment );

Console.WriteLine($"Respuesta: { response }");
//Respuesta: Cita agendada para el paciente Marc con fecha 10/29/2026 9:30:00 AM

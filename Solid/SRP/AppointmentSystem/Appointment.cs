
using System;

namespace DesignPatternsAndSOLIDPrinciples.Solid.SRP.AppointmentSystem;

public class Appointment
{
    public Patient Patient { get; set; }
    public DateTime Date { get; set; }
}

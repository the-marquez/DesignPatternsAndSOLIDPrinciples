
using System;
using DesignPatternsAndSOLIDPrinciples.Solid.SRP.SchoolSystem;

Console.WriteLine("---------------------------------");
Console.WriteLine("School System");
Console.WriteLine("---------------------------------");

var reporter = new CourseReport();

reporter.AddEntry( new CourseReportEntry{ Name = "Matematicas I", Students = 120, Rating = 4.5 } );
reporter.AddEntry( new CourseReportEntry{ Name = "Estudios Sociales", Students = 120, Rating = 3.2 } );
reporter.AddEntry( new CourseReportEntry{ Name = "Lenguaje y Literatura", Students = 120, Rating = 3.9 } );

var saver = new FileSaver();

string directory = "Reports";
string filename = $"WorkReport-{DateTime.Now.ToString("yyyyMMdd")}.json";

saver.SaveToFile( directory, filename, reporter );
// Directorio creado: Reports
// Archivo guardado: Reports\WorkReport-20261028.json



// using System;
// using DesignPatternsAndSOLIDPrinciples.Solid.SRP.AppointmentSystem;

// Console.WriteLine("---------------------------------");
// Console.WriteLine("Appointment System");
// Console.WriteLine("---------------------------------");

// var marc = new Patient
// {
//     Name = "Marc",
//     Email = null
// };


// var appointment = new Appointment
// {
//     Patient = marc,
//     Date = new DateTime(year: 2026, month: 10, day: 29, hour: 9, minute: 30, second: 0)
// };

// var response = AppointmentService.Create( appointment );

// Console.WriteLine($"Respuesta: { response }");
// //Respuesta: Cita agendada para el paciente Marc con fecha 10/29/2026 9:30:00 AM

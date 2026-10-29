
using System;
using System.IO;

namespace DesignPatternsAndSOLIDPrinciples.Solid.SRP.SchoolSystem
{
    public class FileSaver
    {
        public void SaveToFile(string directoryPath, string filename, CourseReport report)
        {
            string content = report.ToString();

            if( string.IsNullOrEmpty( content ))
            {
                Console.WriteLine("WARNING: No hay contenido que guardar!");
                return;
            }

            if( ! Directory.Exists( directoryPath ))
            {
                Directory.CreateDirectory(directoryPath);
                Console.WriteLine($"Directorio creado: {directoryPath}");
            }

            string filePath = Path.Combine(directoryPath, filename);

            File.WriteAllText( filePath, content );

            Console.WriteLine($"Archivo guardado: {filePath}");
        }
    }
}
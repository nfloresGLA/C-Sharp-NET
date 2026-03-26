using System;
using integrador.Models;
using integrador.Services;

namespace integrador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cursadas = new string[3];
            string[] cursos = { "Programacion .NET", "Programacion JAVA", "Programacion PHP" };

            Console.WriteLine("¡Bienvenido al formulario de inscripcion!\n");

            Alumno alumno = FormularioAlumnoService.CapturarAlumno();
            ConsoleOutputService.MostrarDatosIngresados(alumno);

            if (!ConsoleInputService.LeerConfirmacion("\n¿Los datos proporcionados son correctos?", "'S' para confirmar, 'N' para cancelar la operacion: "))
            {
                Console.WriteLine("Datos incorrectos. Ejecuta nuevamente la aplicacion.");
                return;
            }

            Console.WriteLine("\nDatos guardados correctamente.");
            InscripcionService.GestionarInscripciones(cursadas, cursos);
            ConsoleOutputService.MostrarConstancia(alumno, cursadas);
        }
    }
}

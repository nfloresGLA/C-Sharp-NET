using System;
using integrador.Models;

namespace integrador.Services
{
    internal static class ConsoleOutputService
    {
        public static void MostrarDatosIngresados(Alumno alumno)
        {
            Console.WriteLine();
            Console.WriteLine("Los datos ingresados son:");
            Console.WriteLine("Nombre: " + alumno.Nombre);
            Console.WriteLine("Apellido: " + alumno.Apellido);
            Console.WriteLine("Edad: " + alumno.Edad);
            Console.WriteLine("Email: " + alumno.Email);
        }

        public static void MostrarMenuCursos(string[] cursos)
        {
            for (int i = 0; i < cursos.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + cursos[i]);
            }

            Console.WriteLine("0. Salir de la aplicacion");
            Console.Write("Seleccione el codigo de la carrera elegida: ");
        }

        public static void MostrarConstancia(Alumno alumno, string[] cursadas)
        {
            Console.WriteLine("Constancia de inscripcion");
            Console.WriteLine("Alumno: " + alumno.Nombre + " " + alumno.Apellido);
            Console.WriteLine("Correo electronico: " + alumno.Email);
            Console.WriteLine("Cursadas:");

            for (int i = 0; i < cursadas.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(cursadas[i]))
                {
                    Console.WriteLine("- " + cursadas[i]);
                }
            }
        }
    }
}

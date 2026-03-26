using System;
using integrador.Helpers;

namespace integrador.Services
{
    internal static class InscripcionService
    {
        public static void GestionarInscripciones(string[] cursadas, string[] cursos)
        {
            int opcion;

            Console.WriteLine("\n¡Inscripcion de cursadas!");
            Console.WriteLine("Presione una tecla para continuar");

            do
            {
                Console.ReadKey();
                Console.Clear();
                ConsoleOutputService.MostrarMenuCursos(cursos);
                opcion = ConsoleInputService.LeerOpcionMenu(cursos.Length);

                Console.WriteLine();

                if (opcion == 0)
                {
                    Console.WriteLine("Saliste correctamente de la seleccion de cursadas.\n");
                    break;
                }

                string cursoSeleccionado = cursos[opcion - 1];

                if (CursadaHelper.ContieneCurso(cursadas, cursoSeleccionado))
                {
                    Console.WriteLine("Ya seleccionaste esa cursada.\n");
                }
                else if (CursadaHelper.AsignarPrimeraPosicionDisponible(cursadas, cursoSeleccionado))
                {
                    Console.WriteLine("Seleccionaste el curso de " + cursoSeleccionado + "\n");
                }
                else
                {
                    Console.WriteLine("No hay mas espacios disponibles para nuevas cursadas.\n");
                }

                if (!CursadaHelper.HayPosicionDisponible(cursadas))
                {
                    Console.WriteLine("\nCursos guardados correctamente!\n");
                    break;
                }

                Console.WriteLine("Puede seguir eligiendo carreras o guardar y salir");

                if (!ConsoleInputService.LeerConfirmacion(string.Empty, "'S' para continuar, 'N' para guardar y salir: "))
                {
                    Console.WriteLine("\nCursos guardados correctamente!\n");
                    break;
                }

                Console.WriteLine("Presione una tecla para continuar");
            }
            while (true);
        }
    }
}

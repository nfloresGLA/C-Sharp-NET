using System;

namespace integrador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cursadas = new string[3];
            string[] cursos = { "Programacion .NET", "Programacion JAVA", "Programacion PHP" };

            Console.WriteLine("¡Bienvenido al formulario de inscripcion!\n");

            string nombre = LeerTextoObligatorio("Ingresa tu nombre: ");
            string apellido = LeerTextoObligatorio("Ingresa tu apellido: ");
            int edad = LeerEnteroPositivo("Ingresa tu edad: ");
            string email = LeerTextoObligatorio("Ingresa tu email: ");

            MostrarDatosIngresados(nombre, apellido, edad, email);

            if (!LeerConfirmacion("\n¿Los datos proporcionados son correctos?", "'S' para confirmar, 'N' para cancelar la operacion: "))
            {
                Console.WriteLine("Datos incorrectos. Ejecuta nuevamente la aplicacion.");
                return;
            }

            Console.WriteLine("\nDatos guardados correctamente.");
            GestionarInscripciones(cursadas, cursos);
            MostrarConstancia(nombre, apellido, email, cursadas);
        }

        private static string LeerTextoObligatorio(string mensaje)
        {
            string valor;

            do
            {
                Console.Write(mensaje);
                valor = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(valor))
                {
                    return valor.Trim();
                }

                Console.WriteLine("El valor ingresado no puede estar vacio. Intenta nuevamente.\n");
            }
            while (true);
        }

        private static int LeerEnteroPositivo(string mensaje)
        {
            int numero;
            string valorIngresado;

            do
            {
                Console.Write(mensaje);
                valorIngresado = Console.ReadLine();

                if (int.TryParse(valorIngresado, out numero) && numero > 0)
                {
                    return numero;
                }

                Console.WriteLine("Debes ingresar un numero entero mayor que cero.\n");
            }
            while (true);
        }

        private static bool LeerConfirmacion(string titulo, string mensaje)
        {
            string respuesta;

            do
            {
                if (!string.IsNullOrWhiteSpace(titulo))
                {
                    Console.WriteLine(titulo);
                }

                Console.Write(mensaje);
                respuesta = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(respuesta))
                {
                    respuesta = respuesta.Trim().ToUpper();

                    if (respuesta.Equals("S"))
                    {
                        return true;
                    }

                    if (respuesta.Equals("N"))
                    {
                        return false;
                    }
                }

                Console.WriteLine("Opcion invalida. Ingresa 'S' o 'N'.\n");
            }
            while (true);
        }

        private static void MostrarDatosIngresados(string nombre, string apellido, int edad, string email)
        {
            Console.WriteLine();
            Console.WriteLine("Los datos ingresados son:");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Email: " + email);
        }

        private static void GestionarInscripciones(string[] cursadas, string[] cursos)
        {
            int opcion;

            Console.WriteLine("\n¡Inscripcion de cursadas!");
            Console.WriteLine("Presione una tecla para continuar");

            do
            {
                Console.ReadKey();
                Console.Clear();
                MostrarMenuCursos(cursos);
                opcion = LeerOpcionMenu(cursos.Length);

                Console.WriteLine();

                if (opcion == 0)
                {
                    Console.WriteLine("Saliste correctamente de la seleccion de cursadas.\n");
                    break;
                }

                string cursoSeleccionado = cursos[opcion - 1];

                if (Helper.ContieneCurso(cursadas, cursoSeleccionado))
                {
                    Console.WriteLine("Ya seleccionaste esa cursada.\n");
                }
                else if (Helper.AsignarPrimeraPosicionDisponible(cursadas, cursoSeleccionado))
                {
                    Console.WriteLine("Seleccionaste el curso de " + cursoSeleccionado + "\n");
                }
                else
                {
                    Console.WriteLine("No hay mas espacios disponibles para nuevas cursadas.\n");
                }

                if (opcion != 0)
                {
                    if (!Helper.HayPosicionDisponible(cursadas))
                    {
                        Console.WriteLine("\nCursos guardados correctamente!\n");
                        break;
                    }

                    Console.WriteLine("Puede seguir eligiendo carreras o guardar y salir");

                    if (!LeerConfirmacion(string.Empty, "'S' para continuar, 'N' para guardar y salir: "))
                    {
                        Console.WriteLine("\nCursos guardados correctamente!\n");
                        break;
                    }

                    Console.WriteLine("Presione una tecla para continuar");
                }
            }
            while (true);
        }

        private static void MostrarMenuCursos(string[] cursos)
        {
            for (int i = 0; i < cursos.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + cursos[i]);
            }

            Console.WriteLine("0. Salir de la aplicacion");
            Console.Write("Seleccione el codigo de la carrera elegida: ");
        }

        private static int LeerOpcionMenu(int cantidadOpciones)
        {
            int opcion;
            string valorIngresado;

            do
            {
                valorIngresado = Console.ReadLine();

                if (int.TryParse(valorIngresado, out opcion) && opcion >= 0 && opcion <= cantidadOpciones)
                {
                    return opcion;
                }

                Console.Write("Opcion invalida. Ingresa un numero entre 0 y " + cantidadOpciones + ": ");
            }
            while (true);
        }

        private static void MostrarConstancia(string nombre, string apellido, string email, string[] cursadas)
        {
            Console.WriteLine("Constancia de inscripcion");
            Console.WriteLine("Alumno: " + nombre + " " + apellido);
            Console.WriteLine("Correo electronico: " + email);
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

    internal static class Helper
    {
        public static bool AsignarPrimeraPosicionDisponible(string[] cursadas, string curso)
        {
            for (int i = 0; i < cursadas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(cursadas[i]))
                {
                    cursadas[i] = curso;
                    return true;
                }
            }

            return false;
        }

        public static bool ContieneCurso(string[] cursadas, string curso)
        {
            for (int i = 0; i < cursadas.Length; i++)
            {
                if (string.Equals(cursadas[i], curso, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool HayPosicionDisponible(string[] cursadas)
        {
            for (int i = 0; i < cursadas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(cursadas[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}

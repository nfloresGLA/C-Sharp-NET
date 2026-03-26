using System;

namespace integrador.Services
{
    internal static class ConsoleInputService
    {
        public static string LeerTextoObligatorio(string mensaje)
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

        public static int LeerEnteroPositivo(string mensaje)
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

        public static bool LeerConfirmacion(string titulo, string mensaje)
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

        public static int LeerOpcionMenu(int cantidadOpciones)
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
    }
}

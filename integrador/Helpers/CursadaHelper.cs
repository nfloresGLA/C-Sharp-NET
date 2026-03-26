using System;

namespace integrador.Helpers
{
    internal static class CursadaHelper
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

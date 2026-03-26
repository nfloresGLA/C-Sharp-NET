using integrador.Models;

namespace integrador.Services
{
    internal static class FormularioAlumnoService
    {
        public static Alumno CapturarAlumno()
        {
            Alumno alumno = new Alumno();

            alumno.Nombre = ConsoleInputService.LeerTextoObligatorio("Ingresa tu nombre: ");
            alumno.Apellido = ConsoleInputService.LeerTextoObligatorio("Ingresa tu apellido: ");
            alumno.Edad = ConsoleInputService.LeerEnteroPositivo("Ingresa tu edad: ");
            alumno.Email = ConsoleInputService.LeerTextoObligatorio("Ingresa tu email: ");

            return alumno;
        }
    }
}

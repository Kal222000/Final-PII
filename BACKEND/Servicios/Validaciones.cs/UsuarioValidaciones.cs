using System;
using BACKEND.DTO.Recibe;
using BACKEND.DTO.Envia;
using BACKEND.DTO.Recibe;

namespace BACKEND.Servicios.Validaciones
{
    public class UsuarioValidaciones
    {
        public UsuarioValidaciones() { }

        public bool ValidarContrasena(string contrasena)
        {
            if (string.IsNullOrWhiteSpace(contrasena) || contrasena.Length < 8) { return false; }

            bool Mayuscula = false;

            bool Numero = false;

            foreach (char c in contrasena)
            {
                if (char.IsUpper(c)) Mayuscula = true;

                if (char.IsDigit(c)) Numero = true;
            }

            return Mayuscula && Numero;
        }

        public bool Validar(NuevoUsuarioDTO usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Nombre)) return false;

            if (string.IsNullOrWhiteSpace(usuario.ApellidoPaterno)) return false;

            if (string.IsNullOrWhiteSpace(usuario.ApellidoMaterno)) return false;

            return true;
        }

        public bool MayorDeEdad(DateOnly fechaNacimiento)
        {
            var hoy = DateOnly.FromDateTime(DateTime.Today);

            int edad = hoy.Year - fechaNacimiento.Year;

            if (fechaNacimiento > hoy.AddYears(-edad)) { return false; }
            else { return true; }
        }

        public bool ValidarInts(NuevoUsuarioDTO usuario)
        {
            if (usuario.Carnet <= 0) { return false; }
            else { return true; }
        }

        public bool ValidarEspacios(string nombre, string AppP, string AppM, string Contrasena)
        {
            foreach (char c in nombre)
            {
                if(c == ' ')
                {
                    return false;
                }
            }

            foreach (char c in AppP)
            {
                if (c == ' ')
                {
                    return false;
                }
            }

            foreach (char c in AppM)
            {
                if (c == ' ')
                {
                    return false;
                }
            }

            foreach (char c in Contrasena)
            {
                if (c == ' ')
                {
                    return false;
                }
            }

            return true;
        }


    }
}
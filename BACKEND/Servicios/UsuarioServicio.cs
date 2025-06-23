using System;
using System.Threading.Tasks;
using BACKEND.DTO;
using BACKEND.Repositorios;
using BACKEND.Servicios.Interfaces;

namespace BACKEND.Servicios
{
    public partial class UsuarioServicio : IUsuarioServicio
    {
        private readonly UsuarioRepositorio repositorio;

        public UsuarioServicio()
        {
            repositorio = new UsuarioRepositorio();;
        }
        
        public async Task<int?> ValidarUsuario(ValidarUsuarioDTO usuario)
        {
            return await repositorio.ValidarUsuario(usuario);
        }

        public async Task<int?> CreacionCliente(CreacionClienteDTO usuario)
        {
            bool aux1 = Validar(usuario);
            bool aux2 = ValidarInts(usuario);
            bool aux3 = ValidarContrasena(usuario.Contrasena);
            bool aux4 = MayorDeEdad(usuario.FechaNacimiento);

            if (aux1 == false)
            {
                throw new Exception("Los espacios no pueden estar en blanco o nulos.");
            }
            else if (aux2 == false)
            {
                throw new Exception("El carnet no puede ser negativo.");
            }
            else if (aux3 == false)
            {
                throw new Exception("La contraseña debe contener al menos una mayúscula y un número.");
            }
            else if(aux4 == false)
            {
                throw new Exception("No puede ser menor de Edad.");
            }

                return await repositorio.CreacionCliente(usuario);
        }

        public bool ValidarInts(CreacionClienteDTO usuario)
        {
            if (usuario.Carnet <= 0) return false;
            return true;
        }

        public bool Validar(CreacionClienteDTO usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Nombre)) return false;
            if (string.IsNullOrWhiteSpace(usuario.ApellidoPaterno)) return false;
            if (string.IsNullOrWhiteSpace(usuario.ApellidoMaterno)) return false;
            return true;
        }

        public bool ValidarContrasena(string contrasena)
        {
            if (string.IsNullOrWhiteSpace(contrasena) || contrasena.Length < 8)
                return false;

            bool Mayuscula = false;
            bool Numero = false;

            foreach (char c in contrasena)
            {
                if (char.IsUpper(c)) Mayuscula = true;
                if (char.IsDigit(c)) Numero = true;
            }

            return Mayuscula && Numero;
        }

        public bool MayorDeEdad(DateOnly fechaNacimiento)
        {
            var hoy = DateOnly.FromDateTime(DateTime.Today);
            int edad = hoy.Year - fechaNacimiento.Year;

            if (fechaNacimiento > hoy.AddYears(-edad))
                edad--;

            return edad >= 18;
        }

    }
}
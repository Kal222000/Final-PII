using System;
using System.Threading.Tasks;
using BACKEND.DTO;

namespace BACKEND.Servicios.Interfaces
{
    public interface IUsuarioServicio
    {
        Task<int?> ValidarUsuario(ValidarUsuarioDTO usuario);

        Task<int?> CreacionCliente(CreacionClienteDTO usuario);
    }
}
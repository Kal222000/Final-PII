using System;
using BACKEND.DTO;
using System.Threading.Tasks;

namespace BACKEND.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<int?> ValidarUsuario(ValidarUsuarioDTO usuario);

        Task<int?> CreacionCliente(CreacionClienteDTO usuario);
    }
}
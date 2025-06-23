using System;
using System.Data;
using System.Threading.Tasks;
using BACKEND.DTO;
using BACKEND.Datos.SQL;
using BACKEND.Repositorios.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace BACKEND.Repositorios
{
    public partial class UsuarioRepositorio : IUsuarioRepositorio
    {
        public async Task<int?> ValidarUsuario(ValidarUsuarioDTO usuario)
        {
            int? resultado;

            using (var conexion = new SQLConexion())
            {
                var Carnet = new SqlParameter("@CARNET", usuario.Carnet);
                var Contrasena = new SqlParameter("@CONTRASENA", usuario.Contrasena);

                var Salida = new SqlParameter("@ID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                await conexion.Database.ExecuteSqlRawAsync("EXEC ValidarUsuario @CARNET, @CONTRASENA, @ID OUTPUT", Carnet,Contrasena, Salida);

                resultado = Salida.Value != DBNull.Value ? (int?) Salida.Value : null; 
            }

            return resultado;
        }

        public async Task<int?> CreacionCliente(CreacionClienteDTO usuario)
        {
            int? resultado;

            usuario.Rol = 1;

            using (var conexion = new SQLConexion())
            {
                var Nombre = new SqlParameter("@NOMBRE", usuario.Nombre);
                var ApellidoPaterno = new SqlParameter("@APELLIDOP", usuario.ApellidoPaterno);
                var ApellidoMaterno = new SqlParameter("@APELLIDOM", usuario.ApellidoMaterno);
                var FechaNacimiento = new SqlParameter("@FECHAN", usuario.FechaNacimiento);
                var Carnet = new SqlParameter("@CARNET", usuario.Carnet);
                var Rol = new SqlParameter("@ROL", usuario.Rol);
                var Contrasena = new SqlParameter("@CONTRASENA", usuario.Contrasena);
                var Salida = new SqlParameter("@RESULTADO", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                await conexion.Database.ExecuteSqlRawAsync("EXEC CreacionCliente @NOMBRE, @APELLIDOP, @APELLIDOM, @FECHAN, @CARNET, @ROL, @CONTRASENA, @RESULTADO OUTPUT",
                    Nombre, ApellidoPaterno, ApellidoMaterno, FechaNacimiento, Carnet, Rol, Contrasena, Salida);

                resultado = Salida.Value != DBNull.Value ? (int?) Salida.Value : null;
            }

            return resultado;
        }
    }
}
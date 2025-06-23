using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BACKEND.DTO;
using BACKEND.Servicios;
using BACKEND.Servicios.Interfaces;

namespace BACKEND.Controladores
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioControlador : ControllerBase
    {
        private readonly IUsuarioServicio servicio;

        public UsuarioControlador()
        {
            servicio = new UsuarioServicio();
        }

        [HttpPost("ValidarUsuario")]
        public async Task<IActionResult> ValidarUsuario([FromBody] ValidarUsuarioDTO usuario)
        {
            var resultado = await servicio.ValidarUsuario(usuario);
            if (resultado == null) return Unauthorized();
            return Ok(resultado);
        }

        [HttpPost("CreacionCliente")]
        public async Task<IActionResult> CreacionCliente([FromBody] CreacionClienteDTO usuario)
        {
            try
            {
                var resultado = await servicio.CreacionCliente(usuario);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
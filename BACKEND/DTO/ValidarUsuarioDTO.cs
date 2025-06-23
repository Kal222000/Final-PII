using System;
using System.ComponentModel.DataAnnotations;

namespace BACKEND.DTO
{
    public class ValidarUsuarioDTO
    {
        [Required(ErrorMessage = "El carnet es obligatorio")]
        public int Carnet { get; set; }

        [Required(ErrorMessage = "La contrase�a es obligatoria")]
        public string Contrasena { get; set; }
    }
}
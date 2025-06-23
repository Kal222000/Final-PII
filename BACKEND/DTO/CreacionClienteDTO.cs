using System;
using System.ComponentModel.DataAnnotations;

namespace BACKEND.DTO
{
    public class CreacionClienteDTO
    {
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Apellido Paterno es obligatorio.")]
        public string ApellidoPaterno { get; set; }

        [Required(ErrorMessage = "El campo Apellido Materno es obligatorio.")]
        public string ApellidoMaterno { get; set; }

        [Required(ErrorMessage = "El campo Fecha de Nacimiento es obligatorio.")]
        public DateOnly FechaNacimiento { get; set; }

        [Required(ErrorMessage = "El campo Carnet es obligatorio.")]
        public int Carnet {  get; set; }

        [Required(ErrorMessage = "El campo Rol es obligatorio.")]
        public int Rol {  get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        public string Contrasena { get; set; }
    }
}
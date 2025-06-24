using System;
using BACKEND.DTO.Envia;
using System.Collections.Generic;

namespace BACKEND.Repositorios.Interfaces
{
    public interface ILibroRepositorio
    {
        List<DatosLibroDTO> DevolverLibros();

     /*   int CantidadCopiasDisponibles();

         void CrearLibro();

         void ActualizarCopia();*/
    }
}
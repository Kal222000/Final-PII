﻿using System;
using System.Collections.Generic;

namespace BACKEND.Modelos;

public partial class ReservaDetalle
{
    public int ReservaId { get; set; }

    public int SolicitudId { get; set; }

    public string LibroId { get; set; }

    public int Copia { get; set; }

    public DateOnly? FechaExpiracion { get; set; }

    public string EstadoDetalle { get; set; } = "pendiente";

    public virtual PrestamosExitoso? PrestamosExitoso { get; set; }

    public virtual SolicitudReserva Solicitud { get; set; } = null!;
}

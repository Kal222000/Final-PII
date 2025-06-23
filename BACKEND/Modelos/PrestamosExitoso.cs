using System;
using System.Collections.Generic;

namespace BACKEND.Modelos;

public partial class PrestamosExitoso
{
    public int ReservaDetalleId { get; set; }

    public DateTime? FechaRecogida { get; set; }

    public DateOnly? FechaVencimientoPrestamo { get; set; }

    public DateTime? FechaDevolucionReal { get; set; }

    public virtual ReservaDetalle ReservaDetalle { get; set; } = null!;
}

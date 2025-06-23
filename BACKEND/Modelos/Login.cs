using System;
using System.Collections.Generic;

namespace BACKEND.Modelos;

public partial class Login
{
    public int UsuarioId { get; set; }

    public string? Contrasena { get; set; }

    public virtual Usuario Usuario { get; set; } = null!;
}

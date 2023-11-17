using System;
using System.Collections.Generic;

namespace YarlanAPI.Models;

public partial class Mensaje
{
    public int Id { get; set; }

    public string? Alerta { get; set; }

    public string? TipoUsuario { get; set; }

    public string? Zona { get; set; }

    public DateTime? FechaCreacion { get; set; }
}

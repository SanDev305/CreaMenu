using System;
using System.Collections.Generic;

namespace CreaMenu.Models.DB;

public partial class Grano
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int Disponible { get; set; }

    public virtual ICollection<Comidum> Comida { get; set; } = new List<Comidum>();
}

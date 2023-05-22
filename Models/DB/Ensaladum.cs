﻿using System;
using System.Collections.Generic;

namespace CreaMenu.Models.DB;

public partial class Ensaladum
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int Disponible { get; set; }

    public virtual ICollection<Comidum> Comida { get; set; } = new List<Comidum>();
}

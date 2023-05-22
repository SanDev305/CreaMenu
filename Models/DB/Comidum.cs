using System;
using System.Collections.Generic;

namespace CreaMenu.Models.DB;

public partial class Comidum
{
    public int Id { get; set; }

    public int CarnesId { get; set; }

    public int GranosId { get; set; }

    public int EnsaladasId { get; set; }

    public int GuarnicionesId { get; set; }

    public virtual Carne Carnes { get; set; } = null!;

    public virtual Ensaladum Ensaladas { get; set; } = null!;

    public virtual Grano Granos { get; set; } = null!;

    public virtual Guarnicione Guarniciones { get; set; } = null!;
}

using CreaMenu.Models.DB;

namespace CreaMenu.Models.Inventario
{
    public class InventarioViewModel
    {
        public List<Carne>? Carne { get; set; }
        public List<Grano>? Grano { get; set; }
        public List<Ensaladum>? Ensalada { get; set; }
        public List<Guarnicione>? Guarniciones { get; set; }
    }
}

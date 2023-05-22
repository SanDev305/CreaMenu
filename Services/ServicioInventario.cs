using CreaMenu.Models.DB;
using CreaMenu.Models.Inventario;
using CreaMenu.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CreaMenu.Services
{
    public class ServicioInventario:IServicioInventario
    {
        public async Task<InventarioViewModel> ObtenerInventario()
        {
            var carne = new List<Carne>();
            var Grano = new List<Grano>();
            var Ensalada = new List<Ensaladum>();
            var Guarnicion = new List<Guarnicione>();
            try
            {
                using (MiMenuContext db = new MiMenuContext())
                {
                    carne = await db.Carnes.ToListAsync();
                    Grano = await db.Granos.ToListAsync();
                    Ensalada = await db.Ensalada.ToListAsync();
                    Guarnicion = await db.Guarniciones.ToListAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return new InventarioViewModel
                {
                    Carne = carne,
                    Grano = Grano,
                    Ensalada = Ensalada,
                    Guarniciones = Guarnicion
                };
        }
    }
}

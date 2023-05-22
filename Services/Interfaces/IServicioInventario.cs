using CreaMenu.Models.Inventario;

namespace CreaMenu.Services.Interfaces
{
    public interface IServicioInventario
    {
        Task<InventarioViewModel> ObtenerInventario();
    }
}

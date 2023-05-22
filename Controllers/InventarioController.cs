using CreaMenu.Services;
using CreaMenu.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CreaMenu.Controllers
{
    public class InventarioController: Controller
    {
        private readonly IServicioInventario _servicioInventario;

        public InventarioController(IServicioInventario servicioInventario)
        {
            this._servicioInventario = servicioInventario;
        }

        public async Task<IActionResult> Index()
        {
            var inven = await _servicioInventario.ObtenerInventario();

            return View(inven);
        }

    }
}

using CordovaS_LigaPro_Clase03.Models;
using CordovaS_LigaPro_Clase03.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CordovaS_LigaPro_Clase03.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult ListaEquipos()
        {
            EquipoRepository repository = new EquipoRepository();
            var equipos = repository.DevuelveListadoEquipos();

            return View(equipos);
        }

        public IActionResult Edit(int Id)
        {
            EquipoRepository repository = new EquipoRepository();
            var equipo = repository.DevuelveInfoEquipo(Id);
            return View(equipo);
        }
    }


}

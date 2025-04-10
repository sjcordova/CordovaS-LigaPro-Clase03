using CordovaS_LigaPro_Clase03.Models;

namespace CordovaS_LigaPro_Clase03.Interfaces
{
    public interface IEquipoRepository
    {
        List<Equipo> DevuelveListadoEquipos();
        Equipo DevuelveInfoEquipo(int Id);
        bool CrearEquipo();
        bool ActualizarEquipo();
        bool EliminarEquipo();
    }
}

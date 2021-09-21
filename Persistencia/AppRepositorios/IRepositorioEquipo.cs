using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioEquipo
    {
        IEnumerable<Equipo> ListarEquipos();
        bool CrearEquipo(Equipo equipo);
        bool ActualizarEquipo(Equipo equipo);
        bool EliminarEquipo(int idEquipo);
        Equipo BuscarEquipo(int idEquipo);
    }
}
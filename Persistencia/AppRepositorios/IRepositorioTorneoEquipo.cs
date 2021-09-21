using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioTorneoEquipo
    {
        IEnumerable<TorneoEquipo> ListarTorneoEquipos();
        bool CrearTorneoEquipo(TorneoEquipo torneoEquipo);
        bool ActualizarTorneoEquipo(TorneoEquipo torneoEquipo);
        bool EliminarTorneoEquipo(int idTorneoEquipo);
        TorneoEquipo BuscarTorneoEquipo(int idTorneoEquipo);
    }
}
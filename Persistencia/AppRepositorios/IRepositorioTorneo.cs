using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioTorneo
    {
        IEnumerable<Torneo> ListarTorneos();
        bool CrearTorneo(Torneo torneo);
        bool ActualizarTorneo(Torneo torneo);
        bool EliminarTorneo(int idTorneo);
        Torneo BuscarTorneo(int idTorneo);
    }
}
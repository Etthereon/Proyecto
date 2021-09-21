using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioPatrocinador
    {
        IEnumerable<Patrocinador> ListarPatrocinadores();
        bool CrearPatrocinador(Patrocinador patrocinador);
        bool ActualizarPatrocinador(Patrocinador patrocinador);
        bool EliminarPatrocinador(int idPatrocinador);
        Patrocinador BuscarPatrocinador(int idPatrocinador);
    }
}
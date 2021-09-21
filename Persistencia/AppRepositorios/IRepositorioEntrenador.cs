using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioEntrenador
    {
        IEnumerable<Entrenador> ListarEntrenadores();
        bool CrearEntrenador(Entrenador entrenador);
        bool ActualizarEntrenador(Entrenador entrenador);
        bool EliminarEntrenador(int idEntrenador);
        Entrenador BuscarEntrenador(int idEntrenador);
    }
}
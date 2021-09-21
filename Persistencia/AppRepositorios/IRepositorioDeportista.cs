using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioDeportista
    {
        IEnumerable<Deportista> ListarDeportistas();
        bool CrearDeportista(Deportista deportista);
        bool ActualizarDeportista(Deportista deportista);
        bool EliminarDeportista(int idDeportista);
        Deportista BuscarDeportista(int idDeportista);
    }
}
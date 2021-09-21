using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface IRepositorioCanchaEspacio
    {
        IEnumerable<CanchaEspacio> ListarCanchaEspacios();
        bool CrearCanchaEspacio(CanchaEspacio canchaEspacio);
        bool ActualizarCanchaEspacio(CanchaEspacio canchaEspacio);
        bool EliminarCanchaEspacio(int idCanchaEspacio);
        CanchaEspacio BuscarCanchaEspacio(int idCanchaEspacio);
    }
}
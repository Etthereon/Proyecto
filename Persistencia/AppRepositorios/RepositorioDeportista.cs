using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioDeportista:IRepositorioDeportista
    {
        private readonly AppContext _appContext;

        public RepositorioDeportista(AppContext appContext)
        {
            _appContext=appContext;
        }

        // implementar de IRepositorio
        bool IRepositorioDeportista.CrearDeportista(Deportista deportista)
        {
            bool creado=false;
            try
            {
                 _appContext.Deportistas.Add(deportista);
                 _appContext.SaveChanges();
                 creado=true;
            }
            catch (System.Exception)
            {
                return creado;
                //throw;
            }
            return creado;
        }

        bool IRepositorioDeportista.ActualizarDeportista(Deportista deportista)
        {
            bool actualizado = false;
            var dep = _appContext.Deportistas.Find(deportista.id);
            if(dep!=null)
            {
                try
                {
                    dep.Nombres=deportista.Nombres;
                    _appContext.SaveChanges();
                    actualizado=true;
                     
                }
                catch (System.Exception)
                {
                    
                    return actualizado;
                }
            }
            return actualizado;
        }
        
        bool IRepositorioDeportista.EliminarDeportista(int idDeportista)
        {
            bool eliminado=false;
            var deportista = _appContext.Deportistas.Find(idDeportista);
            if (deportista!=null)
            {
                try
                {
                     _appContext.Deportistas.Remove(deportista);
                     _appContext.SaveChanges();
                     eliminado=true;
                }
                catch (System.Exception)
                {
                    
                    return eliminado;
                }
            }

                return eliminado;

        }
        Deportista IRepositorioDeportista.BuscarDeportista(int idDeportista)
        {
            Deportista deportista=_appContext.Deportistas.Find(idDeportista);
            return deportista;
        }

        IEnumerable<Deportista> IRepositorioDeportista.ListarDeportistas()
        {
            return _appContext.Deportistas;
        }


    }
}
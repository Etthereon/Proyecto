using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioEntrenador:IRepositorioEntrenador
    {
        private readonly AppContext _appContext;

        public RepositorioEntrenador(AppContext appContext)
        {
            _appContext=appContext;
        }

        // implementar de IRepositorio
        bool IRepositorioEntrenador.CrearEntrenador(Entrenador entrenador)
        {
            bool creado=false;
            try
            {
                 _appContext.Entrenadores.Add(entrenador);
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

        bool IRepositorioEntrenador.ActualizarEntrenador(Entrenador entrenador)
        {
            bool actualizado = false;
            var ent = _appContext.Entrenadores.Find(entrenador.id);
            if(ent!=null)
            {
                try
                {
                    ent.Nombres=entrenador.Nombres;
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
        
        bool IRepositorioEntrenador.EliminarEntrenador(int idEntrenador)
        {
            bool eliminado=false;
            var entrenador = _appContext.Entrenadores.Find(idEntrenador);
            if (entrenador!=null)
            {
                try
                {
                     _appContext.Entrenadores.Remove(entrenador);
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
        Entrenador IRepositorioEntrenador.BuscarEntrenador(int idEntrenador)
        {
            Entrenador entrenador=_appContext.Entrenadores.Find(idEntrenador);
            return entrenador;
        }

        IEnumerable<Entrenador> IRepositorioEntrenador.ListarEntrenadores()
        {
            return _appContext.Entrenadores;
        }


    }
}
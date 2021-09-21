using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioTorneoEquipo:IRepositorioTorneoEquipo
    {
        private readonly AppContext _appContext;

        public RepositorioTorneoEquipo(AppContext appContext)
        {
            _appContext=appContext;
        }

        // implementar de IRepositorio
        bool IRepositorioTorneoEquipo.CrearTorneoEquipo(TorneoEquipo torneoEquipo)
        {
            bool creado=false;
            try
            {
                 _appContext.TorneoEquipos.Add(torneoEquipo);
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

        bool IRepositorioTorneoEquipo.ActualizarTorneoEquipo(TorneoEquipo torneoEquipo)
        {
            bool actualizado = false;
            var tor = _appContext.TorneoEquipos.Find(torneoEquipo.TorneoId, torneoEquipo.EquipoId);
            if(tor!=null)
            {
                try
                {
                    tor.TorneoId=torneoEquipo.TorneoId;
                    tor.EquipoId=torneoEquipo.EquipoId;
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
        
        bool IRepositorioTorneoEquipo.EliminarTorneoEquipo(int idTorneoEquipo)
        {
            bool eliminado=false;
            var torneoEquipo = _appContext.TorneoEquipos.Find(idTorneoEquipo);
            if (torneoEquipo!=null)
            {
                try
                {
                     _appContext.TorneoEquipos.Remove(torneoEquipo);
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
        TorneoEquipo IRepositorioTorneoEquipo.BuscarTorneoEquipo(int idTorneoEquipo)
        {
            TorneoEquipo torneoEquipo=_appContext.TorneoEquipos.Find(idTorneoEquipo);
            return torneoEquipo;
        }

        IEnumerable<TorneoEquipo> IRepositorioTorneoEquipo.ListarTorneoEquipos()
        {
            return _appContext.TorneoEquipos;
        }


    }
}
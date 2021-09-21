using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioEscuelaArbitro:IRepositorioEscuelaArbitro
    {
        private readonly AppContext _appContext;

        public RepositorioEscuelaArbitro(AppContext appContext)
        {
            _appContext=appContext;
        }

        // implementar de IRepositorio
        bool IRepositorioEscuelaArbitro.CrearEscuelaArbitro(EscuelaArbitro escuelaArbitro)
        {
            bool creado=false;
            try
            {
                 _appContext.EscuelaArbitros.Add(escuelaArbitro);
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

        bool IRepositorioEscuelaArbitro.ActualizarEscuelaArbitro(EscuelaArbitro escuelaArbitro)
        {
            bool actualizado = false;
            var esc = _appContext.EscuelaArbitros.Find(escuelaArbitro.id);
            if(esc!=null)
            {
                try
                {
                    esc.Nombre=escuelaArbitro.Nombre;
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
        
        bool IRepositorioEscuelaArbitro.EliminarEscuelaArbitro(int idEscuelaArbitro)
        {
            bool eliminado=false;
            var escuelaArbitro = _appContext.EscuelaArbitros.Find(idEscuelaArbitro);
            if (escuelaArbitro!=null)
            {
                try
                {
                     _appContext.EscuelaArbitros.Remove(escuelaArbitro);
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
        EscuelaArbitro IRepositorioEscuelaArbitro.BuscarEscuelaArbitro(int idEscuelaArbitro)
        {
            EscuelaArbitro escuelaArbitro=_appContext.EscuelaArbitros.Find(idEscuelaArbitro);
            return escuelaArbitro;
        }

        IEnumerable<EscuelaArbitro> IRepositorioEscuelaArbitro.ListarEscuelaArbitros()
        {
            return _appContext.EscuelaArbitros;
        }


    }
}
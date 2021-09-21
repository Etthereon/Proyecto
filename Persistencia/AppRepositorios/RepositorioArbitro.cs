using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioArbitro:IRepositorioArbitro
    {
        private readonly AppContext _appContext;

        public RepositorioArbitro(AppContext appContext)
        {
            _appContext=appContext;
        }

        // implementar de IRepositorio
        bool IRepositorioArbitro.CrearArbitro(Arbitro arbitro)
        {
            bool creado=false;
            try
            {
                 _appContext.Arbitros.Add(arbitro);
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

        bool IRepositorioArbitro.ActualizarArbitro(Arbitro arbitro)
        {
            bool actualizado = false;
            var arb = _appContext.Arbitros.Find(arbitro.id);
            if(arb!=null)
            {
                try
                {
                    arb.Nombres=arbitro.Nombres;
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
        
        bool IRepositorioArbitro.EliminarArbitro(int idArbitro)
        {
            bool eliminado=false;
            var arbitro = _appContext.Arbitros.Find(idArbitro);
            if (arbitro!=null)
            {
                try
                {
                     _appContext.Arbitros.Remove(arbitro);
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
        Arbitro IRepositorioArbitro.BuscarArbitro(int idArbitro)
        {
            Arbitro arbitro=_appContext.Arbitros.Find(idArbitro);
            return arbitro;
        }

        IEnumerable<Arbitro> IRepositorioArbitro.ListarArbitros()
        {
            return _appContext.Arbitros;
        }


    }
}
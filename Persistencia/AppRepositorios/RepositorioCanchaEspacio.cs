using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioCanchaEspacio:IRepositorioCanchaEspacio
    {
        private readonly AppContext _appContext;

        public RepositorioCanchaEspacio(AppContext appContext)
        {
            _appContext=appContext;
        }

        // implementar de IRepositorio
        bool IRepositorioCanchaEspacio.CrearCanchaEspacio(CanchaEspacio canchaEspacio)
        {
            bool creado=false;
            try
            {
                 _appContext.CanchaEspacios.Add(canchaEspacio);
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

        bool IRepositorioCanchaEspacio.ActualizarCanchaEspacio(CanchaEspacio canchaEspacio)
        {
            bool actualizado = false;
            var can = _appContext.CanchaEspacios.Find(canchaEspacio.id);
            if(can!=null)
            {
                try
                {
                    can.Nombre=canchaEspacio.Nombre;
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
        
        bool IRepositorioCanchaEspacio.EliminarCanchaEspacio(int idCanchaEspacio)
        {
            bool eliminado=false;
            var canchaEspacio = _appContext.CanchaEspacios.Find(idCanchaEspacio);
            if (canchaEspacio!=null)
            {
                try
                {
                     _appContext.CanchaEspacios.Remove(canchaEspacio);
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
        CanchaEspacio IRepositorioCanchaEspacio.BuscarCanchaEspacio(int idCanchaEspacio)
        {
            CanchaEspacio canchaEspacio=_appContext.CanchaEspacios.Find(idCanchaEspacio);
            return canchaEspacio;
        }

        IEnumerable<CanchaEspacio> IRepositorioCanchaEspacio.ListarCanchaEspacios()
        {
            return _appContext.CanchaEspacios;
        }


    }
}
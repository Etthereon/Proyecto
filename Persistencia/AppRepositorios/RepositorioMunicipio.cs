using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioMunicipio:IRepositorioMunicipio
    {
        private readonly AppContext _appContext;

        public RepositorioMunicipio(AppContext appContext)
        {
            _appContext=appContext;
        }

        // implementar de IRepositorio
        bool IRepositorioMunicipio.CrearMunicipio(Municipio municipio)
        {
            bool creado=false;
            try
            {
                 _appContext.Municipios.Add(municipio);
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

        bool IRepositorioMunicipio.ActualizarMunicipio(Municipio municipio)
        {
            bool actualizado = false;
            var mun = _appContext.Municipios.Find(municipio.id);
            if(mun!=null)
            {
                try
                {
                    mun.Nombre=municipio.Nombre;
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
        
        bool IRepositorioMunicipio.EliminarMunicipio(int idMunicipio)
        {
            bool eliminado=false;
            var municipio = _appContext.Municipios.Find(idMunicipio);
            if (municipio!=null)
            {
                try
                {
                     _appContext.Municipios.Remove(municipio);
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
        Municipio IRepositorioMunicipio.BuscarMunicipio(int idMunicipio)
        {
            Municipio municipio=_appContext.Municipios.Find(idMunicipio);
            return municipio;
        }

        IEnumerable<Municipio> IRepositorioMunicipio.ListarMunicipios()
        {
            return _appContext.Municipios;
        }


    }
}
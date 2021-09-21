using System;
using Dominio;
using Persistencia;
using System.Collections.Generic;

namespace Consola
{
    class Program
    {
        //instanciar un objeto de tipo IRepositorioMunicipio
        private static IRepositorioMunicipio _repomunicipio = new RepositorioMunicipio(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            //crearMunicipio();
            //actualizarMunicipio();
            //eliminarMunicipio();
            //buscarMunicipio();
            ingresarDatos();
            listarMunicipios();   
        }

        /*
        private static void crearMunicipio()
        {
            var municipio = new Municipio
            {
                Nombre = "Pasto"
            };
            bool funciono = _repomunicipio.CrearMunicipio(municipio);
            if (funciono)
            {
                Console.WriteLine("Municipio adicionado con exito.");
            }
            else
            {
                Console.WriteLine("Se ha presentado una falla en el proceso.");
            }
        }*/

        
        private static void listarMunicipios()
        {
            IEnumerable<Municipio> municipios = _repomunicipio.ListarMunicipios();
            foreach (var mun in municipios)
            {
                Console.WriteLine(mun.id +" "+mun.Nombre);
            }
        }

        /*
        private static bool eliminarMunicipio()
        {
            bool funciono = _repomunicipio.EliminarMunicipio(2);
            if (funciono)
                {
                Console.WriteLine("Municipio eliminado con exito.");
                }
                else
                {
                Console.WriteLine("Se ha presentado una falla en el proceso.");
                }
            return funciono;
        }*/
        
        /*
        private static bool actualizarMunicipio()
        {
             var municipio = new Municipio
             {
                 id=1, Nombre="Cali"
             };
             bool funciono = _repomunicipio.ActualizarMunicipio(municipio);
            if (funciono)
            {
                Console.WriteLine("Municipio actualizado con exito.");
                Console.WriteLine("Lista actualizada");
                listarMunicipios();
            }
            else
            {
                Console.WriteLine("Se ha presentado una falla en el proceso.");
            }
             return funciono;
        }*/

        /*
        private static void buscarMunicipio()
        {
            var mun = _repomunicipio.BuscarMunicipio(3);
            if(mun!=null)
            {
                Console.WriteLine("Id: " + mun.id + " Nombre: " + mun.Nombre);
                Console.WriteLine("-----------------------------------------");
            }
            else
            {
                Console.WriteLine("Municipio no encontrado..");
            }
        }*/

        private static void ingresarDatos()
        {
            string nombre ="";
            Console.WriteLine("Ingrese el nombre del municipio que desea crear");
            nombre= Console.ReadLine();
            var municipio = new Municipio
            {
               Nombre = nombre
            };
            bool funciono = _repomunicipio.CrearMunicipio(municipio);
            if (funciono)
            {
                Console.WriteLine("Municipio adicionado con exito.");
            }
            else
            {
                Console.WriteLine("Se ha presentado una falla en el proceso.");
            }
        }
/*
        bool Existe(Municipio municipio)
        {
            bool existe = false;
            var mun = _appContext.Municipio.FirstOrDefault(municipio.Nombre);
            if (mun!=null)
            {
                existe=true;
            }
            return existe;
        }*/
        
    }
    
}

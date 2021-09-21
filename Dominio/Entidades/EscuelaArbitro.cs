using System;
using System.Collections.Generic;

namespace Dominio
{
    public class EscuelaArbitro
    {
        public int id {get;set;}
        public string Nombre{get;set;}
        public string Resolucion{get;set;}
        public string Direccion{get;set;}
        public string Telefono{get;set;}
        public string Correo{get;set;}

        //pripiedad navigacional
        public List<Arbitro> Arbitros{get;set;}
    }
}
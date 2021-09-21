using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Municipio
    {
        public int id {get;set;}
        public string Nombre{get;set;}
        //pripiedad navigacional con Torneo
        public List<Torneo> Torneos{get;set;}
    }
}

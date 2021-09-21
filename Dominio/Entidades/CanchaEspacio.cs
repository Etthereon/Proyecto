using System;
using System.Collections.Generic;

namespace Dominio
{
    public class CanchaEspacio
    {
        public int id {get;set;}
        public string Nombre{get;set;}
        public string Disciplina{get;set;}
        public string Estado{get;set;}
        public int CapacidadEspectadores{get;set;}
        public double Medidas{get;set;}
        
        //llave foranea
        public int EscenarioId{get;set;}

    }
}
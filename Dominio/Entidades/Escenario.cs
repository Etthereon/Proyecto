using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Escenario
    {
        public int id {get;set;}
        public string Nombre{get;set;}
        public string Direccion{get;set;}
        public string Telefono{get;set;}
        public string Horario{get;set;}

        //llaves foraneas
        public int TorneoId{get;set;}

        //pripiedad navigacional con Torneo
        public List<CanchaEspacio> CanchaEspacios{get;set;}
    }
}
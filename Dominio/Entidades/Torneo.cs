using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Torneo
    {
        public int id {get;set;}
        public string Nombre{get;set;}
        public string Categoria{get;set;}
        public DateTime FechaInicial{get;set;}
        public DateTime FechaFinal{get;set;}
        public string Tipo{get;set;}

        //llaves foraneas
        public int MunicipioId {get;set;}


        //pripiedades navigacionales
        public List<TorneoEquipo> TorneosEquipos{get;set;}
        public List<Escenario> Escenarios{get;set;}
        public List<Arbitro> Arbitros{get;set;}


    }
}

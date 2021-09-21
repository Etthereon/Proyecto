using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Equipo
    {
        public int id {get;set;}
        public string Nombre{get;set;}
        public int CantidadDeportistas {get;set;}
        public string Disciplina{get;set;}

        //pripiedad navigacional
        public List<Entrenador> Entrenador{get;set;}
        public List<TorneoEquipo> TorneoEquipos{get;set;}
        public List<Deportista> Deportistas{get;set;}

        //llaves foraneas
        public int PatrocinadorId {get;set;}
        
    }
}

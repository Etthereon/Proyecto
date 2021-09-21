using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Deportista
    {
        public int id {get;set;}
        public string Documento{get;set;}
        public string Nombres{get;set;}
        public string Apellidos{get;set;}
        public string Genero{get;set;}
        public string Rh{get;set;}
        public string EPS{get;set;}
        public DateTime FechaNac{get;set;}
        public string Disciplina{get;set;}
        public string Direccion{get;set;}
        public string NumeroEmergencia{get;set;}
        //llave foranea
        public int EquipoId{get;set;}

        //pripiedad navigacional con Torneo
        public List<Torneo> Torneos{get;set;}
    }
}
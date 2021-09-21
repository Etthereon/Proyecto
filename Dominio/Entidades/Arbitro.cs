using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Arbitro
    {
        public int id {get;set;}
        public string Documento{get;set;}
        public string Nombres{get;set;}
        public string Apellidos{get;set;}
        public string Genero{get;set;}
        public string Disciplina{get;set;}
        //llave foranea
        public int TorneoId{get;set;}
        public int EscuelaArbitro{get;set;}
    }
}
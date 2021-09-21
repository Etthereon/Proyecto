using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Entrenador
    {
        public int id {get;set;}
        public string Documento{get;set;}
        public string Nombres{get;set;}
        public string Apellidos{get;set;}
        public string Genero{get;set;}
        public string DeportistaDeportiva{get;set;}

        //llaves foraneas
        public int EquipoId{get;set;}
    }
}
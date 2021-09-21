using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Patrocinador
    {
        public int id {get;set;}
        public string Identificacion{get;set;}
        public string Nombre{get;set;}
        public string tipoPersona{get;set;}
        public string Direccion{get;set;}
        public string Telefono{get;set;}

        //pripiedad navigacional
        public List<Equipo> Equipos{get;set;}
    }
}
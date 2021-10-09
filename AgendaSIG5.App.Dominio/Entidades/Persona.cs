using System;

namespace AgendaSIG5.App.Dominio
{
    public class Persona
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Apellidos {get;set;}
        public string Telefonos {get;set;}
        public string ECorreo {get;set;}
        public string Direccion {get;set;}
        public string Eps {get;set;}
        public string Especialidad {get;set;}
        public string RegistroMedico {get;set;}
        public Genero Genero {get;set;}
        public int FK_Id_Sede {get;set;}
    }
}
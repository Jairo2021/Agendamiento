using System;
using System.ComponentModel.DataAnnotations;

namespace AgendaSIG5.App.Dominio
{
    public class Persona
    {
        public int Id {get;set;}
        [Required, StringLength(50)]
        public string Nombre {get;set;}
        [Required, StringLength(50)]
        public string Apellidos {get;set;}
        [Required, StringLength(50)]
        public string Telefonos {get;set;}
        [Required, StringLength(50)]
        public string ECorreo {get;set;}
        /*[Required, StringLength(50)]*/
        public string Direccion {get;set;}
        [Required, StringLength(50)]
        public string Eps {get;set;}
        /*[Required, StringLength(50)]*/
        public string Especialidad {get;set;}
        public string RegistroMedico {get;set;}
        public Genero Genero {get;set;}
        public int FK_Id_Sede {get;set;}
    }
}
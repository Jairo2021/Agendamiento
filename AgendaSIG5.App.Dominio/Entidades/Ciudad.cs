using System;
using System.ComponentModel.DataAnnotations;

namespace AgendaSIG5.App.Dominio
{
    public class Ciudad
    {
        public int Id {get;set;}
        [Required, StringLength(50)]
        public string NombreCiudad {get;set;}
    }
}
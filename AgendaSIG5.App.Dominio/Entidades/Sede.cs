using System;

namespace AgendaSIG5.App.Dominio
{
    public class Sede
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public int FK_Id_Ciudad {get; set;}
    }
}
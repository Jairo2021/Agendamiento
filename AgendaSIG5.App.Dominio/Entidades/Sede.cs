using System;

namespace AgendaSIG5.App.Dominio
{
    public class Sede
    {
        public Sede(int id, string nombre, int fK_Id_Ciudad) 
        {
            this.Id = id;
                this.Nombre = nombre;
                this.FK_Id_Ciudad = fK_Id_Ciudad;
               
        }
        public int Id {get;set;}
        public string Nombre {get;set;}
        public int FK_Id_Ciudad {get; set;}
    }
}
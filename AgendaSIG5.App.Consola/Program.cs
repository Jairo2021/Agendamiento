using System;
using AgendaSIG5.App.Dominio;
using AgendaSIG5.App.Persistencia;

namespace AgendaSIG5.App.Consola
{
    class Program
    {   
        //private static IRepositorioPersona _repoPersona=new RepositorioPersona(new Persistencia.AppContext());   

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Jairo Ramirez, welcome to AgendaSIG5!!!!");
            //AddPersona();
            Console.WriteLine("Persona Adicionada!!!!");            
            //BuscarPersona(1);
        }

        /*private static void AddPersona()
        {
            var persona =new Persona
            {
                Nombre="Carlos",
                Apellidos="Ramírez M",
                Telefonos="3112104330",
                Genero=Genero.Masculino,
                Direccion="Calle 12a # 1B Este-80",
                ECorreo="jairohramirezm@hotmail.com"
            };
            _repoPersona.AddPersona(persona);
        }*/

        /*private static void BuscarPersona(int idPersona)
        {
            var persona = _repoPersona.GetPersona(idPersona);
            Console.WriteLine("Nombre: "+persona.Nombre+" "+persona.Apellidos+"  Género: "+persona.Genero);
        }*/        
    }
}

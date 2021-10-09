using System;
using AgendaSIG5.App.Dominio;
using AgendaSIG5.App.Persistencia;

namespace AgendaSIG5.App.Consola
{
    class Program
    {   
        private static IRepositorioPersona _repoPersona=new RepositorioPersona();   

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Gastón Triana, welcome to AgendaSIG5!!!!");
            AddPersona();
            Console.WriteLine("Persona Adicionado!!!!");            
            BuscarPersona(1);
        }

        private static void AddPersona()
        {
            var persona =new Persona
            {
                Nombre="Gastón",
                Apellidos="Triana Lozano",
                Telefonos="3103897966",
                Genero=Genero.Masculino,
                Direccion="Carrera $9 # 52-65",
                ECorreo="gastontriana3000@hotmail.com"
            };
            _repoPersona.AddPersona(persona);
        }

        private static void BuscarPersona(int idPersona)
        {
            var persona = _repoPersona.GetPersona(idPersona);
            Console.WriteLine("Nombre: "+persona.Nombre+" "+persona.Apellidos+"  Género: "+persona.Genero);
        }        
    }
}

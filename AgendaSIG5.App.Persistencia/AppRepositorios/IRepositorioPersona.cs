using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using AgendaSIG5.App.Dominio;

namespace AgendaSIG5.App.Persistencia
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersonas();
        Persona AddPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        void DeletePersona(int idPersona);
        Persona GetPersona(int idPersona); 
        IEnumerable<Persona> GetAllPacientes();        
        IEnumerable<Persona> GetAllMedicos();  
    }
}
//Interface: Conjunto de métodos-encabezad
using System;
using System.Collections.Generic;
using System.Linq;
using AgendaSIG5.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace AgendaSIG5.App.Persistencia
{
     public class RepositorioPersona : IRepositorioPersona
     {
          private readonly AppContext _appContext = new AppContext();

          Persona IRepositorioPersona.AddPersona(Persona persona)
          {
            var personaAdicionado= _appContext.Personas.Add(persona);
            _appContext.SaveChanges(); //Se deben guardar los cambios
            return personaAdicionado.Entity;
          }

          void IRepositorioPersona.DeletePersona(int idPersona)
          {
            var personaEncontrado= _appContext.Personas.FirstOrDefault(p =>p.Id==idPersona);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            // var personaEncontrado = _appContext.Personas.Find(idPersona);
            if(personaEncontrado==null)
            return;
            _appContext.Personas.Remove(personaEncontrado);
            _appContext.SaveChanges();//Se deben guardar los cambios
          }

          IEnumerable <Persona> IRepositorioPersona.GetAllPersonas  ()
          {
            return _appContext.Personas;
             
          }

        Persona IRepositorioPersona.GetPersona (int idPersona)
          {
           return _appContext.Personas.FirstOrDefault(p =>p.Id==idPersona);//retorna lo que encuentra
           // return _appContext.Personas.Find(idPersona);           
          }

        Persona IRepositorioPersona.UpdatePersona  (Persona persona)
          {
           var personaEncontrado= _appContext.Personas.FirstOrDefault(p =>p.Id==persona.Id);
           //var personaEncontrado = _appContext.Personas.Find(persona.Id);           
           //No se busca el idPersona, se busca el persona.Id
           if(personaEncontrado!=null)
           {
                personaEncontrado.Nombre = persona.Nombre;
                personaEncontrado.Apellidos = persona.Apellidos;
                personaEncontrado.Telefonos = persona.Telefonos;
                personaEncontrado.ECorreo = persona.ECorreo;				
                personaEncontrado.Eps = persona.Eps;				
                personaEncontrado.Genero = persona.Genero;
                personaEncontrado.Especialidad = persona.Especialidad;				
                personaEncontrado.RegistroMedico = persona.RegistroMedico;						
                personaEncontrado.FK_Id_Sede = persona.FK_Id_Sede;
                _appContext.SaveChanges();        
           }
             return personaEncontrado; //retorna el Persona encontrado           
          }

        public IEnumerable<Persona> GetAllPacientes()
        {
            return _appContext.Personas
                        .Where(p => p.Especialidad == null)
                        .ToList();            
        } 

        public IEnumerable<Persona> GetAllMedicos()
        {
            return _appContext.Personas
                        .Where(p => p.Especialidad.Length > 0)
                        .ToList();
        }
     }
}
// implementa la interfaz

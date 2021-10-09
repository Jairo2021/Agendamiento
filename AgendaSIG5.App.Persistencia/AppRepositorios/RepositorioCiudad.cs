using System;
using System.Collections.Generic;
using System.Linq;
using AgendaSIG5.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace AgendaSIG5.App.Persistencia
{
     public class RepositorioCiudad : IRepositorioCiudad
     {
          private readonly AppContext _appContext = new AppContext();

          Ciudad IRepositorioCiudad.AddCiudad(Ciudad ciudad)
          {
            var CiudadAdicionado= _appContext.Ciudades.Add(ciudad);
            _appContext.SaveChanges(); //Se deben guardar los cambios
            return CiudadAdicionado.Entity;
          }

          void IRepositorioCiudad.DeleteCiudad(int idCiudad)
          {
            var CiudadEncontrado= _appContext.Ciudades.FirstOrDefault(p =>p.Id==idCiudad);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            // var ciudadEncontrado = _appContext.Ciudades.Find(idCiudad);
            if(CiudadEncontrado==null)
            return;
            _appContext.Ciudades.Remove(CiudadEncontrado);
            _appContext.SaveChanges();//Se deben guardar los cambios
          }

          IEnumerable <Ciudad> IRepositorioCiudad.GetAllCiudades  ()
          {
            return _appContext.Ciudades;
             
          }

        Ciudad IRepositorioCiudad.GetCiudad  (int idCiudad)
          {
           return _appContext.Ciudades.FirstOrDefault(p =>p.Id==idCiudad);//retorna lo que encuentra
           // return _appContext.Ciudades.Find(idCiudad);           
          }

        Ciudad IRepositorioCiudad.UpdateCiudad  (Ciudad ciudad)
          {
           var ciudadEncontrado= _appContext.Ciudades.FirstOrDefault(p =>p.Id==ciudad.Id);
           //var personaEncontrado = _appContext.Personas.Find(persona.Id);           
           //No se busca el idPersona, se busca el persona.Id
           if(ciudadEncontrado!=null)
           {
                ciudadEncontrado.NombreCiudad = ciudad.NombreCiudad;
                _appContext.SaveChanges();        
           }
             return ciudadEncontrado; //retorna la ciudad encontrada           
          }  
     }
}
// implementa la interfaz
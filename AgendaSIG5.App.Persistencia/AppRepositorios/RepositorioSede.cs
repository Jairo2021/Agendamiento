using System;
using System.Collections.Generic;
using System.Linq;
using AgendaSIG5.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace AgendaSIG5.App.Persistencia
{
     public class RepositorioSede : IRepositorioSede
     {
          private readonly AppContext _appContext = new AppContext();

          Sede IRepositorioSede.AddSede(Sede sede)
          {
            var sedeAdicionado= _appContext.Sedes.Add(sede);
            _appContext.SaveChanges(); //Se deben guardar los cambios
            return sedeAdicionado.Entity;
          }

          void IRepositorioSede.DeleteSede(int idSede)
          {
            var sedeEncontrado= _appContext.Sedes.FirstOrDefault(p =>p.Id==idSede);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            // var sedeEncontrado = _appContext.Sedes.Find(idSede);
            if(sedeEncontrado==null)
            return;
            _appContext.Sedes.Remove(sedeEncontrado);
            _appContext.SaveChanges();//Se deben guardar los cambios
          }

          IEnumerable <Sede> IRepositorioSede.GetAllSedes  ()
          {
            return _appContext.Sedes;
             
          }

        Sede IRepositorioSede.GetSede  (int idSede)
          {
           return _appContext.Sedes.FirstOrDefault(p =>p.Id==idSede);//retorna lo que encuentra
           // return _appContext.Sedes.Find(idSede);           
          }

        Sede IRepositorioSede.UpdateSede  (Sede sede)
          {
           var sedeEncontrado= _appContext.Sedes.FirstOrDefault(p =>p.Id==sede.Id);
           //var sedeEncontrado = _appContext.Sedes.Find(sede.Id);           
           //No se busca el idSede, se busca el sede.Id
           if(sedeEncontrado!=null)
           {
                sedeEncontrado.Nombre = sede.Nombre;
			    sedeEncontrado.FK_Id_Ciudad = sede.FK_Id_Ciudad;
                _appContext.SaveChanges();        
           }
             return sedeEncontrado; //retorna el Sede encontrado           
          }  
     }
}
// implementa la interfaz

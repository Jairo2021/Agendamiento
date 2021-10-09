using System;
using System.Collections.Generic;
using System.Linq;
using AgendaSIG5.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace AgendaSIG5.App.Persistencia
{
     public class RepositorioAgenda : IRepositorioAgenda
     {
          private readonly AppContext _appContext = new AppContext();

          Agenda IRepositorioAgenda.AddAgenda(Agenda agenda)
          {
            var agendaAdicionado= _appContext.AgendaCitas.Add(agenda);
            _appContext.SaveChanges(); //Se deben guardar los cambios
            return agendaAdicionado.Entity;
          }

          void IRepositorioAgenda.DeleteAgenda(int idAgenda)
          {
            var agendaEncontrado= _appContext.AgendaCitas.FirstOrDefault(p =>p.Id==idAgenda);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            // var agendaEncontrado = _appContext.AgendaCitas.Find(idAgenda);
            if(agendaEncontrado==null)
            return;
            _appContext.AgendaCitas.Remove(agendaEncontrado);
            _appContext.SaveChanges();//Se deben guardar los cambios
          }

          IEnumerable <Agenda> IRepositorioAgenda.GetAllAgendas  ()
          {
            return _appContext.AgendaCitas;
             
          }

        Agenda IRepositorioAgenda.GetAgenda  (int idAgenda)
          {
           return _appContext.AgendaCitas.FirstOrDefault(p =>p.Id==idAgenda);//retorna lo que encuentra
           // return _appContext.AgendaCitas.Find(idAgenda);           
          }

        Agenda IRepositorioAgenda.UpdateAgenda (Agenda agenda)
          {
           var agendaEncontrado= _appContext.AgendaCitas.FirstOrDefault(p =>p.Id==agenda.Id);
           //var agendaEncontrado = _appContext.AgendaCitas.Find(agenda.Id);           
           //No se busca el idAgenda, se busca el agenda.Id
           if(agendaEncontrado!=null)
           {
                agendaEncontrado.FK_Id_Sede = agenda.FK_Id_Sede;
                agendaEncontrado.FK_Id_Paciente = agenda.FK_Id_Paciente;
                agendaEncontrado.FK_Id_Medico = agenda.FK_Id_Medico;
                agendaEncontrado.FechaCita = agenda.FechaCita;
                agendaEncontrado.HoraCita = agenda.HoraCita;
                agendaEncontrado.Notas = agenda.Notas;				

                _appContext.SaveChanges();        
           }
             return agendaEncontrado; //retorna el Agenda encontrado           
          }  
     }
}
// implementa la interfaz

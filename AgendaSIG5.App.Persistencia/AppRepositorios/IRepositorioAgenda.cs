using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using AgendaSIG5.App.Dominio;

namespace AgendaSIG5.App.Persistencia
{
    public interface IRepositorioAgenda
    {
        IEnumerable<Agenda> GetAllAgendas();
        Agenda AddAgenda(Agenda agenda);
        Agenda UpdateAgenda(Agenda agenda);
        void DeleteAgenda(int idAgenda);
        Agenda GetAgenda(int idAgenda); 
    }
}
//Interface: Conjunto de métodos-encabezad
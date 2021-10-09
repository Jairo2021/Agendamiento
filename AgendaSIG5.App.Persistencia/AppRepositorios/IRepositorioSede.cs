using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using AgendaSIG5.App.Dominio;

namespace AgendaSIG5.App.Persistencia
{
    public interface IRepositorioSede
    {
        IEnumerable<Sede> GetAllSedes();
        Sede AddSede(Sede sede);
        Sede UpdateSede(Sede sede);
        void DeleteSede(int idSede);
        Sede GetSede(int idSede); 
    }
}
//Interface: Conjunto de métodos-encabezad
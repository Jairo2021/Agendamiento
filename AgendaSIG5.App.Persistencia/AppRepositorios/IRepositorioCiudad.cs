using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using AgendaSIG5.App.Dominio;

namespace AgendaSIG5.App.Persistencia
{
    public interface IRepositorioCiudad
    {
        IEnumerable<Ciudad> GetAllCiudades();
        Ciudad AddCiudad(Ciudad ciudad);
        Ciudad UpdateCiudad(Ciudad ciudad);
        void DeleteCiudad(int idCiudad);
        Ciudad GetCiudad(int idCiudad); 
    }
}
//Interface: Conjunto de métodos-encabezad
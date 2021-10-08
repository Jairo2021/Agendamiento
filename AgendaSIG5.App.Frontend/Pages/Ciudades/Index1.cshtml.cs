using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendaSIG5.App.Dominio;
using AgendaSIG5.App.Persistencia;

namespace AgendaSIG5.App.Frontend.Pages.Ciudades
{
    public class Index1Model : PageModel
    {
        private readonly IRepositorioCiudad _repoCiudad;

        public IEnumerable<Ciudad> ciudades {get; set;}

        public Index1Model(IRepositorioCiudad repoCiudad)
        {
            _repoCiudad = repoCiudad;
        }

        public void OnGet()
        {
            ciudades =_repoCiudad.GetAllCiudades();            
        }
    }
}

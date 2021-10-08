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
    public class Detalles1Model : PageModel
    {
        private readonly IRepositorioCiudad _repoCiudad;
		
        public Ciudad ciudad {get; set;}
		
        public Detalles1Model(IRepositorioCiudad repoCiudad)
        {
            _repoCiudad= repoCiudad;
        }

        public IActionResult OnGet(int id)
        {
            ciudad = _repoCiudad.GetCiudad(id);
            if (ciudad == null)
            {
                return NotFound();
            } else
            {
                return Page();
            }
        }
    }
}

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
    public class Crear1Model : PageModel
    {
        public Ciudad ciudad {get; set;}

        private readonly IRepositorioCiudad _repoCiudad;
        
        public Crear1Model(IRepositorioCiudad repoCiudad)
        {
            _repoCiudad = repoCiudad;
        }

        public IActionResult OnPost(Ciudad ciudad)
        {
            if (ModelState.IsValid)
            {
                _repoCiudad.AddCiudad(ciudad);
                return RedirectToPage("Index1");
            } else
            {
                return Page();
            }
        }
        
        public void OnGet()
        {
            ciudad= new Ciudad();
        }        
    }
}

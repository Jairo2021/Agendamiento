using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendaSIG5.App.Dominio;
using AgendaSIG5.App.Persistencia;

namespace AgendaSIG5.App.Frontend.Pages.Sedes
{
    public class Crear3Model : PageModel
    {
		// Incluir Ciudad para costruir la lista desplegable
        private readonly IRepositorioCiudad _repoCiudad;
		
		public IEnumerable<Ciudad> ciudades{get; set;}

        public Sede sede {get; set;}

        private readonly IRepositorioSede _repoSede;
        
        public Crear3Model(IRepositorioSede repoSede, IRepositorioCiudad repoCiudad)
        {
            _repoSede = repoSede;
			_repoCiudad = repoCiudad;			
        }

        public IActionResult OnPost(Sede sede)
        {
            if (ModelState.IsValid)
            {
                _repoSede.AddSede(sede);
                return RedirectToPage("Index3");
            } else
            {
                return Page();
            }
        }
        
        public void OnGet()
        {
            sede= new Sede();
            ciudades =_repoCiudad.GetAllCiudades();            		
        }      
    }
}
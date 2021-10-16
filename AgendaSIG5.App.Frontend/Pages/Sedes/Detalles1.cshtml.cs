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
    public class Detalles1Model : PageModel
    {
		// Incluir Ciudad para costruir la lista desplegable
        private readonly IRepositorioCiudad _repoCiudad;

        private readonly IRepositorioSede _repoSede;
		
        public Sede sede {get; set;}

        public Ciudad ciudad {get; set;}

        public String NombreCiudad {get; set;}

        public Detalles1Model(IRepositorioSede repoSede, IRepositorioCiudad repoCiudad)
        {
            _repoSede= repoSede;
			_repoCiudad = repoCiudad;	            
        }

        public IActionResult OnGet(int id)
        {
            sede = _repoSede.GetSede(id);
            if (sede == null)
            {
                return NotFound();
            } else
            {
                return Page();
            }
        }

        public void GetCiudad (int idCiudad)
        {
            ciudad = _repoCiudad.GetCiudad(idCiudad);
            if (ciudad == null)
            {
                NombreCiudad = "Ciudad NO Registrada";

            } else 
            {
                NombreCiudad = ciudad.NombreCiudad;
            }
        }
                
    }
}

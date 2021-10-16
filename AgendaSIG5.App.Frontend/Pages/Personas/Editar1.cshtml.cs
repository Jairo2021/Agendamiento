using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendaSIG5.App.Dominio;
using AgendaSIG5.App.Persistencia;

namespace AgendaSIG5.App.Frontend.Pages.Personas
{
    public class Editar1Model : PageModel
    {
		// Incluir Ciudad, Sede para costruir la lista desplegable
        private readonly IRepositorioCiudad _repoCiudad;
        private readonly IRepositorioSede _repoSede;

		public IEnumerable<Sede> sedes{get; set;}

        public Ciudad ciudad {get; set;}

        public String NombreCiudad {get; set;}        
        
        public Persona persona {get; set;}

        private readonly IRepositorioPersona _repoPersona;
        
        public Editar1Model(IRepositorioPersona repoPersona, IRepositorioSede repoSede, IRepositorioCiudad repoCiudad)
        {
            _repoPersona= repoPersona;
            _repoSede = repoSede;            
            _repoCiudad = repoCiudad;             
        }

        public IActionResult OnGet(int id)
        {
            sedes =_repoSede.GetAllSedes();             
            persona=_repoPersona.GetPersona(id);
            if (persona == null)
            {
                return NotFound();
            } else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Persona persona)
        {
            _repoPersona.UpdatePersona(persona);
            return RedirectToPage("Index1"); 
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

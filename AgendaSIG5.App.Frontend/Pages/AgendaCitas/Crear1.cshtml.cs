using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgendaSIG5.App.Dominio;
using AgendaSIG5.App.Persistencia;

namespace AgendaSIG5.App.Frontend.Pages.AgendaCitas
{
    public class Crear1Model : PageModel
    {
		// Incluir Ciudad, Sede para costruir la lista desplegable
        private readonly IRepositorioCiudad _repoCiudad;
        private readonly IRepositorioSede _repoSede;
		private readonly IRepositorioPersona _repoPersona;

		public IEnumerable<Sede> sedes{get; set;}

        public Ciudad ciudad {get; set;}

        public String NombreCiudad {get; set;}

		public IEnumerable<Persona> pacientes{get; set;}

		public IEnumerable<Persona> medicos{get; set;}		
		
        public Agenda agenda {get; set;}

        private readonly IRepositorioAgenda _repoAgenda;
        
        public Crear1Model(IRepositorioAgenda repoAgenda, IRepositorioPersona repoPersona, IRepositorioSede repoSede, IRepositorioCiudad repoCiudad)
        {
			_repoAgenda = repoAgenda;
            _repoPersona = repoPersona;
            _repoSede = repoSede;            
            _repoCiudad = repoCiudad;            
        }

        public IActionResult OnPost(Agenda agenda)
        {
            if (ModelState.IsValid)
            {
                _repoAgenda.AddAgenda(agenda);
                return RedirectToPage("Index1");
            } else
            {
                return Page();
            }
        }
        
        public void OnGet()
        {
            agenda= new Agenda();
            sedes =_repoSede.GetAllSedes();        
			pacientes =_repoPersona.GetAllPacientes();  
			medicos =_repoPersona.GetAllMedicos();  			
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

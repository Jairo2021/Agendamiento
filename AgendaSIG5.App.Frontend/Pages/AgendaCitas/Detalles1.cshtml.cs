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
    public class Detalles1Model : PageModel
    {
		// Incluir Persona, Ciudad, Sede para costruir la lista desplegable
        private readonly IRepositorioPersona _repoPersona;
        private readonly IRepositorioCiudad _repoCiudad;
        private readonly IRepositorioSede _repoSede;

        public Persona persona {get; set;}
        public Sede sede {get; set;}
        public Ciudad ciudad {get; set;}

        public String NombreSede {get; set;}    
        public String NombreCiudad {get; set;}        

        private readonly IRepositorioAgenda _repoAgenda;
		
        public Agenda agenda {get; set;}
		
        public Detalles1Model(IRepositorioAgenda repoAgenda, IRepositorioPersona repoPersona, 
                            IRepositorioSede repoSede, IRepositorioCiudad repoCiudad)
        {
            _repoAgenda = repoAgenda;
            _repoPersona= repoPersona;
            _repoSede = repoSede;            
            _repoCiudad = repoCiudad;              
        }

        public IActionResult OnGet(int id)
        {
            agenda = _repoAgenda.GetAgenda(id);
            if (agenda == null)
            {
                return NotFound();
            } else
            {
                return Page();
            }
        }

        public void GetSede (int idSede)
        {
            sede = _repoSede.GetSede(idSede);
            if (sede == null)
            {
                NombreSede = "Sede NO Registrada";

            } else 
            {
                NombreSede = sede.Nombre;
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

        public Persona GetPersona (int idPersona)
        {
            persona = _repoPersona.GetPersona(idPersona);
            if (persona == null)
            {
                persona.Nombre = "Persona NO Registrada";
                return persona;
            } else 
            {
                return persona;
            }
        }                       
    }
}

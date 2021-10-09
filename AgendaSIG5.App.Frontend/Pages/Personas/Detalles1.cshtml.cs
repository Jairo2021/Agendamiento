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
    public class Detalles1Model : PageModel
    {
        private readonly IRepositorioPersona _repoPersona;
		
        public Persona persona {get; set;}
		
        public Detalles1Model(IRepositorioPersona repoPersona)
        {
            _repoPersona= repoPersona;
        }

        public IActionResult OnGet(int id)
        {
            persona = _repoPersona.GetPersona(id);
            if (persona == null)
            {
                return NotFound();
            } else
            {
                return Page();
            }
        }
    }
}

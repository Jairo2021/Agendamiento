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
        public Persona persona {get; set;}

        private readonly IRepositorioPersona _repoPersona;
        
        public Editar1Model(IRepositorioPersona repoPersona)
        {
            _repoPersona= repoPersona;
        }

        public IActionResult OnGet(int id)
        {
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
    }
}

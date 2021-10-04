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
    public class Crear1Model : PageModel
    {
        public Persona persona {get; set;}

        private readonly IRepositorioPersona _repoPersona;
        
        public Crear1Model(IRepositorioPersona repoPersona)
        {
            _repoPersona = repoPersona;
        }

        public IActionResult OnPost(Persona persona)
        {
            if (ModelState.IsValid)
            {
                _repoPersona.AddPersona(persona);
                return RedirectToPage("Index1");
            } else
            {
                return Page();
            }
        }
        
        public void OnGet()
        {
            persona= new Persona();
        }        
    }
}

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
    public class Index1Model : PageModel
    {
        private readonly IRepositorioPersona _repoPersona;

        public IEnumerable<Persona> personas {get; set;}

        public Index1Model(IRepositorioPersona repoPersona)
        {
            _repoPersona = repoPersona;
        }

        public void OnGet()
        {
            personas =_repoPersona.GetAllPersonas();            
        }
    }
}

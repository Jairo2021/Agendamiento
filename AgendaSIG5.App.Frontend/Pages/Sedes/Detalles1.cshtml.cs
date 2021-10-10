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
        private readonly IRepositorioSede _repoSede;
		
        public Sede sede {get; set;}
		
        public Detalles1Model(IRepositorioSede repoSede)
        {
            _repoSede= repoSede;
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
    }
}

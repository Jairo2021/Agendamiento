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
    public class Editar1Model : PageModel
    {
        public Sede sede {get; set;}

        private readonly IRepositorioSede _repoSede;
        
        public Editar1Model(IRepositorioSede repoSede)
        {
            _repoSede= repoSede;
        }

        public IActionResult OnGet(int id)
        {
            sede=_repoSede.GetSede(id);
            if (sede == null)
            {
                return NotFound();
            } else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Sede sede)
        {
            _repoSede.UpdateSede(sede);
            return RedirectToPage("Index1"); 
        }
    }
}

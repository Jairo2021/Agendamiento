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
    public class Index3Model : PageModel
    {
        private readonly IRepositorioSede _repoSede;

        public IEnumerable<Sede> sedes {get; set;}

        public Index3Model(IRepositorioSede repoSede)
        {
            _repoSede = repoSede;
        }

        public void OnGet()
        {
            sedes =_repoSede.GetAllSedes();            
        }
    }
}

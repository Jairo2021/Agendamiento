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
    public class Index1Model : PageModel
    {
		// Incluir Ciudad para costruir la lista desplegable
        private readonly IRepositorioCiudad _repoCiudad;

        private readonly IRepositorioSede _repoSede;

        public IEnumerable<Sede> sedes {get; set;}

        public Ciudad ciudad {get; set;}

        public String NombreCiudad {get; set;}

        public Index1Model(IRepositorioSede repoSede, IRepositorioCiudad repoCiudad)
        {
            _repoSede = repoSede;
			_repoCiudad = repoCiudad;	            
        }

        public void OnGet()
        {
            sedes =_repoSede.GetAllSedes();          
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

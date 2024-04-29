using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using Tilmeldingskatalog.Pages.Models;


namespace Tilmeldingskatalog
{
    public class KredsOversigtModel : PageModel
    {
        public List<Kreds> _kredse {  get; set; }
        [BindProperty]
        public Kreds _kreds { get; set; }
        FordelingsKatalog _fk;
        public KredsOversigtModel(FordelingsKatalog fk)
        {
            _fk = fk;
            _kredse = _fk.GetKreds();
        }
        public void OnGet()
        {
            
        }
    }
}

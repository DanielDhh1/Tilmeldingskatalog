using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using Tilmeldingskatalog.Pages.Models;


namespace Tilmeldingskatalog.Pages
{
    public class KredsModel : PageModel
    {
        [BindProperty]
        public FordelingsKatalog _fk {  get; set; }
        public List<Kreds> _kredse {  get; set; }
        public KredsModel()
        {
            _fk = new FordelingsKatalog();
        }
        public IActionResult OnGet()
        {
           _kredse = _fk.GetKreds();
            return Page();
        }
    }
}

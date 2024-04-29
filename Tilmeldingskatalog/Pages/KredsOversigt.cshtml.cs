using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using Tilmeldingskatalog.Pages.Models;


namespace Tilmeldingskatalog
{
    public class KredsModel : PageModel
    {
        public List<Kreds> _kredse {  get; set; }
        [BindProperty]
        public Kreds _kreds { get; set; }
        FordelingsKatalog _fk;
        public KredsModel(FordelingsKatalog fk)
        {
            _fk = fk;
            _kredse = _fk.GetKreds();
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            _fk.AddKreds(_kreds);
            return RedirectToPage("Kreds");
        }
    }
}

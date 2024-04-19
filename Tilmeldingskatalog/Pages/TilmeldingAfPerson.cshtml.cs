using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tilmeldingskatalog.Pages.Models;

namespace Tilmeldingskatalog.Pages
{
    public class TilmeldingAfPersonModel : PageModel
    {
        public Person Person { get; set; }
        TilmeldingsCatalog tk;
        public TilmeldingAfPersonModel()
        {
            tk = new TilmeldingsCatalog();
        }
        public void OnGet()
        {

        }
    }
}

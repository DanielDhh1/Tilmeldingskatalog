using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using Tilmeldingskatalog.Pages.Models;

namespace Tilmeldingskatalog.Pages
{
    public class TilmeldingAfPersonModel : PageModel
    {
        public List<Person> people { get; set; }
        [BindProperty]
        public Person Person { get; set; }
        TilmeldingsCatalog _tk;
        public TilmeldingAfPersonModel(TilmeldingsCatalog tk)
        {
            _tk = tk;
            people = _tk.PrintPeople();
        }
        public IActionResult OnPost()
        {
            _tk.AddPerson(Person);
            Debug.WriteLine(Person);
            return RedirectToPage("TilmeldingAfPerson");
        }
    }
}

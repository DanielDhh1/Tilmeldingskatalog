using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using Tilmeldingskatalog.Pages.Models;

namespace Tilmeldingskatalog.Pages
{
    public class TilmeldtePersoner : PageModel
    {
        public List<Person> people { get; set; }
        [BindProperty]
        public Person Person { get; set; }
        TilmeldingsCatalog _tk;
        public TilmeldtePersoner(TilmeldingsCatalog tk)
        {
            _tk = tk;
            people = tk.PrintPeople();
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            _tk.AddPerson(Person);
            return RedirectToPage("TilmeldtePersoner");
        }
    }
}

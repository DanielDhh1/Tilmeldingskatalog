using System.Reflection.Metadata.Ecma335;

namespace Tilmeldingskatalog.Pages.Models
{
    public class FordelingsKatalog
    {
        List<Kreds> _kredse;
        public FordelingsKatalog()
        {
            _kredse = new List<Kreds>();
            _kredse.Add(new Kreds("Ugabuga", "Ugabugalugostræde", 22, 1));
            _kredse.Add(new Kreds("Ugabuga", "Ugabugalugostræde", 22, 1));
            _kredse.Add(new Kreds("Ugabuga", "Ugabugalugostræde", 22, 1));
        }
        public List<Kreds> GetKreds()
        {
            return _kredse;
        }
    }
}

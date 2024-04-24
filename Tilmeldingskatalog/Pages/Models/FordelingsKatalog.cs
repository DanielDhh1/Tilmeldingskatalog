using System.Reflection.Metadata.Ecma335;

namespace Tilmeldingskatalog.Pages.Models
{
    public class FordelingsKatalog
    {
        public Kreds _kreds { get; set; }
        List<Kreds> _kredse;
        public FordelingsKatalog()
        {
            _kredse = new List<Kreds>();
            _kredse.Add(new Kreds("Ugabuga", "Ugabugalugostræde", 22, 1));
        }

        public List<Kreds> NewKreds()
        {
            _kreds = new Kreds("","",0,0);
            return _kredse;
        }
        public List<Kreds> AddKreds(Kreds kreds)
        {
            _kredse.Add(kreds);
            return _kredse;
        }
        public void DeleteKreds(Kreds kreds)
        {
            _kredse.Remove(kreds);
        }
        public List<Kreds> GetKreds()
        {
            return _kredse;
        }
    }
}

using Tilmeldingskatalog.Pages.Models;

namespace Tilmeldingskatalog
{
    public interface IRepositoryCRUD
    {
        public void AddPerson(Person person);

        public void RemovePerson(Person person);

        public List<Person> PrintPeople();
    }
}

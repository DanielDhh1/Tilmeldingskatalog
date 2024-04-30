using System.Security.Cryptography.X509Certificates;

namespace Tilmeldingskatalog.Pages.Models
{
    public class TilmeldingsCatalog
    {       
        List<Person> people;


        public TilmeldingsCatalog()
        {
            people = new List<Person>();
            people.Add(new Person("Klaus", 25156585, "klauslauersen@hotmail.com", "Yeetskeetstræde 420, Blazeville02", 42));
        }
        public void AddPerson(Person person)
        {
            people.Add(person);
        }
        public void RemovePerson(Person person)
        {
            people.Remove(person);
        }
        public List<Person> PrintPeople()
        {
            return people;
        }       
    }             
}
        
                
                
    





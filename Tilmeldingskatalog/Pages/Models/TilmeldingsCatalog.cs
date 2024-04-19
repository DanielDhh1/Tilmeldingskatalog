namespace Tilmeldingskatalog.Pages.Models
{
    public class TilmeldingsCatalog
    {       
        List<Person> people;


        public TilmeldingsCatalog()
        {
            people = new List<Person>();
        }
        public void AddPerson(Person person)
        {
            people.Add(person);
        }
        public void RemovePerson(Person person)
        {
            people.Remove(person);
        }
        public void PrintPeople()
        {
            foreach (Person person in people)
            {
                Console.WriteLine($"{person}");
            }
        Console.WriteLine();
        }
    }
}




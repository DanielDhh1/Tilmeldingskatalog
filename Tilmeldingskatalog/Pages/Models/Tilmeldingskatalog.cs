namespace Tilmeldingskatalog.Pages.Models
{
    public class Tilmeldingskatalog
    {       
        List<Person> people;


        public Tilmeldingskatalog()
        {
            people = new List<Person>();
        }
        public void AddPerson(Person person)
        {
            people.Add(person);

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




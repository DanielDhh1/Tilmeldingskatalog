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
        public void Tilmeldingschoice()
        {
            while (true)
            {
                Console.WriteLine("Badetidskatalog");
                Console.WriteLine("1: Tilmelding");
                Console.WriteLine("2: Afmelding");

                int choice = GetUserChoice(2);
                switch(choice)
                {
                    case 1:
                        AddKreds();
                        break;
                }
            }

            
        }
    }
}




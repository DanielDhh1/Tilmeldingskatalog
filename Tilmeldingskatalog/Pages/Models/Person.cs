namespace Tilmeldingskatalog.Pages.Models
{
    public class Person
    {
        public string _name;
        public int _phoneNumber;
        public string _email;
        public string _adress;
        public int _age;


        public string Name { get => _name; set => _name = value; }
        public int Phonenumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string Email { get => _email; set => _email = value; }
        public string Adress { get => _adress; set => _adress = value; }
        public int Age { get => _age; set => _age = value; }
        public Person(string name, int phonenumber, string email, string adress, int age)
        {
            _name = name;
            _phoneNumber = phonenumber;
            _email = email;
            _adress = adress;
            _age = age;
        }
        public override string ToString()
        {
            return $"{Name} + {Phonenumber} + {Email} + {Adress} + {Age}";
        }
    }

}




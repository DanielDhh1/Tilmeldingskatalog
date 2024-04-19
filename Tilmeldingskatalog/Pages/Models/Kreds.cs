using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace Tilmeldingskatalog.Pages.Models
{
    public class Kreds
    {
        public string _name;
        public string _adress;
        public int _total;
        public int _id;

        public string Name { get =>  _name; set => _name = value;}
        public string Adress { get => _adress; set => _adress = value;}
        public int Total { get => _total; set => _total = value;}
        public int Id { get => _id; set => _id = value;}

        public Kreds(string name, string adress, int total, int id)
        {
            _name = name;
            _adress = adress;
            _total = total;
            _id = id;
        }  
    }
}


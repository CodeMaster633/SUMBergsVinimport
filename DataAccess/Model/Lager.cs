using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Lager
    {
        public Lager() { }

        public Lager(string navn, string adresse, string kontaktperson)
        {
            Navn = navn;
            Adresse = adresse;
            Kontaktperson = kontaktperson;
        }

        public string Navn { get; set; }
        public string Adresse { get; set; }
        public string Kontaktperson { get; set; }
    }
}

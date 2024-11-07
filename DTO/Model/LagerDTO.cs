using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class LagerDTO
    {
        public LagerDTO() { }

        public LagerDTO(string navn, string adresse, string kontaktperson)
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

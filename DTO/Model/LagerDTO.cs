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

        public LagerDTO(int id, string navn, string adresse, string kontaktperson)
        {
            Id = id;
            Navn = navn;
            Adresse = adresse;
            Kontaktperson = kontaktperson;
        }

        public int Id { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public string Kontaktperson { get; set; }
    }
}

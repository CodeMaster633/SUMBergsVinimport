using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_.Model
{
    public class LagerDTO
    {
        public LagerDTO() { }

        public LagerDTO(string navn, string adresse, string kontaktperson)
        {

            Navn = navn;
            Adresse = adresse;
            Kontaktperson = kontaktperson;
            Reoler = new List<ReolDTO>();

        }
        [Key]
        public int LagerId { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public string Kontaktperson { get; set; }
        public List<ReolDTO> Reoler {get;set;}
    }
}

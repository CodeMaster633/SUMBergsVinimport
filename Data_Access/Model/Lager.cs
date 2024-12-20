﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Model
{
    public class Lager
    {
        public Lager() { }

        public Lager(string navn, string adresse, string kontaktperson)
        {

            Navn = navn;
            Adresse = adresse;
            Kontaktperson = kontaktperson;
            Produkter = new List<Produkt>();

        }
        [Key]
        public int LagerId { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public string Kontaktperson { get; set; }
        public List<Produkt> Produkter {get;set;}

       
    }
}

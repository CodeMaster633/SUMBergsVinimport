using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Mappers
{
    internal class LagerMapper
    {
        public static LagerDTO Map(Lager lager)
        {
            return new LagerDT(lager.Navn, lager.Adresse, lager.Kontaktperson);
        }
        public static Lager Map(LagerDTO lager)
        {
            return new Lager(lager.Navn, lager.Adresse, lager.Kontaktperson);
        }
    }
}

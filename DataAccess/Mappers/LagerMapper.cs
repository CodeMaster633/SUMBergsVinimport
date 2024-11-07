using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappers
{
    internal class LagerMapper
    {
        public static LagerDTO Map(Lager lager)
        {
            return new LagerDTO(lager.Id, lager.Navn, lager.Adresse, lager.Kontaktperson);
        }
        public static Lager Map(LagerDTO lager)
        {
            return new Lager(lager.Id, lager.Navn, lager.Adresse, lager.Kontaktperson);
        }
    }
}

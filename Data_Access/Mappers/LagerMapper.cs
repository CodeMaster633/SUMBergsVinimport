using DTO_.Model;
using Data_Access.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access.Model;

namespace Data_Access.Mappers
{
    internal class LagerMapper
    {
        public static LagerDTO Map(Lager lager)
        {
           LagerDTO lagerDTO = new LagerDTO(lager.Navn, lager.Adresse, lager.Kontaktperson);
            lagerDTO.LagerId = lager.LagerId;

            return lagerDTO;
        }
        public static Lager Map(LagerDTO lager)
        {
           Lager lagerModel =  new Lager(lager.Navn, lager.Adresse, lager.Kontaktperson);
            lagerModel.LagerId = lager.LagerId;
            return lagerModel;

        }
    }
}

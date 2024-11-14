using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Model
{
    public class Hylde
    {

        public Hylde() { }
        public int HyldeId { get; set; }
        public Reol Reol { get; set; }
        public int ReolId { get; set; }
        public List<Plads> Pladser { get; set; }


        public void Tilføj(Plads plads)
        {
            if (plads != null)
            {
                Pladser.Add(plads);
            }
        }
    }
}

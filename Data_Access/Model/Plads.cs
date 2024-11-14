using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Model
{
    public class Plads
    {

        public Plads() { }
        public int PladsId { get; set; }
        public Hylde Reol { get; set; }
        public int HyldeId { get; set; }
       // public IProdukt Produkt { get; set; }

    }
}

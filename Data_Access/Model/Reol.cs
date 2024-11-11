using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Model
{
    public class Reol
    {

        public Reol() { }
        public int ReolId { get; set; }
        public Lager Lager { get; set; }
        public int LagerId { get; set; }
    }
}

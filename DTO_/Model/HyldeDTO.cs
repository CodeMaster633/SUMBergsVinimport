using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DTO_.Model
{
    public class HyldeDTO
    {

        public HyldeDTO() { }
        public int HyldeId { get; set; }
        public ReolDTO Reol { get; set; }
        public int ReolId { get; set; }
        public List<PladsDTO> Pladser { get; set; }


        public void Tilføj(PladsDTO plads)
        {
            if (plads != null)
            {
                Pladser.Add(plads);
            }
        }
    }
}

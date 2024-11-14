using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_.Model
{
    public class ReolDTO
    {

        public ReolDTO() { }
        public int ReolId { get; set; }
        public LagerDTO Lager { get; set; }
        public int LagerId { get; set; }
        public List<HyldeDTO> Hylder { get; set; }


        public void Tilføj(HyldeDTO hylde)
        {
            if (hylde != null)
            {
                Hylder.Add(hylde);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_.Model
{
    public class PladsDTO
    {

        public PladsDTO() { }
        public int PladsId { get; set; }
        public HyldeDTO Reol { get; set; }
        public int HyldeId { get; set; }
        public IProdukt produkt { get; set; }

    }
}

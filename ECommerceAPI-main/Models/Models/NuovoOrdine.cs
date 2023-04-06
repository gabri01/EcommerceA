using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class NuovoOrdine
    {
      
        public List<Prodotto> Prodotti { get; set; }
        public string IndirizzoSpedizione { get; set; }
        public int IDUtente { get; set; }
        public int IDCorriere { get; set; }
        public int IdPagamento { get; set; }
        public int IdStato { get; set; }
    }
}

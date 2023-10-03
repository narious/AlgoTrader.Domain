using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTrader.Domain.Models
{
    public class AssetTransaction : DomainObject
    {
        public DateTime DateProcessed { get; set; }
        public Account Account { get; set; }
        public Stock Stock { get; set; }
        public int Quantity { get; set; }
        public Currency_e Currency { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTrader.Domain.Models
{
    public class Stock
    {
        public StockTicket_e Ticket { get; set; }
        public int Price { get; set; }
        public Currency_e Currency { get; set; }
    }
}

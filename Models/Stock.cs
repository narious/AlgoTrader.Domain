using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTrader.Domain.Models
{
    public class Stock
    {
        // Could also embedd the stock into the database by using an override
        public int Id { get; set; }
        public StockTicket_e Ticket { get; set; }
        public int Price { get; set; }
        public Currency_e Currency { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTrader.Domain.Models
{
    public class AssetTransaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Account Account { get; set; }
        public Stock Stock { get; set; }
        public int Quantity { get; set; }
        public Currency_e Currency { get; set; }

        public AssetTransaction(int id, DateTime date, Account account, Stock stock, int quantity)
        {
            Id = id;
            Date = date;
            Account = account;
            Stock = stock;
            Quantity = quantity;
        }
    }
}

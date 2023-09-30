using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTrader.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }
        public User AccountHolder {  get; set; }
        public double Balance { get; set; }
        public IEnumerable<AssetTransaction> TransactionList { get; set; }
        public Currency_e Currency { get; set; }
    }
}

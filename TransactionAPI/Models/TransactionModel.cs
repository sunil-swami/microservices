using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransactionAPI.Models
{
    public class TransactionModel
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }
}

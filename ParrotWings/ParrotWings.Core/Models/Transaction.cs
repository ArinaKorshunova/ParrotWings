using System;

namespace ParrotWings.Core.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public DateTime CreateDateTime { get; set; }
        public double Amount { get; set; }
        public double ResultBalance { get; set; }
    }
}

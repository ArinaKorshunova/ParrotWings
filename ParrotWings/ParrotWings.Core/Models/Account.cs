using System.Collections.Generic;

namespace ParrotWings.Core.Models
{
    public class Account : BaseModel
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}

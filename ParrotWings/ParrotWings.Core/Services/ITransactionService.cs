using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ParrotWings.Core.Services
{
    public interface ITransactionService
    {
        Task<IEnumerable<Transaction>> GetTransactionsByAccountId(int id);
        Task<Transaction> GetTransactionById(int id);
        Task CreateTransaction(Transaction transaction);
    }
}

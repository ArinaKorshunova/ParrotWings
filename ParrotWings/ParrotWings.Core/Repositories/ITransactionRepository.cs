using ParrotWings.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParrotWings.Core.Repositories
{
    public interface ITransactionRepository : IRepository<Transaction>
    {
        Task<IEnumerable<Transaction>> GetTransactionsByAccountId(int accountId);
    }
}

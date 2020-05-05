using Microsoft.EntityFrameworkCore;
using ParrotWings.Core.Models;
using ParrotWings.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParrotWings.DataLayer.Repositories
{
    public class TransactionRepository : Repository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(ParrotWingsContext context)
               : base(context)
        { }

        private ParrotWingsContext ParrotWingsContext
        {
            get { return Context as ParrotWingsContext; }
        }

        public async Task<IEnumerable<Transaction>> GetTransactionsByAccountId(int accountId)
        {
            return await ParrotWingsContext.Transactions
                   .Include(m => m.Account)
                   .Where(m => m.AccountId == accountId)
                   .ToListAsync();
        }
    }
}

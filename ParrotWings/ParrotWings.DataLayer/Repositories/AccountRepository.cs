using Microsoft.EntityFrameworkCore;
using ParrotWings.Core.Models;
using ParrotWings.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParrotWings.DataLayer.Repositories
{
    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        public AccountRepository(ParrotWingsContext context)
               : base(context)
        { }

        private ParrotWingsContext ParrotWingsContext
        {
            get { return Context as ParrotWingsContext; }
        }

        public async Task<Account> GetAccountByUserId(int id)
        {
            return await ParrotWingsContext.Accounts
                .SingleOrDefaultAsync(x => x.UserId == id);
        }
    }
}

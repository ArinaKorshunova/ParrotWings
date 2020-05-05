using ParrotWings.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParrotWings.Core.Services
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAccountsByUserId(int id);
        Task<Account> GetAccountById(int id);
        Task CreateAccount(Account account);
        Task UpdateAccount(Account account);
        void RemoveAccount(int id);
    }
}

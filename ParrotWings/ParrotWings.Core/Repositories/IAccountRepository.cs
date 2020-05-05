using ParrotWings.Core.Models;
using System.Threading.Tasks;

namespace ParrotWings.Core.Repositories
{
    public interface IAccountRepository : IRepository<Account>
    {
        Task<Account> GetAccountByUserId(int id);
    }
}

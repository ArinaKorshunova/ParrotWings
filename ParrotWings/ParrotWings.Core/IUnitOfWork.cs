using ParrotWings.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace ParrotWings.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IAccountRepository Accounts { get; }
        ITransactionRepository Transactions { get; }
        Task<int> CommitAsync();
    }
}

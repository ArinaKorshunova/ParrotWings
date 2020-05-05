using ParrotWings.Core;
using ParrotWings.Core.Repositories;
using ParrotWings.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParrotWings.DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ParrotWingsContext _context;
        private AccountRepository _accountRepository;
        private TransactionRepository _transactionRepository;

        public UnitOfWork(ParrotWingsContext context)
        {
            this._context = context;
        }


        public IAccountRepository Accounts => _accountRepository = _accountRepository ?? new AccountRepository(_context);

        public ITransactionRepository Transactions => _transactionRepository = _transactionRepository ?? new TransactionRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

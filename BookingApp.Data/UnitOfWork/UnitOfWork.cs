
using BookingApp.Data.Context;
using Microsoft.EntityFrameworkCore.Storage;

namespace BookingApp.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BookingAppDbContext _db;
        private IDbContextTransaction _transaction;

        public UnitOfWork(BookingAppDbContext db)
        {
            _db = db;
        }

        public async Task BeginTransaction()
        {
            _transaction = await _db.Database.BeginTransactionAsync();
        }

        public async Task CommitTransaction()
        {
            await _transaction.CommitAsync();
        }

        public void Dispose()
        {
            // Garbage Collector'a sen bunu silebilirsin izni verir
            // Hemen silinmez silinebilir yapıyor
            _db.Dispose();

            // Bu kodlar GC yi direkt çalıştırır.
            // GC.Collect();
            // GC.WaitForPendingFinalizers();
        }

        public async Task RollBackTransaction()
        {
            await _transaction.RollbackAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _db.SaveChangesAsync();
        }
    }
}
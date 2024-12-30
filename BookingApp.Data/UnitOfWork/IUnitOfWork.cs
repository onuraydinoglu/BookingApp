namespace BookingApp.Data
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> SaveChangesAsync();
        Task BeginTransaction();
        Task CommitTransaction();
        Task RollBackTransaction();
    }
}
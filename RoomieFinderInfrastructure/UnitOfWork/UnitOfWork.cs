using Microsoft.EntityFrameworkCore;
using RoomieFinderInfrastructure.Data;


namespace RoomieFinderInfrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RoomieFinderDbContext _context;

        public UnitOfWork(RoomieFinderDbContext context)
        {
            _context = context;
        }

        public async Task AddEntityAsync<T>(T entity) where T : class =>
           await GetDbSet<T>().AddAsync(entity);

        public IQueryable<T> GetAllAsReadOnlyAsync<T>() where T : class =>
            GetDbSet<T>().AsNoTracking();


        public IQueryable<T> GetAllAsync<T>() where T : class =>
            GetDbSet<T>();

        public void RemoveEntity<T>(T entity) where T : class =>
            _context.Remove(entity);

        public void RemoveAll<T>(List<T> entities) where T : class =>
            _context.RemoveRange(entities);


        public async Task SaveChangesAsync() =>
            await _context.SaveChangesAsync();


        private DbSet<T> GetDbSet<T>() where T : class =>
            _context.Set<T>();

        public async Task AddManyAsync<T>(List<T> entities) where T : class =>
           await _context.AddRangeAsync(entities);

        public async Task<T?> GetById<T>(object id) where T : class =>
            await GetDbSet<T>().FindAsync(id);

    }
}

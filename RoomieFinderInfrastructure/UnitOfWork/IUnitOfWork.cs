

namespace RoomieFinderInfrastructure.UnitOfWork
{
    public interface IUnitOfWork
    {
        public Task AddEntityAsync<T>(T entity) where T : class;
        public void RemoveEntity<T>(T entity) where T : class;
        public void RemoveAll<T>(List<T> entities) where T : class;
        public Task<T?> GetOneAsync<T>() where T : class;
        public IQueryable<T> GetAllAsReadOnlyAsync<T>() where T : class;
        public IQueryable<T> GetAllAsync<T>() where T : class;

        public Task SaveChangesAsync();
    }
}

using FactoryDesignPattern.Interfaces;

namespace FactoryDesignPattern.Implementation
{
    public static class RepositoryFactoryClass
    {
        public static TRepository CreateRepository<TRepository>() where TRepository : IRepository, new()
        {
            return new TRepository();
        }
    }
}

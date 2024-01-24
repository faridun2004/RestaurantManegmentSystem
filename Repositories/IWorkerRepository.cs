using RestaurantManegmentSystem.Models;

namespace RestaurantManegmentSystem.Repositories
{
    public interface IWorkerRepository
    {
        IEnumerable<Worker> GetAll();
        Worker GetById(Guid id);
        bool Create(Worker worker);
        bool Update(Worker item);
        bool Delete(Guid id);
    }
}

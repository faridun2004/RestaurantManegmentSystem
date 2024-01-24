using RestaurantManegmentSystem.Models;

namespace RestaurantManegmentSystem.Services
{
    public interface IWorkerService
    {
        IEnumerable<Worker> GetAll();
        Worker GetById(Guid id);
        string Create(Worker worker);
        string Update(Guid id, Worker item);
        string Delete(Guid id);
    }
}

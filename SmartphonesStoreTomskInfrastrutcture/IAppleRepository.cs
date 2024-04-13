using SmartphoneStoreTomsk.Domain.Models;

namespace SmartphonesStoreTomskInfrastrutcture
{
    public interface IAppleRepository
    {
        Task<Guid> CreateApple(Apple apple);
        Task<Guid> DeleteApple(Guid id);
        Task<List<Apple>> GetApple();
        Task<Guid> Update(Guid id, string model, string description, decimal price, int quantity);
    }
}
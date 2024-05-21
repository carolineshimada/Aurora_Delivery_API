using AuroraDelivery.Domain.Entities;
using FluentValidation;

namespace AuroraDelivery.Domain.Interface
{
    public interface IBaseService<T> where T : class
    {
        IEnumerable<T> Get();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}

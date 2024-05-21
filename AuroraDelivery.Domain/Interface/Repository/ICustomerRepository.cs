using AuroraDelivery.Domain.Entities;
using AuroraDelivery.Domain.Interfaces.Repositories;

namespace AuroraDelivery.Domain.Interface.Repository
{
    namespace AuroraDelivery.Domain.Interfaces.Repositories
    {
        public interface ICustomerRepository : IBaseRepository<Customer>
        {
            // Aqui você pode definir métodos específicos para Customer, se necessário
        }
    }

}

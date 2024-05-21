using AuroraDelivery.Domain.Entities;
using AuroraDelivery.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

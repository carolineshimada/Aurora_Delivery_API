using AuroraDelivery.Domain.Entities;
using AuroraDelivery.Domain.Interface;
using AuroraDelivery.Domain.Interface.Repository.AuroraDelivery.Domain.Interfaces.Repositories;

namespace AuroraDelivery.Service.Services
{
    public class CustomerService : IBaseService<Customer>
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<Customer> Get()
        {
            return _customerRepository.Get();
        }

        public Customer GetById(int id)
        {
            return _customerRepository.GetById(id);
        }

        public void Add(Customer entity)
        {
            _customerRepository.Add(entity);
        }

        public void Update(Customer entity)
        {
            _customerRepository.Update(entity);
        }

        public void Delete(int id)
        {
            _customerRepository.Delete(id);
        }
    }
}

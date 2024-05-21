using AuroraDelivery.Domain.Entities;
using AuroraDelivery.Domain.Interface.Repository.AuroraDelivery.Domain.Interfaces.Repositories;

namespace AuroraDelivery.Infra.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DatabaseContext _context;

        public CustomerRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> Get()
        {
            return _context.Customer.ToList();
        }

        public Customer GetById(int id)
        {
            return _context.Customer.Find(id);
        }

        public void Add(Customer entity)
        {
            _context.Customer.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Customer entity)
        {
            _context.Customer.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var customer = _context.Customer.Find(id);
            if (customer != null)
            {
                _context.Customer.Remove(customer);
                _context.SaveChanges();
            }
        }
    }
}

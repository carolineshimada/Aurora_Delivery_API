using AuroraDelivery.Domain.Entities;
using AuroraDelivery.Domain.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AuroraDelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IBaseService<Customer> _baseCustomerService;

        public CustomerController(IBaseService<Customer> baseCustomerService)
        {
            _baseCustomerService = baseCustomerService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var customers = _baseCustomerService.Get();
                return Ok(customers);
            }
            catch (Exception ex)
            {
                // Log the exception (ex) as needed
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
            }
        }
    }
}
using customersApi.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace customersApi.Controllers
{
    [ApiController]

    [Route("api/[controller]")]
    public class customerController : Controller
    {
        [HttpGet]
        public List<customerDto> GetCustomers()
        {
            throw new NotImplementedException
        }

        //api/customer/id
        [HttpGet("{id}")]
        public async Task<customerDto> GetCustomer(long id)
        {
            throw new NotImplementedException
        }

        [HttpDelete("{id}")]
        public async Task<boll> DeleteCustomer(long id)
        {
            throw new NotImplementedException
        }

        [HttpPost]
        public async Task<customerDto> CreateCustomer(CreateCustomerDto customer)
        {
            throw new NotImplementedException
        }

        [HttpPut]
        public async Task<customerDto> UpdateCustomer(CustomerDto customer)
        {
            throw new NotImplementedException
        }




    }
}

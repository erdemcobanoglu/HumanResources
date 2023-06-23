using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Api.Tenants.Model;
using Tenant.Interfaces;

namespace Tenant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantController : ControllerBase
    {
        private readonly ICustomersProvider _customersProvider;

        public TenantController(ICustomersProvider customersProvider)
        {
            this._customersProvider = customersProvider;
        } 

        [HttpGet]
        public async Task<IActionResult> GetCustomersAsync()
        {
            var result = await _customersProvider.GetCustomersAsync();
            if (result.IsSuccess)
            {
                return Ok(result.Customers);
            }
            return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerAsync(int id)
        {
            var result = await _customersProvider.GetCustomerAsync(id);
            if (result.IsSuccess)
            {
                return Ok(result.Customer);
            }
            return NotFound();
        }
        [HttpPost("AddCustomerAsync")] // 
        public async Task<IActionResult> AddCustomerAsync(Model.Customer customer)
        {
            var result = await _customersProvider.AddCustomerAsync(customer);
            if (result.IsSuccess)
            {
                return Ok(result.Customer);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> SearchAsync(SearchTerm term)
        {  
            return NotFound();
        }
    }
}

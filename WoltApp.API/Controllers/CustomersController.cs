using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WoltApp.DAL.Data;
using WoltApp.DAL.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WoltApp.API.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        private readonly WoltDbContext _dbContext;

        public CustomersController(WoltDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
           List<Customer> customers = _dbContext.Customers.ToList();
           
            return customers;
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            Customer customer = _dbContext.Customers.Where(c => c.Id == id).FirstOrDefault();
            return customer;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Customer customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<Customer> Put(int id, [FromBody]Customer newCustomer)
        {
            Customer customer = _dbContext.Customers.Where(c => c.Id == id).FirstOrDefault();

            if(customer != null)
            {
                customer.FirstName = newCustomer.FirstName;
                customer.LastName = newCustomer.LastName;
                customer.Email = newCustomer.Email;
                customer.Location = newCustomer.Location;

                _dbContext.Customers.Update(customer);
                _dbContext.SaveChanges();
                return Ok(customer);
            }
            else
            {
                return NotFound();
            }
          

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult <Customer> Delete(int id)
        {
            Customer customer = _dbContext.Customers.Where(c => c.Id == id).FirstOrDefault();
            if(customer != null)
            {
                _dbContext.Customers.Remove(customer);
                _dbContext.SaveChanges();
                return Ok(customer);
            }
            else
            {
                return  NotFound();
            }
        }
    }
}


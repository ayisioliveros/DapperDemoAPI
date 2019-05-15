using DapperDemoAPI.DAL;
using DapperDemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DapperDemoAPI.Controllers
{
    public class CustomerController : ApiController
    {
        private CustomerRespository _ourCustomerRespository = new CustomerRespository();

        [Route("Customers")]
        [HttpGet]
        public List<Customer> Get()
        {
            return _ourCustomerRespository.GetCustomers(10, "ASC");
        }

        [Route("Customers/{id}")]
        [HttpGet]
        public Customer Get(int id)
        {
            return _ourCustomerRespository.GetSingleCustomer(id);
        }

        public bool Post([FromBody]Customer ourCustomer)
        {
            return _ourCustomerRespository.InsertCustomer(ourCustomer);
        }

        [Route("Customers")]
        [HttpPut]
        public bool Put([FromBody]Customer ourCustomer)
        {
            return _ourCustomerRespository.UpdateCustomer(ourCustomer);
        }

        [Route("Customers/{id}")]
        [HttpDelete]
        public bool Delete(int id)
        {
            return _ourCustomerRespository.DeleteCustomer(id);
        }
    }
}

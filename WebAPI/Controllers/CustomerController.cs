using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebModels;
using WebServices;

namespace WebAPI.Controllers
{
    public class CustomerController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetCustomer(int cus_ID)
        {
            GenericService<Customer> generic = new GenericService<Customer>();
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@cus_ID", cus_ID);
            var cus = generic.ExcuteSingle("pro_get_customer", parameter);
            return Ok(cus);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using BLL;
namespace Shop.Controllers
{
    public class CustomerController : ApiController
    {
        CustomersBll bll = new CustomersBll();
        [HttpPost]
        public int ControllerAdd(Customer s)
        {
            return bll.CustomerAdd(s);
        }
        [HttpGet]
        public List<Customer> ControllerGet()
        {
            return bll.Get();
        }
    }
}

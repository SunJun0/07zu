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
    public class EmployeesController : ApiController
    {
        EmployeessBLL bll = new EmployeessBLL();
        public int AddEmployees(Employees m)
        {
            return bll.Add(m);
        }
        public int DelEmployees(int id)
        {
            return bll.Del(id);
        }
        [HttpGet]
        public List<Employees> ShowEmployees()
        {
            return bll.ShowEmployees();
        }
        [HttpGet]
        public List<Market> ShowMarket()
        {
            return bll.ShowMarket();
        }
        [HttpGet]
        public List<Market> ShowProfit()
        {
            return bll.ShowProfit();
        }
    }
}

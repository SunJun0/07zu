using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using BLL;
using System.Data;

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

        //按员工ID查询密码
        [HttpGet]
        public List<Employees> Sel(int id)
        {
            return bll.Sel(id);
        }
        //按员工ID修改密码
        [HttpPut]
        public int Upd(Employees s)
        {
            return bll.Upd(s);

        }
        [HttpGet]
        public List<Market> ShowPrice()
        {
            return bll.ShowPrice();
        }
        //员工上个月的工资 
        [HttpGet]
        public List<Achievements> ShowWages()
        {
            return bll.ShowWages();
        }
    }
}

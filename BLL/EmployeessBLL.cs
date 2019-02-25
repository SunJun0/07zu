using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BLL
{
   public class EmployeessBLL
    {
        EmployeessDAL dal = new EmployeessDAL();
        public int Add(Employees m)
        {
            return dal.Add(m);
        }
        public int Del(int id)
        {
            return dal.Del(id);
        }
        public List<Employees> ShowEmployees()
        {
            return dal.ShowEmployees();
        }
        public List<Market> ShowMarket()
        {
            return dal.ShowMarket();
        }
        public List<Market> ShowProfit()
        {
            return dal.ShowProfit();
        }
        //按员工ID查询密码
        public List<Employees> Sel(int id)
        {
            return dal.Sel(id);
        }
        //按员工ID修改密码
        public int Upd(Employees s)
        {
            return dal.Upd(s);

        }
        public List<Market> ShowPrice()
        {
            return dal.ShowPrice();
        }
    }
}

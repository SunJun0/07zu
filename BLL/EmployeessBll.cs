using System;
using System.Collections.Generic;
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
    }
}

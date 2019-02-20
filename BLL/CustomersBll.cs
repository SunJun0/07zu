using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
   public class CustomersBll
    {
        CustomersDal dal = new CustomersDal();
        public int CustomerAdd(Customer s)
        {
            return dal.CustomerAdd(s);

        }
        public List<Customer> Get()
        {
            return dal.Get();
        }
    }
}

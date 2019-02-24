using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Newtonsoft.Json;
namespace DAL
{
  public  class CustomersDal
    {
        public int CustomerAdd(Customer s)
        {
            string sql = string.Format("insert into Customer values ('{0}','{1}','{2}')",s.CName,s.CPhone,s.Credits);
            return  DBHelper.ExecuteNonQuery(sql);

        }

        public List<Customer> Get()//顾客查询
        {
            string sql = "select * from Customer";
            DataTable dt = DBHelper.GetDataTable(sql);
           List<Customer> list = JsonConvert.DeserializeObject<List<Customer>>(JsonConvert.SerializeObject(dt));
            return list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
   public class EmployeessDAL
    {
        public int Add(Employees m)
        {
            string sql = string.Format("insert into Employees values('{0}','{1}','{2}','{3}','{4}','{5}')", m.EName, m.ESex, m.EHiredate, m.EPwd, m.ERole, m.EState);
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}

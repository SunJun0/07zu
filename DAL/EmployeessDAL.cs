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
    public class EmployeessDAL
    {
        public int Add(Employees m)
        {
            string sql = string.Format("insert into Employees values('{0}','{1}','{2}','{3}','{4}','{5}')", m.EName, m.ESex, m.EHiredate, m.EPwd, m.ERole, m.EState);
            return DBHelper.ExecuteNonQuery(sql);
        }
        public int Del(int id)
        {
            string sql = "delete from Employees where id ="+id;
            return DBHelper.ExecuteNonQuery(sql);
        }
        public List<Employees> ShowEmployees()
        {
            string sql = "select * from Employees";
            DataTable dt = DBHelper.GetDataTable(sql);
            var ee = JsonConvert.SerializeObject(dt);
            List<Employees> ff = JsonConvert.DeserializeObject<List<Employees>>(ee);
            return ff;
        }
        //已销售的商品
        public List<Market> ShowMarket()
        {
            string sql = "select * from Market m join Goods g on m.ShopId=g.GId";
            DataTable dt = DBHelper.GetDataTable(sql);
            var ee = JsonConvert.SerializeObject(dt);
            List<Market> ff = JsonConvert.DeserializeObject<List<Market>>(ee);
            return ff;
        }
        //利润
        public List<Market> ShowProfit()
        {
            string sql = "select  month(Market.MTime) as month,Sum((Convert(int,GPricing)-Convert(int,GPrice))* MNnum) as Profit from Goods join Market on Goods.GId = Market.ShopId  group by month(Market.MTime),month(Market.MTime) ";
            DataTable dt = DBHelper.GetDataTable(sql);
            var ee = JsonConvert.SerializeObject(dt);
            List<Market> ff = JsonConvert.DeserializeObject<List<Market>>(ee);
            return ff;
        }
        //按员工ID查询密码
        public List<Employees> Sel(int id)
        {
            string sql = "select EPwd from Employees where EId="+id;
            DataTable dt = DBHelper.GetDataTable(sql);
            List<Employees> list =  JsonConvert.DeserializeObject<List<Employees>>(JsonConvert.SerializeObject(dt));
            return list;
           
            
        }
        //按员工ID修改密码
        public int Upd(Employees s)
        {
            string sql = string.Format("update Employees set EPwd='{0}' where EId='{1}'", s.EPwd, s.EId);
           int i=  DBHelper.ExecuteNonQuery(sql);
            return i;

        }

        //总进价金额
        public List<Market> ShowPrice()
        {
            string sql = "SELECT SUM(GPrice * GQuantity) as Zong FROM Goods";
            DataTable dt = DBHelper.GetDataTable(sql);
            var ee = JsonConvert.SerializeObject(dt);
            List<Market> ff = JsonConvert.DeserializeObject<List<Market>>(ee);
            return ff;
        }
        //员工上个月的工资 
        public List<Achievements> ShowWages()
        {
            string sql = "select ROW_NUMBER() over(order by  ASale DESC ) RowNum,Employees.EName,Employees.ESex,3000+Achievements.ASale*0.1 AS payroll  from Employees join Achievements on Employees.EId =Achievements.AEId where  DATEPART(m,Achievements.AMonth)= MONTH(GETDATE())-1  and Employees.EState =0";
            DataTable dt = DBHelper.GetDataTable(sql);
            var ee = JsonConvert.SerializeObject(dt);
            List<Achievements> ff = JsonConvert.DeserializeObject<List<Achievements>>(ee);
            return ff;
        }
    }
}

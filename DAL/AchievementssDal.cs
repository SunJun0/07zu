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
   public class AchievementssDal
    {
        public List<Achievements> GetAchievements()//上月业绩排名
        {
            string sql = "select ROW_NUMBER() over(order by  ASale DESC ) RowNum,Employees.EName,Employees.ESex,Achievements.ASale  from Employees join Achievements on Employees.EId =Achievements.AEId where  DATEPART(m,Achievements.AMonth)= MONTH(GETDATE())-1  and Employees.EState =0";
            DataTable dt = DBHelper.GetDataTable(sql);
           List<Achievements> list =  JsonConvert.DeserializeObject<List<Achievements>>(JsonConvert.SerializeObject(dt));
            return list;
        }
        public List<Achievements> GetAchievements_1()//当月业绩排名
        {
            string sql = "select ROW_NUMBER() over(order by  ASale DESC ) RowNum,Employees.EName,Employees.ESex,Achievements.ASale  from Employees join Achievements on Employees.EId =Achievements.AEId where  DATEPART(m,Achievements.AMonth)= MONTH(GETDATE())";
            DataTable dt = DBHelper.GetDataTable(sql);
            List<Achievements> list = JsonConvert.DeserializeObject<List<Achievements>>(JsonConvert.SerializeObject(dt));
            return list;
        }
    }
}

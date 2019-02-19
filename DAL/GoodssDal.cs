using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class GoodssDal
    {
        DBHelper DBHelper = new DBHelper();
        public int Add(Goods m)//商品入库
        {
            string sql = string.Format("insert into Goods values('{0}','{1}',{2},{3},{4},{5},'{6}',{7})",m.GName,m.GColor,m.GSize,m.GQuantity,m.GPrice,m.GPricing,m.GPicture,m.GState);
            return DBHelper.ExecuteNonQuery(sql);
        }
        public DataTable index()//商品显示
        {
            string sql = "select * from Goods";
            return DBHelper.GetDataTable(sql);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GoodssDal
    {
        DBHelper DBHelper = new DBHelper();
        public int Add()//商品入库
        {
            string sql = "";
            return DBHelper.ExecuteNonQuery(sql);
        }
        public DataTable index()//商品显示
        {
            string sql = "";
            return DBHelper.GetDataTable(sql);
        }
    }
}

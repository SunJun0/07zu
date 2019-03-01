using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
using Newtonsoft.Json;

namespace DAL
{
    public class ShopCarDal
    {
        #region 商品查询
        public DataTable DemandShop(string ShopName, string ShopColor, int ShopSize)
        {

            string sql = string.Format("select * from Goods where GName='{0}'and GColor ='{1}' and GSize='{2}' ", ShopName, ShopColor, ShopSize);

            return DBHelper.GetDataTable(sql);
        }
        #endregion

        #region 绑定商品姓名下拉
        public DataTable ShopName()
        {
            return DBHelper.GetDataTable("select * from Goods");
        }
        #endregion

        #region 添加购物车
        public int AddShopCar(Shopping shop)
        {
            string sql = string.Format("insert into Shopping values('{0}','{1}','{2}')", shop.SNum, shop.SState, shop.GId);

            return DBHelper.ExecuteNonQuery(sql);
        }
        #endregion

        #region 显示购物车
        public DataTable ShowShopCar()
        {
            return DBHelper.GetDataTable("select * from Shopping a join Goods b on a.GId = b.GId where SState = 0");
        }
        #endregion

        #region 修改购物车状态
        public int UpdateShopCar(Shopping shop)
        {
            string sql = string.Format("update Shopping set SState = 1 where SId = '{0}'", shop.SId);
            return DBHelper.ExecuteNonQuery(sql);
        }
        #endregion

        #region 添加订单
        public int AddTallyOrder(Market m)
        {
            string sql = string.Format("insert into Market values('{0}','{1}','{2}','{3}')", m.MCard, m.MNnum, m.MTime, m.ShopId);

            return DBHelper.ExecuteNonQuery(sql);
        }
        #endregion

        #region 根据手机号查询vip用户
        public DataTable ShowPhone(string Phone)
        {

            string sql = string.Format("select * from Customer where CPhone ='{0}'", Phone);
            return DBHelper.GetDataTable(sql);
        }
        #endregion

        #region 修改员工的业绩和顾客的积分
        public int UpdateJi(model m)
        {
            string sql = "";
            if (m.GId==0)
            {
               sql  = string.Format("exec Per_proc '{0}','{1}'",m.YId,m.SumPrice);
               
            }
            else
            {
                sql = string.Format("exec Per_Jiproc '{0}','{1}','{2}'", m.YId, m.SumPrice, m.GId);
            }
            return DBHelper.ExecuteNonQuery(sql);
        }
        #endregion

        #region 修改商品库存
        public int UpdateKu(Goods goods)
        {
            string sql = string.Format("update Goods set GQuantity -='{0}' where GId='{1}'", goods.GQuantity, goods.GId);

            return DBHelper.ExecuteNonQuery(sql);
        }
        #endregion
    }
}

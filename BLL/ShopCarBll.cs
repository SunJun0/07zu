using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using Model;

namespace BLL
{
    public class ShopCarBll
    {
        ShopCarDal shopcar = new ShopCarDal();

        #region 商品查询
        public DataTable DemandShop(string ShopName, string ShopColor, int ShopSize)
        {
            return shopcar.DemandShop(ShopName, ShopColor, ShopSize);
        }
        #endregion

        #region 绑定商品姓名下拉
        public DataTable ShopName()
        {
            return shopcar.ShopName();
        }
        #endregion

        #region 添加购物车
        public int AddShopCar(Shopping shop)
        {
            return shopcar.AddShopCar(shop);
        }
        #endregion

        #region 显示购物车
        public DataTable ShowShopCar()
        {
            return shopcar.ShowShopCar();
        }
        #endregion

        #region 修改购物车状态
        public int UpdateShopCar(Shopping shop)
        {
            return shopcar.UpdateShopCar(shop);
        }
        #endregion

        #region 添加订单
        public int AddTallyOrder(Market m)
        {
            return shopcar.AddTallyOrder(m);
        }
        #endregion

        #region 根据手机号查询vip用户
        public DataTable ShowPhone(string Phone)
        {
            return shopcar.ShowPhone(Phone);
        }
        #endregion

        #region 修改员工的业绩和顾客的积分
        public int UpdateJi(model m)
        {
            return shopcar.UpdateJi(m);
        }
        #endregion

        #region 修改商品库存
        public int UpdateKu(Goods goods)
        {
            return shopcar.UpdateKu(goods);
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using BLL;
using Model;

namespace Shop.Controllers
{
    public class ShopCarController : ApiController
    {
        ShopCarBll shopcar = new ShopCarBll();
        #region 商品查询
        [HttpGet]
        public DataTable DemandShop(string ShopName, string ShopColor, int ShopSize)
        {
            return shopcar.DemandShop(ShopName, ShopColor, ShopSize);
        }
        #endregion

        #region 绑定姓名下拉
        [HttpGet]
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
        [HttpGet]
        public DataTable ShowShopCar()
        {
            return shopcar.ShowShopCar();
        }
        #endregion

        #region 修改购物车状态
        [HttpPut]
        public int UpdateShopCar(Shopping shop)
        {
            return shopcar.UpdateShopCar(shop);
        }
        #endregion

        #region 添加订单
        [HttpPost]
        public int AddTallyOrder(Market m)
        {
            return shopcar.AddTallyOrder(m);
        }
        #endregion

        #region 根据手机号查询vip用户
        [HttpGet]
        public DataTable ShowPhone(string Phone)
        {
            return shopcar.ShowPhone(Phone);
        }
        #endregion

        #region 修改员工的业绩和顾客的积分
        [HttpPut]
        public int UpdateJi(model m)
        {
            return shopcar.UpdateJi(m);
        }
        #endregion

        #region 修改商品库存
        [HttpPut]
        public int UpdateKu(Goods goods)
        {
            return shopcar.UpdateKu(goods);
        }
        #endregion
    }
}

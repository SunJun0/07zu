using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class GoodssBll
    {
        GoodssDal goodssDal=new GoodssDal();
        public int Add(Goods m)//商品入库
        {
            return goodssDal.Add(m);
        }
        public DataTable index()//商品显示
        {
            return goodssDal.index();
        }
    }
}

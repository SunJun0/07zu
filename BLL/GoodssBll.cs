using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class GoodssBll
    {
        GoodssDal goodssDal=new GoodssDal();
        public int Add(Goods m)//商品入库
        {
            return goodssDal.Add(m);
        }
        public DataTable Index()//商品显示
        {
            return goodssDal.Index();
        }
        public int Updata(int id)//商品显示
        {
            return goodssDal.Updata(id);
        }
    }
}

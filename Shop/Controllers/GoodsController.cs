using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using Model;
using BLL;
using Newtonsoft.Json;

namespace Shop.Controllers
{
    public class GoodsController : ApiController
    {
        GoodssBll goodssBll = new GoodssBll();
        public int Add(Goods m)//商品入库
        {
            return goodssBll.Add(m);
        }
        public List<Goods> index()//商品显示
        {
            DataTable dt= goodssBll.index();
            var ee = JsonConvert.SerializeObject(dt);
            return JsonConvert.DeserializeObject<List<Goods>>(ee);
        }
    }
}

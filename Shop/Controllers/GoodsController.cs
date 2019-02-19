using BLL;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Shop.Controllers
{
    public class GoodsController : ApiController
    {
        GoodssBll goodssBll = new GoodssBll();
        public int Add(Goods m)//商品入库
        {
            return goodssBll.Add(m);
        }
        [HttpGet]
        public List<Goods> Index()//商品显示
        {
            DataTable dt = goodssBll.Index();
            var ee = JsonConvert.SerializeObject(dt);
            return JsonConvert.DeserializeObject<List<Goods>>(ee);
        }
    }
}

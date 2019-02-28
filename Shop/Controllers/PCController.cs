using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace Shop.Controllers
{
    public class PCController : ApiController
    {
        public string Get()
        {
            List<dynamic> dataItem = new List<dynamic>//pc端数据
            {
                new{name="大品",children= new List<dynamic>
                {
                    new {name= "小米5s",src="http://qiniu.verydog.cn//show.liluo.cc/img_0505.png",link="/detail/1019"},
                    new {name= "小米5s",src="http://qiniu.verydog.cn//show.liluo.cc/img_0505.png",link="/detail/1019"},
                    new {name= "小米5s",src="http://qiniu.verydog.cn//show.liluo.cc/img_0505.png",link="/detail/1019"},
                    new {name= "小米5s",src="http://qiniu.verydog.cn//show.liluo.cc/img_0505.png",link="/detail/1019"},
                    new {name= "小米5s",src="http://qiniu.verydog.cn//show.liluo.cc/img_0505.png",link="/detail/1019"},
                    new {name= "小米5s",src="http://qiniu.verydog.cn//show.liluo.cc/img_0505.png",link="/detail/1019"}
                }},
                
            };
            var result = new { dataItem= dataItem };
            return JsonConvert.SerializeObject(result);
        }
    }
}

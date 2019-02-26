using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Shop.Controllers
{
    public class AccountController : ApiController
    {

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name">员工姓名</param>
        /// <param name="pwd">密码</param>
        /// <returns>员工信息</returns>
        [HttpGet]
        public Employees Login(string name, string pwd)
        {
            return AccountBll.Login(name, pwd);
        }
    }
}

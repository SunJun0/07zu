using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AccountBll
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name">员工姓名</param>
        /// <param name="pwd">密码</param>
        /// <returns>员工信息</returns>
        public static Employees Login(string name, string pwd)
        {
            return AccountDal.Login(name, pwd);
        }
    }
}

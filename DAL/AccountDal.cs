using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountDal
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name">员工姓名</param>
        /// <param name="pwd">密码</param>
        /// <returns>员工信息</returns>
        public static Employees Login(string name, string pwd)
        {
            Employees e = null;
            SqlParameter spName = new SqlParameter("@name", SqlDbType.VarChar);
            spName.Value = name;
            SqlParameter spPwd = new SqlParameter("@pwd", SqlDbType.VarChar);
            spPwd.Value = pwd;
            SqlParameter[] paras = { spName, spPwd };
            using (SqlDataReader dr = SqlHelper.ExecuteReader("p_login", paras))
            {
                if (dr.Read())
                {
                    e = new Employees()
                    {
                        EId = Convert.ToInt32(dr["EId"]),
                        EName = dr["EName"].ToString(),
                        ESex = dr["ESex"].ToString(),
                        EHiredate = Convert.ToDateTime(dr["EHiredate"]),
                        EPwd = dr["EPwd"].ToString(),
                        ERole = Convert.ToInt32(dr["ERole"]),
                        EState = Convert.ToInt32(dr["EState"])
                    };
                }
                return e;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


    public class DBHelper
    {
        public static string connStr = "Data Source=.;Initial Catalog=DBEmp;Integrated Security=True";
        public static SqlConnection cnn = new SqlConnection(connStr);

        /// <summary>
        /// 执行增删改的操作
        /// </summary>
        /// <param name="sql">sql命令</param>
        /// <returns>受影响的行数</returns>
        public static int ExecuteNonQuery(string sql)
        {
            cnn.Open();
            SqlCommand command = new SqlCommand(sql, cnn);
            int result = command.ExecuteNonQuery();
            cnn.Close();
            return result;
        }
        /// <summary>
        /// 查询单个值
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql)
        {
            cnn.Open();
            SqlCommand command = new SqlCommand(sql, cnn);
            object result = command.ExecuteScalar();
            cnn.Close();
            return result;
        }
        /// <summary>
        /// 返回数据集
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
        /// <summary>
        /// 返回DataReader对象，使用结束后，勿忘关闭DataReader与数据库
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetDataReader(string sql)
        {
            cnn.Open();
            SqlCommand command = new SqlCommand(sql, cnn);
            return command.ExecuteReader();
        }
        /// <summary>
        /// 返回一个临时表数据，一般执行显示表中多条数据操作  select
        /// </summary>
        /// <param name="sql">要执行的查询sql语句</param>
        /// <returns>返回一个DataTable</returns>
        public static DataTable GetTable(string sql)
        {
            try
            {
                cnn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception se)
            {
                throw se;
            }
            finally
            {
                cnn.Close();
            }
        }
    }

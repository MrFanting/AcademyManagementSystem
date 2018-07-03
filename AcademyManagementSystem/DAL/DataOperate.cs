
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementSystem.DAL
{
    class DataOperate
    {
        private SqlConnection m_Conn = null; //声明数据库连接引用
        private SqlCommand m_Cmd = null; //声明数据命令引用

        public DataOperate()
        {
            //string strServer = ReadFile.GetIniFileString("DataBase", "Server", "", Application.StartupPath + "\\Express.ini"); //获取登录用户
            //string strUserID = ReadFile.GetIniFileString("DataBase", "UserID", "", Application.StartupPath + "\\Express.ini");//获取登录密码
            //string strPwd = ReadFile.GetIniFileString("DataBase", "Pwd", "", Application.StartupPath + "\\ Express.ini");//数据库连接字符串
            //string strConn = "Server = " + strServer + ";Database= db_Express;User id=" + strUserID + ";PWD=" + strPwd;
            string strConn = "Server = localhost" + ";Database= QKB;User id=denghong" + ";PWD=lk126096";
            try
            {
                m_Conn = new SqlConnection(strConn); //创建数据库连接对象
                m_Cmd = new SqlCommand(); //创建数据库命令对象
                m_Cmd.Connection = m_Conn; //设置数据库命令对象的连接属性
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public SqlConnection Conn
        {
            get { return m_Conn; } //获取数据库连接对象
        }
        public SqlCommand Cmd
        {
            get { return m_Cmd; } //获取数据库命令对象
        }

        public bool ExecDataBySqls(List<string> strSqls)
        {
            bool booIsSucceed; //定义返回值变量
            if (m_Conn.State == ConnectionState.Closed) //判断当前的数据库连接状态
            {
                m_Conn.Open(); //打开连接
            }
            
            try
            {
                foreach (string item in strSqls) //循环读取字符串列表集合
                {
                    m_Cmd.CommandType = CommandType.Text; //设置命令类型为 SQL 文本命令
                    m_Cmd.CommandText = item; //设置要对数据源执行的 SQL 语句
                    m_Cmd.ExecuteNonQuery(); //执行 SQL 语句并返回受影响的行数
                }
                
                booIsSucceed = true; //表示提交数据库成功
            }
            catch
            {
                booIsSucceed = false; //表示提交数据库失败
            }
            finally
            {
                m_Conn.Close(); //关闭连接
                strSqls.Clear(); //清除列表 strSqls 中的元素
            }
            return booIsSucceed; //方法返回值
        }
        public bool ExecDataBySql(string strSql)
        {
            bool booIsSucceed; //定义返回值变量
            if (m_Conn.State == ConnectionState.Closed) //判断当前的数据库连接状态
            {
                m_Conn.Open(); //打开连接
            }
            m_Cmd.CommandType = CommandType.Text; //设置命令类型为 SQL 文本命令
            m_Cmd.CommandText = strSql; //设置要对数据源执行的 SQL 语句

            try
            {
                m_Cmd.ExecuteNonQuery(); //执行 SQL 语句并返回受影响的行数
                booIsSucceed = true; //表示提交数据库成功
            }
            catch
            {
                booIsSucceed = false; //表示提交数据库失败
            }
            finally
            {
                m_Conn.Close(); //关闭连接
            }
            return booIsSucceed; //方法返回值
        }
        internal string GetSingleObject(string strSql)
        {
            string str = "";
            SqlDataReader sdr; //声明 SqlDataReader 引用
            m_Cmd.CommandType = CommandType.Text; //设置命令类型为文本
            m_Cmd.CommandText = strSql; //传入 SQL 语句
            try
            {
                if (m_Conn.State == ConnectionState.Closed) //若数据库连接关闭
                {
                    m_Conn.Open(); //打开数据连接
                }
                sdr = m_Cmd.ExecuteReader();//执行 SQL 语句
                if (sdr.HasRows && sdr.Read())
                {
                    str = (string)sdr[0];
                }
            }
            catch (Exception e)
            {
                throw e; //抛出异常
            }
            return str; //返回 SqlDataReader 对象
        }

        public SqlDataReader GetDataReader(string strSql)
        {
            SqlDataReader sdr; //声明 SqlDataReader 引用
            m_Cmd.CommandType = CommandType.Text; //设置命令类型为文本
            m_Cmd.CommandText = strSql; //传入 SQL 语句

            try
            {
                if (m_Conn.State == ConnectionState.Closed) //若数据库连接关闭
                {
                    m_Conn.Open(); //打开数据连接
                }
                sdr = m_Cmd.ExecuteReader(CommandBehavior.CloseConnection);//执行 SQL 语句
            }
            catch (Exception e)
            {
                throw e; //抛出异常
            }
            return sdr; //返回 SqlDataReader 对象
        }

        public DataTable GetDataTable(string strSql, SqlParameter[] parameters)
        {
            DataTable dt = null; //声明 DataTable 引用
            SqlDataAdapter sda = new SqlDataAdapter(); //声明 SqlDataAdapter 引用
            m_Cmd.CommandType = CommandType.StoredProcedure; //设置命令类型为文本
            m_Cmd.CommandText = strSql;
            m_Cmd.Parameters.AddRange(parameters);
            try
            {
                sda = new SqlDataAdapter(m_Cmd); //创建适配器对象

                dt = new DataTable(); //创建 DataTable 对象
                sda.Fill(dt); //把数据填充到 DataTable 对象中
            }
            catch (Exception ex)
            {
                throw ex; //抛出异常
            }

            return dt; //返回 DataTable 对象
        }


        public DataTable GetDataTable(string strSql, string strTableName)
        {

            DataTable dt = null; //声明 DataTable 引用
            SqlDataAdapter sda = null; //声明 SqlDataAdapter 引用
            try
            {
                sda = new SqlDataAdapter(strSql, m_Conn); //创建适配器对象

                dt = new DataTable(strTableName); //创建 DataTable 对象
                sda.Fill(dt); //把数据填充到 DataTable 对象中
            }
            catch (Exception ex)
            {
                throw ex; //抛出异常
            }

            return dt; //返回 DataTable 对象
        }

        
    }
}

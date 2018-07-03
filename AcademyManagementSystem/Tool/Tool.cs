using AcademyManagementSystem.DAL;
using AcademyManagementSystem.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementSystem.Tool
{
    class Tool
    {
        private DataOperate dataOperate = new DataOperate();
        public Tool()
        {

        }
        public Student queryStudentById(string id)
        {
            //成功返回student对象，失败返回null
            SqlDataReader sqlDataReader = null;
            Student student = null;
            string strSql = "SELECT * from student WHERE 学号='" + id+"'";
            sqlDataReader = dataOperate.GetDataReader(strSql);
            try
            {
                
                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    student = new Student();
                    student.Id = sqlDataReader["学号"].ToString();
                    student.Name = sqlDataReader["姓名"].ToString();
                    student.Major = sqlDataReader["专业名"].ToString();
                    student.Name = sqlDataReader["出生年月"].ToString();
                    student.Name = sqlDataReader["手机号"].ToString();
                }
            }
            catch
            {

            }
            finally
            {
                try {
                    sqlDataReader.Close();
                }
                catch { }
            }
            
            return student;
        }

        public bool verifyStudent(Student student)
        {
            //学生登录验证
            SqlDataReader sqlDataReader = null;
            string strSql = "SELECT * from student WHERE 学号='" + student.Id + "'";
            sqlDataReader = dataOperate.GetDataReader(strSql);
            if (!sqlDataReader.HasRows)
            {
                return false;
            }
            else
            {
                sqlDataReader.Read();
                if (student. != sqlDataReader["Password"].ToString())
                {
                    MessageBox.Show("登录密码不正确！", "软件提示");
                    txtPwd.Focus();
                }
                else
                {
                    GlobalProperty.OperatorCode = sqlDataReader["OperatorCode"].ToString();
                    GlobalProperty.OperatorName = sqlDataReader["OperatorName"].ToString();
                    GlobalProperty.Password = sqlDataReader["Password"].ToString();
                    GlobalProperty.IsFlag = sqlDataReader["IsFlag"].ToString();
                    Hide();
                    AppForm appForm = new AppForm();
                    // FormBillType formBillType = new FormBillType();
                    //formBillType.Show();
                    appForm.Show();
                }
            }
        }
        
    }
}

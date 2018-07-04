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
    class DataHandler
    {
        private DataOperate dataOperate = new DataOperate();

        public bool verifyStudent(UserAccount user) //用户登录验证（学生或老师）
        {
            
            SqlDataReader sqlDataReader = null;
            string strSql = "";
            if (user.Type == "teacher")
            {
                strSql = "SELECT * from teacher_code WHERE 教师编号='" + user.Account + "'";
            }
            else
            {
                strSql = "SELECT * from student WHERE 学号='" + user.Account + "'";
            }
            try
            {
                sqlDataReader = dataOperate.GetDataReader(strSql);
                if (!sqlDataReader.HasRows)
                {
                    return false;
                }
                else
                {
                    sqlDataReader.Read();
                    if (user.Password != sqlDataReader["登录密码"].ToString())
                    {
                        return false;
                    }
                }
            }
            catch { }
            finally
            {
                try
                {
                    sqlDataReader.Close();
                }
                catch { }
            }

            return true;
        }

        public Student queryStudentById(string id)//按id查找学生信息,成功返回student对象，失败返回null.
        {
            
            SqlDataReader sqlDataReader = null;
            Student student = null;
            string strSql = "SELECT 学号,姓名,性别,出生年月,手机号,培养方案名称 FROM student,pro WHERE " +
                "学号='"+id+"' AND student.专业号=pro.培养方案编号 ";
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
                    student.Birth = sqlDataReader["出生年月"].ToString();
                    student.Number = sqlDataReader["手机号"].ToString();
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

        public Teacher queryTeacherById(string id)//按id查找教师信息,成功返回teacher对象，失败返回null.
        {

            SqlDataReader sqlDataReader = null;
            Teacher teacher = null;
            string strSql = "SELECT * FROM teacher WHERE " +
                "教师编号='" + id + "'";
            sqlDataReader = dataOperate.GetDataReader(strSql);
            try
            {

                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    teacher = new Teacher();
                    teacher.Id = sqlDataReader["教师编号"].ToString();
                    teacher.Name = sqlDataReader["姓名"].ToString();
                    teacher.Gender = sqlDataReader["性别"].ToString();
                    teacher.Age = sqlDataReader["年龄"].ToString();
                }
            }
            catch
            {

            }
            finally
            {
                try
                {
                    sqlDataReader.Close();
                }
                catch { }
            }

            return teacher;
        }

        public Course queryCourseById(string id)//按id查找课程信息,成功返回course对象，失败返回null.
        {

            SqlDataReader sqlDataReader = null;
            Course course = null;
            string strSql = "SELECT 课程号,课程名,学分,性质,姓名 FROM teacher,course WHERE " +
                "课程号='"+id+"' AND teacher.教师编号=course.教师编号";
            sqlDataReader = dataOperate.GetDataReader(strSql);
            try
            {
                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    course = new Course();
                    course.Id = sqlDataReader["课程号"].ToString();
                    course.Con = sqlDataReader["课程名"].ToString();
                    course.Property = sqlDataReader["性质"].ToString();
                    course.Credit = sqlDataReader["学分"].ToString();
                    course.TeacherName = sqlDataReader["姓名"].ToString();
                    
                }
            }   
            catch
            {

            }
            finally
            {
                try
                {
                    sqlDataReader.Close();
                }
                catch { }
            }

            return course;
        }

        public List<Course> queryTrainingProgram(string id)//培养方案查询,成功返回课程集合，失败返回null
        {
            List<Course> courses = null;
            SqlDataReader sqlDataReader = null;
            Course course = null;
            string strSql = "SELECT course.课程号,课程名,学分,性质,teacher.姓名 FROM teacher,course,student,train WHERE " +
                "学号='" + id + "' AND student.专业号=train.培养方案编号 AND train.课程号=course.课程号 " +
                "AND teacher.教师编号=course.教师编号";
            sqlDataReader = dataOperate.GetDataReader(strSql);
            try
            {
                while (sqlDataReader.Read())
                {
                    course = new Course();
                    course.Id = sqlDataReader["课程号"].ToString();
                    course.Con = sqlDataReader["课程名"].ToString();
                    course.Property = sqlDataReader["性质"].ToString();
                    course.Credit = sqlDataReader["学分"].ToString();
                    course.TeacherName = sqlDataReader["姓名"].ToString();
                    courses.Add(course);
                }
            }
            catch
            {

            }
            finally
            {

                try
                {
                    sqlDataReader.Close();
                }
                catch { }
            }


            return courses;
        }

        public List<Score> queryScore(string id,int type)//成绩查询,成功返回成绩集合，失败返回null，0代表学生，1表示老师
        {
            List<Score> scores = null;
            SqlDataReader sqlDataReader = null;
            Score score = null;
            string strSql = "";
            if (type == 0)
            {
                strSql = "SELECT 姓名,课程名,成绩,score.课程号,score.学号 FROM score,course,student WHERE " +
                    "score.学号='" + id + "' AND score.课程号=course.课程号 AND score.学号=student.学号";
            }
            else
            {
                strSql = "SELECT 姓名,课程名,成绩,score.课程号,score.学号 FROM score,course,student WHERE " +
                    "教师编号='"+id+"' AND score.课程号=course.课程号 AND student.学号=score.学号";
            }
            
            sqlDataReader = dataOperate.GetDataReader(strSql);
            try
            {
                while (sqlDataReader.Read())
                {
                    score = new Score();
                    score.StudentId = sqlDataReader["学号"].ToString();
                    score.CourseId = sqlDataReader["课程号"].ToString();
                    score.StudentName = sqlDataReader["姓名"].ToString();
                    score.Con = sqlDataReader["课程名"].ToString();
                    score.Mark = sqlDataReader["成绩"].ToString();
                    scores.Add(score);
                }
            }
            catch
            {

            }
            finally
            {

                try
                {
                    sqlDataReader.Close();
                }
                catch { }
            }


            return scores;
        }

        public Room queryRoom(Room r)//输入教室,查询是否空闲,成功返回room对象,空闲与否存在idle字段,失败返回null
        {

            SqlDataReader sqlDataReader = null;
            Room room = null;
            string strSql = "SELECT 时间,是否空闲 FROM room WHERE 教室编号='" + r.Id+"'";
            sqlDataReader = dataOperate.GetDataReader(strSql);
            try
            {
                if (sqlDataReader.HasRows)
                {
                    room = new Room();
                    while (sqlDataReader.Read())
                    {
                        string time = sqlDataReader["时间"].ToString();
                        if (time=="上午")
                        {
                            room.IsIdleMorning = sqlDataReader["是否空闲"].ToString();
                        }
                        else if (time == "中午")
                        {
                            room.IsIdleNoon = sqlDataReader["是否空闲"].ToString();
                        }
                        else
                        {
                            room.IsIdleAfternoon = sqlDataReader["是否空闲"].ToString();
                        }
                    }
                }
                
            }
            catch
            {

            }
            finally
            {
                try
                {
                    sqlDataReader.Close();
                }
                catch { }
            }

            return room;
        }

        public bool updateUserCode(UserAccount user)//输入用户,修改密码
        {

            string strSql = "";
            if (user.Type == "teacher")
            {
                strSql = "UPDATE teacher_code SET 登录密码 = '"+user.Password+"' WHERE 教师编号='"+user.Account+"'";
            }
            else
            {
                strSql = "UPDATE student_code SET 登录密码 = '"+user.Password+"' WHERE 学号='"+user.Account+"'";
            }
            if (dataOperate.ExecDataBySql(strSql))
            {
                return true;
            }
            return false;
        }

        public bool updateScore(Score score)//修改成绩
        {

            string strSql = "";
            strSql = "UPDATE score SET 成绩 = '"+score.Mark+"' WHERE 学号='"+score.StudentId+"' " +
                "AND 课程号='"+score.CourseId+"'";
            if (dataOperate.ExecDataBySql(strSql))
            {
                return true;
            }
            return false;
        }

    }
}

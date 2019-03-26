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

        public bool VerifyUser(UserAccount user) //用户登录验证（学生或老师）
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
                    string s = sqlDataReader["登录密码"].ToString().Trim();
                    if (user.Password != sqlDataReader["登录密码"].ToString().Trim())
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

        public Student QueryStudentById(string id)//按id查找学生信息,成功返回student对象，失败返回null.
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
                    student.Major = sqlDataReader["培养方案名称"].ToString();
                    student.Birth = sqlDataReader["出生年月"].ToString();
                    student.Number = sqlDataReader["手机号"].ToString();
                    student.Gender = sqlDataReader["性别"].ToString();
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

        public Teacher QueryTeacherById(string id)//按id查找教师信息,成功返回teacher对象，失败返回null.
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

        public Course QueryCourseById(string id)//按id查找课程信息,成功返回course对象，失败返回null.
        {

            SqlDataReader sqlDataReader = null;
            Course course = null;
            string strSql = "SELECT 课程号,课程名,学分,course.上课时间,地点,教师姓名 FROM teacher,course,room_info "+
                "WHERE 课程号="+id+" AND teacher.教师编号=course.教师编号 AND room_info.教室编号=course.教室编号";
            sqlDataReader = dataOperate.GetDataReader(strSql);
            try
            {
                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    course = new Course();
                    course.Id = sqlDataReader["课程号"].ToString();
                    course.Con = sqlDataReader["课程名"].ToString();
                    course.CourseTime = sqlDataReader["上课时间"].ToString();
                    course.Credit = sqlDataReader["学分"].ToString();
                    course.TeacherName = sqlDataReader["教师姓名"].ToString();
                    course.Place= sqlDataReader["地点"].ToString();

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

        public List<Course> QueryTrainingProgram(string id)//培养方案查询,成功返回课程集合，失败返回null
        {
            List<Course> courses = new List<Course>();
            SqlDataReader sqlDataReader = null;
            Course course = null;
            string strSql = "SELECT 课程号,课程名,学分,course.上课时间,地点,教师姓名 FROM teacher,course,room_info,pro " +
                "WHERE 培养方案编号=" + id + " AND teacher.教师编号=course.教师编号 AND room_info.教室编号=course.教室编号";
            sqlDataReader = dataOperate.GetDataReader(strSql);
            try
            {
                while (sqlDataReader.Read())
                {
                    course = new Course();
                    course.Id = sqlDataReader["课程号"].ToString();
                    course.Con = sqlDataReader["课程名"].ToString();
                    course.CourseTime = sqlDataReader["上课时间"].ToString();
                    course.Credit = sqlDataReader["学分"].ToString();
                    course.TeacherName = sqlDataReader["教师姓名"].ToString();
                    course.Place = sqlDataReader["地点"].ToString();
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
            if (courses.Count == 0)
                return null;

            return courses;
        }

        public List<Course> QueryCoursesByStudentId(string id)//培养方案查询,成功返回课程集合，失败返回null
        {
            List<Course> courses = new List<Course>();
            SqlDataReader sqlDataReader = null;
            Course course = null;
            string strSql = "SELECT course.课程号,课程名,学分,course.上课时间,地点,教师姓名 FROM " +
                "teacher,course,room_info,student,score WHERE student.学号=" + id +
                " AND teacher.教师编号=course.教师编号 AND room_info.教室编号=course.教室编号" +
                " AND student.专业号=course.培养方案编号 AND score.课程号<>course.课程号";
            sqlDataReader = dataOperate.GetDataReader(strSql);
            try
            {
                while (sqlDataReader.Read())
                {
                    course = new Course();
                    course.Id = sqlDataReader["课程号"].ToString();
                    course.Con = sqlDataReader["课程名"].ToString();
                    course.CourseTime = sqlDataReader["上课时间"].ToString();
                    course.Credit = sqlDataReader["学分"].ToString();
                    course.TeacherName = sqlDataReader["教师姓名"].ToString();
                    course.Place = sqlDataReader["地点"].ToString();
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
            if (courses.Count == 0)
                return null;

            return courses;
        }

        public List<Course> QueryCourseByTeacherId(string teacherId)//培养方案查询,成功返回课程集合，失败返回null
        {
            List<Course> courses = new List<Course>();
            SqlDataReader sqlDataReader = null;
            Course course = null;
            string strSql = "SELECT 课程号,课程名,学分,course.上课时间,地点,教师姓名 FROM teacher,course,room_info " +
                "WHERE course.教师编号=" + teacherId + " AND teacher.教师编号=course.教师编号 AND room_info.教室编号=course.教室编号";
            sqlDataReader = dataOperate.GetDataReader(strSql);
            try
            {
                while (sqlDataReader.Read())
                {
                    course = new Course();
                    course.Id = sqlDataReader["课程号"].ToString();
                    course.Con = sqlDataReader["课程名"].ToString();
                    course.CourseTime = sqlDataReader["上课时间"].ToString();
                    course.Credit = sqlDataReader["学分"].ToString();
                    course.TeacherName = sqlDataReader["教师姓名"].ToString();
                    course.Place = sqlDataReader["地点"].ToString();
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
            if (courses.Count == 0)
                return null;

            return courses;
        }

        public List<Score> StudentQueryScore(string id)//成绩查询,成功返回成绩集合
        {
            List<Score> scores = new List<Score>();
            SqlDataReader sqlDataReader = null;
            Score score = null;
            string strSql = "SELECT 姓名,课程名,成绩,score.课程号,score.学号 FROM score,course,student WHERE"+
                " score.学号="+id+" AND score.课程号=course.课程号 AND score.学号=student.学号 AND 成绩 is not null"; 
    
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

            if (scores.Count == 0)
                return null;
            return scores;
        }

        public List<Score> TeacherQueryScore(Course course)//成绩查询,成功返回成绩集合
        {
            List<Score> scores = new List<Score>();
            SqlDataReader sqlDataReader = null;
            Score score = null;
            string strSql = "SELECT 姓名,课程名,成绩,score.课程号,score.学号 FROM score,course,student"+
                " WHERE score.课程号="+course.Id+" AND score.课程号=course.课程号 AND student.学号=score.学号";
            
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
                    if (sqlDataReader["成绩"] != null)
                    {
                        score.Mark = sqlDataReader["成绩"].ToString();
                    }
                    else
                    {
                        score.Mark = "";
                    }
                    
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
            if (scores.Count == 0)
                return null;

            return scores;
        }

        public Room QueryRoom(Room r)//输入教室,查询是否空闲,成功返回room对象,空闲与否存在idle字段,失败返回null
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
                        string time = sqlDataReader["时间"].ToString().Trim();
                        if (time=="上午")
                        {
                            room.IsIdleMorning = sqlDataReader["是否空闲"].ToString().Trim();
                        }
                        else if (time == "中午")
                        {
                            room.IsIdleNoon = sqlDataReader["是否空闲"].ToString().Trim();
                        }
                        else
                        {
                            room.IsIdleAfternoon = sqlDataReader["是否空闲"].ToString().Trim();
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

        public bool UpdateUserCode(UserAccount user)//输入用户,修改密码
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

        public bool UpdateScore(List<Score> scores)//修改成绩
        {

            string strSql = "";
            List<string> strSqls = new List<string>();
            foreach(Score score in scores)
            {
                strSql = "UPDATE score SET 成绩 = '" + score.Mark + "' WHERE 学号='" + score.StudentId.Trim() + "' " +
                "AND 课程号='" + score.CourseId.Trim() + "'";
                strSqls.Add(strSql);
            }
            
            if (dataOperate.ExecDataBySqls(strSqls))
            {
                return true;
            }
            return false;
        }

    }
}

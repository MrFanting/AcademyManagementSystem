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
            string strSql = "SELECT 课程号,课程名,培养方案编号,course.教室编号,学分,course.上课时间,地点,教师姓名 FROM teacher,course,room_info " +
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
                    course.RoomId = sqlDataReader["教室编号"].ToString();
                    course.ProgramId = sqlDataReader["培养方案编号"].ToString();
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
            string strSql = "SELECT 课程号,课程名,学分,course.教室编号,course.上课时间,地点,教师姓名 FROM teacher,course,room_info,pro " +
                "WHERE pro.培养方案编号=" + id + " AND teacher.教师编号=course.教师编号 AND room_info.教室编号=course.教室编号";
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
                    course.ProgramId = id;
                    course.RoomId = sqlDataReader["教室编号"].ToString();
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
            string strSql = "SELECT course.课程号,课程名,course.教室编号,学分,course.培养方案编号,course.上课时间,地点,教师姓名 FROM " +
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
                    course.ProgramId = sqlDataReader["培养方案编号"].ToString();
                    course.RoomId = sqlDataReader["教室编号"].ToString();
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
            string strSql = "SELECT 课程号,课程名,学分,room_info.教室编号,course.上课时间,地点,教师姓名,培养方案编号 FROM teacher,course,room_info " +
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
                    course.ProgramId = sqlDataReader["培养方案编号"].ToString();
                    course.RoomId = sqlDataReader["教室编号"].ToString();
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

        public List<Room> QueryRoomsIdle()//空闲教室查询，返回所有教室空闲时间
        {
            List<Room> rooms = new List<Room>();
            SqlDataReader sqlDataReader = null;
            Room room = null;
            string strSql = "SELECT room.教室编号,空闲时间 FROM room WHERE 标识 NOT IN"+
                " (SELECT 标识 FROM course INNER JOIN room ON room.教室编号=course.教室编号 AND room.空闲时间=course.上课时间)";

            sqlDataReader = dataOperate.GetDataReader(strSql);
            try
            {
                while (sqlDataReader.Read())
                {
                    room = new Room();
                    room.Id = sqlDataReader["教室编号"].ToString();
                    room.IdleTime = sqlDataReader["空闲时间"].ToString();
                    rooms.Add(room);
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

            if (rooms.Count == 0)
                return null;
            return rooms;
        }

        public RoomInfo QueryRoomInfo(Room r)//输入教室,查询是否空闲,成功返回room对象,空闲与否存在idle字段,失败返回null
        {

            SqlDataReader sqlDataReader = null;
            RoomInfo room = null;
            string strSql = "SELECT 教室编号,容纳人数,地点 FROM room_info WHERE 教室编号='" + r.Id+"'";
            sqlDataReader = dataOperate.GetDataReader(strSql);
            try
            {
                if (sqlDataReader.HasRows)
                {
                    room = new RoomInfo();
                    while (sqlDataReader.Read())
                    {
                        room.Id= sqlDataReader["教室编号"].ToString().Trim();
                        room.Contain= sqlDataReader["容纳人数"].ToString().Trim();
                        room.Place = sqlDataReader["地点"].ToString().Trim();
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
        public bool StudentChooseCourse(Score score)//输入用户,修改密码
        {

            string strSql = "INSERT INTO score(课程号,学号) VALUES(" + score.CourseId + "," + score.StudentId + ")";
            if (dataOperate.ExecDataBySql(strSql))
            {
                return true;
            }
            return false;
        }
        public bool TeacherInsertCourse(Course course,string id)//输入用户,修改密码
        {

            string strSql = "INSERT INTO course VALUES(" + course.Id + "," + course.Con +
                "," + course.Credit + "," + course.ProgramId + "," + id + "," + course.CourseTime +
                "," + course.RoomId + ")";
            if (dataOperate.ExecDataBySql(strSql))
            {
                return true;
            }
            return false;
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
        public bool StudentDeleteCourse(Score score)//删除选课
        {
            string strSql = "DELETE FROM score WHERE 学号='" + score.StudentId.Trim() + "' " +
                "AND 课程号='" + score.CourseId.Trim() + "'";
            return dataOperate.ExecDataBySql(strSql);
        }
        public bool StudentAddCourse(Score score)//选课
        {
            string strSql = "INSERT INTO score(课程号,学号) VALUES(" + score.CourseId.Trim() + "," +score.StudentId.Trim() + ")";
            return dataOperate.ExecDataBySql(strSql);
        }
        public bool TeacherAddCourse(Course course,string account)//教师添加课程
        {
            string strSql = "INSERT INTO course VALUES('"+course.Id.Trim()+"','"+course.Con.Trim()+"','"+
                course.Credit.Trim()+"','"+course.ProgramId.Trim()+"','"+account+"','"+
                course.CourseTime.Trim()+"','"+course.RoomId.Trim()+"')";
            return dataOperate.ExecDataBySql(strSql);
        }
        public bool TeacherUpdateCourse(Course course)//教师更新课程信息
        {
            string strSql = "UPDATE course SET 上课时间='"+course.CourseTime.Trim()+"',教室编号='"+
                course.RoomId.Trim()+"' WHERE 课程号='"+course.Id.Trim()+"'";
            return dataOperate.ExecDataBySql(strSql);
        }
        public bool TeacherDeleteCourse(Course course)//教师删除课程
        {
            List<string> strSqls = new List<string>();
            strSqls.Add("DELETE FROM score WHERE 课程号="+course.Id.Trim());
            strSqls.Add("DELETE FROM course WHERE 课程号 ="+course.Id.Trim());
            return dataOperate.ExecDataBySqls(strSqls);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWinForm
{
    class ConnectionInfo
    {
        public static readonly string login = "login",//登录
            updatePassword = "updatePassword",//修改密码
            studentGetPersonalInfo = "studentGetPersonalInfo",//获取学生个人信息，服务端保存学生id，可以不设参数，返回学生对象
            studentGetGrades = "studentGetGrades",//获取学生成绩，score对象列表
            studentGetCourseInfo = "studentGetCourseInfo",
            studentInsertCourse = "studentInsertCourse",
            studentDeleteCourse = "studentDeleteCourse",
            studentGetCourseToChoose = "studentGetCourseToChoose",
            studentGetCourseChoosed = "studentGetCourseChoosed",
            getRoomIdle = "getRoomIdle",
            getRoomInfo = "getRoomInfo",
            getMajorCourses = "getMajorCourses",
            teacherGetPersonalInfo = "teacherGetPersonalInfo",
            teacherGetCourses = "teacherGetCourses",
            teacherGetCourseGrades = "teacherGetCourseGrades",
            teacherAddCourse = "teacherAddCourse",
            teacherDeleteCourse = "teacherDeleteCourse",
            teacherUpdateCourse = "teacherUpdateCourse",
            teacherUpdateCourseGrades = "teacherUpdateCourseGrades";

        public int Session { set; get; }
        public string Type { set; get; }
        public ConnectionInfo(int session, string type)
        {
            Session = session;
            Type = type;
        }
    }
}

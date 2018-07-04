using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementSystem
{
    class ConnectionInfo
    {
        public const string login = "login", 
            updatePassword = "updatePassword", 
            studentGetPersonalInfo = "studentGetPersonalInfo",
            studentGetGrades = "studentGetGrades",
            studentGetCourseInfo = "studentGetCourseInfo", 
            getRoom = "getRoom", 
            getMajorCourses = "getMajorCourses",
            teacherGetPersonalInfo= "teacherGetPersonalInfo",
            teacherGetCourses = "teacherGetCourses", 
            teacherGetCourseGrades = "teacherGetCourseGrades",
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

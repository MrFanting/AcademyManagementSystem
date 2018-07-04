using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementSystem
{
    class ConnectionInfo
    {
        public static readonly string login = "login", 
            updatePassword = "updatePassword", 
            studentGetGrades = "studentGetGrades",
            studentGetCourseInfo = "studentGetCourseInfo", 
            getIdleRooms = "getIdleRooms", 
            getMajorCourses = "getMajorCourses",
            teacherGetCourses = "teacherGetCourses", 
            teacherModifyCourse = "teacherModifyCourse",
            teacherGetCourseGrades = "teacherGetCourseGrades",
            teacherUpdateCourseGrades = "teacherUpdateCourseGrades";
        public int Session { set; get; }
        public string Type { set; get; }
    }
}

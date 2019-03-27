using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWinForm.Object;

namespace TestWinForm
{
    class ClientJsonConverter
    {
        // get response 
        public static ServerResponse GetServerResponse(string jsonResponseText)
        {
            JObject jsonResponse = JObject.Parse(jsonResponseText);
            string partialJsonResponse = jsonResponse["serverResponse"].ToString();
            ServerResponse serverResponse = JsonConvert.
                DeserializeObject<ServerResponse>(partialJsonResponse);
            return serverResponse;
        }

        // get general request
        public static string GetGeneralRequestJson(
            ConnectionInfo connectionInfo)
        {
            return JsonConvert.SerializeObject(new { connectionInfo });
        }

        // login
        public static string GetLoginRequestJson(UserAccount userAccount)
        {
            ConnectionInfo connectionInfo = new ConnectionInfo(0, 
                ConnectionInfo.login);
            var obj = new { connectionInfo, userAccount };
            return JsonConvert.SerializeObject(obj);
        }

        public static ConnectionInfo GetLoginFromResponse(string jsonResponseText)
        {
            JObject jsonResponse = JObject.Parse(jsonResponseText);
            string partialJsonResponse = jsonResponse["connectionInfo"].ToString();
            ConnectionInfo connectionInfo = JsonConvert.
                DeserializeObject<ConnectionInfo>(partialJsonResponse);
            return connectionInfo;
        }

        // student personal info
        public static string GetStudentPersonalInfoRequestJson(
            ConnectionInfo connectionInfo)
        {
            return JsonConvert.SerializeObject(new { connectionInfo });
        }
        public static Student GetStudentPersonalInfo(string jsonResponseText)
        {
            JObject jsonResponse = JObject.Parse(jsonResponseText);
            string partialJsonResponse = jsonResponse["student"].ToString();
            return JsonConvert.DeserializeObject<Student>(partialJsonResponse);
        }

        // teacher personal info
        public static string GetTeacherPersonalInfoRequestJson(
            ConnectionInfo connectionInfo)
        {
            return JsonConvert.SerializeObject(new { connectionInfo });
        }
        public static Teacher GetTeacherPersonalInfo(string jsonResponseText)
        {
            JObject jsonResponse = JObject.Parse(jsonResponseText);
            string partialJsonResponse = jsonResponse["teacher"].ToString();
            return JsonConvert.DeserializeObject<Teacher>(partialJsonResponse);
        }

        // password, no need for other response info
        public static string GetPasswordUpdateRequestJson(
            ConnectionInfo connectionInfo, UserAccount userAccount)
        {
            return JsonConvert.SerializeObject(new { connectionInfo, userAccount });
        }

        // all grades
        public static string GetGradesRequestJson(ConnectionInfo connectionInfo)
        {
            return JsonConvert.SerializeObject(new { connectionInfo });
        }
        public static IList<Score> GetGradesFromResponse(string jsonResponseText)
        {
            JObject jsonResponse = JObject.Parse(jsonResponseText);
            string partialJsonResponse = jsonResponse["grades"].ToString();
            return JsonConvert.
                DeserializeObject<IList<Score>>(partialJsonResponse);
        }

        // course info
        public static string GetCourseRequestJson(
            ConnectionInfo connectionInfo, Course course)
        {
            return JsonConvert.SerializeObject(new { connectionInfo, course });
        }
        public static Course GetCourseFromResponse(string jsonResponseText)
        {
            JObject jsonResponse = JObject.Parse(jsonResponseText);
            string partialJsonResponse = jsonResponse["course"].ToString();
            return JsonConvert.
                DeserializeObject<Course>(partialJsonResponse);
        }

        // major course
        public static string GetMajorCoursesRequestJson(
            ConnectionInfo connectionInfo)
        {
            return JsonConvert.SerializeObject(new { connectionInfo });
        }
        public static IList<Course> GetMajorCoursesFromResponse(
            string jsonResponseText)
        {
            JObject jsonResponse = JObject.Parse(jsonResponseText);
            string partialJsonResponse = jsonResponse["courses"].ToString();
            return JsonConvert.
                DeserializeObject<IList<Course>>(partialJsonResponse);
        }
        //all courses
        public static string GetCoursesToChooseRequestJson(
            ConnectionInfo connectionInfo)
        {
            return JsonConvert.SerializeObject(new { connectionInfo });
        }
        public static IList<Course> GetCoursesToChooseFromResponse(
            string jsonResponseText)
        {
            JObject jsonResponse = JObject.Parse(jsonResponseText);
            string partialJsonResponse = jsonResponse["courses"].ToString();
            return JsonConvert.
                DeserializeObject<IList<Course>>(partialJsonResponse);
        }

        // room info
        public static string GetRoomInfoRequestJson(ConnectionInfo connectionInfo,
            Room room)
        {
            return JsonConvert.SerializeObject(new { connectionInfo, room });
        }
        public static RoomInfo GetRoomInfoFromResponse(
            string jsonResponseText)
        {
            JObject jsonResponse = JObject.Parse(jsonResponseText);
            string partialJsonResponse = jsonResponse["roomInfo"].ToString();
            return JsonConvert.
                DeserializeObject<RoomInfo>(partialJsonResponse);
        }
        // room idle
        public static string GetRoomIdleRequestJson(ConnectionInfo connectionInfo)
        {
            return JsonConvert.SerializeObject(new { connectionInfo,});
        }
        public static IList<Room> GetRoomIdleFromResponse(
            string jsonResponseText)
        {
            JObject jsonResponse = JObject.Parse(jsonResponseText);
            string partialJsonResponse = jsonResponse["rooms"].ToString();
            return JsonConvert.
                DeserializeObject<IList<Room>>(partialJsonResponse);
        }
        // teacher courses
        public static string GetTeacherCoursesRequestJson(
            ConnectionInfo connectionInfo)
        {
            return JsonConvert.SerializeObject(new { connectionInfo });
        }
        public static IList<Course> GetTeacherCoursesFromResponse(
            string jsonResponseText)
        {
            JObject jsonResponse = JObject.Parse(jsonResponseText);
            string partialJsonResponse = jsonResponse["courses"].ToString();
            return JsonConvert.
                DeserializeObject<IList<Course>>(partialJsonResponse);
        }

        // teacher course grades
        public static string GetCourseGradesRequestJson(ConnectionInfo connectionInfo,
            Course course)
        {
            return JsonConvert.SerializeObject(new { connectionInfo, course });
        }
        public static IList<Score> GetCourseGradesFromResponse(string jsonResponseText)
        {
            JObject jsonResponse = JObject.Parse(jsonResponseText);
            string partialJsonResponse = jsonResponse["grades"].ToString();
            return JsonConvert.
                DeserializeObject<IList<Score>>(partialJsonResponse);
        }

        // teacher grades updates
        public static string GetCourseGradesUpdateRequestJson(ConnectionInfo connectionInfo,
            IList<Score> grades)
        {
            return JsonConvert.SerializeObject(new { connectionInfo, grades });
        }

        // 学生选课
        public static string GetStudentInsertCourseRequestJson(ConnectionInfo connectionInfo,
            Score score)
        {
            return JsonConvert.SerializeObject(new { connectionInfo, score });
        }

        // 学生选课
        public static string GetStudentDeleteCourseRequestJson(ConnectionInfo connectionInfo,
            Score score)
        {
            return JsonConvert.SerializeObject(new { connectionInfo, score });
        }

        // 教师管理课程
        public static string GetTeacherManageCourseRequestJson(ConnectionInfo connectionInfo,
            Course course)
        {
            return JsonConvert.SerializeObject(new { connectionInfo, course });
        }
    }
}

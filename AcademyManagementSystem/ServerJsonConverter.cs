using AcademyManagementSystem.Object;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AcademyManagementSystem
{
    class ServerJsonConverter
    {
        // get conn info
        string x = "";
        public static ConnectionInfo GetConnInfoFromJson(string jsonRequestText)
        {
            JObject jsonRequest = JObject.Parse(jsonRequestText);
            string jsonConnectionInfoText = jsonRequest["connectionInfo"].ToString();
            ConnectionInfo connectionInfo = JsonConvert.
                DeserializeObject<ConnectionInfo>(jsonConnectionInfoText);
            return connectionInfo;
        }

        // get general response
        public static string GetGeneralResponseJson(
            ServerResponse serverResponse)
        {
            return JsonConvert.SerializeObject(new { serverResponse });
        }

        // login
        public static UserAccount GetUserAccountFromJson(string jsonRequestText)
        {
            JObject jsonRequest = JObject.Parse(jsonRequestText);
            string jsonUserAccountText = jsonRequest["userAccount"].ToString();
            UserAccount userAccount = JsonConvert.
                DeserializeObject<UserAccount>(jsonUserAccountText);
            return userAccount;
        }
        public static string GetLoginResponseJson(ServerResponse serverResponse, 
            ConnectionInfo connectionInfo)
        {
            return JsonConvert.SerializeObject(
                new { serverResponse, connectionInfo });
        }

        // student personal info
        public static string GetStudentPersonalInfoResponseJson(
            ServerResponse serverResponse, Student student)
        {
            return JsonConvert.SerializeObject(
                new { serverResponse, student });
        }

        // teacher personal info
        public static string GetTeacherPersonalInfoResponseJson(
            ServerResponse serverResponse, Teacher teacher)
        {
            return JsonConvert.SerializeObject(
                new { serverResponse, teacher });
        }

        // password update
        // just use ParseJsonUserAccount, just the same
        public static string GetUpdatePasswordResponseJson(
            ServerResponse serverResponse)
        {
            return JsonConvert.SerializeObject(new { serverResponse });
        }

        // all grades
        // just response
        public static string GetGradesResponseJson(ServerResponse serverResponse, 
            IList<Score> grades)
        {
            return JsonConvert.SerializeObject(new { serverResponse, grades });
        }

        // course info
        public static Course GetCourseFromJson(string jsonRequestText)
        {
            JObject jsonRequest = JObject.Parse(jsonRequestText);
            string jsonCourseText = jsonRequest["course"].ToString();
            Course course = JsonConvert.
                DeserializeObject<Course>(jsonCourseText);
            return course;
        }
        public static string GetCourseReponseJson(ServerResponse serverResponse,
            Course course)
        {
            return JsonConvert.SerializeObject(new { serverResponse, course });
        }

        // room
        public static Room GetRoomInfoFromJson(string jsonRequestText)
        {
            JObject jsonRequest = JObject.Parse(jsonRequestText);
            string jsonCourseText = jsonRequest["room"].ToString();
            Room room = JsonConvert.
                DeserializeObject<Room>(jsonCourseText);
            return room;
        }
        public static string GetRoomInfoResponseJson(ServerResponse serverResponse,
            RoomInfo room)
        {
            return JsonConvert.SerializeObject(new { serverResponse, room });
        }
        public static string GetRoomIdleResponseJson(ServerResponse serverResponse,
            List<Room> rooms)
        {
            return JsonConvert.SerializeObject(new { serverResponse, rooms });
        }

        // MajorCourses
        public static string GetMajorCoursesResponseJson(
            ServerResponse serverResponse, IList<Course> courses)
        {
            return JsonConvert.SerializeObject(new { serverResponse, courses });
        }

        // teacher courses
        public static string GetTeacherCoursesResponseJson(
            ServerResponse serverResponse, IList<Course> courses)
        {
            return JsonConvert.SerializeObject(new { serverResponse, courses });
        }

        // course grades
        public static Course GetCourseForCourseGradesRequest(
            string jsonRequestText)
        {
            JObject jsonRequest = JObject.Parse(jsonRequestText);
            string jsonCourseText = jsonRequest["course"].ToString();
            Course course = JsonConvert.
                DeserializeObject<Course>(jsonCourseText);
            return course;
        }
        public static string GetCourseGradesResponseJson(
            ServerResponse serverResponse, IList<Score> grades)
        {
            return JsonConvert.SerializeObject(new { serverResponse, grades });
        }

        public  static string GetAllCoursesResponseJson(ServerResponse serverResponse, IList<Course> courses)
        {
            return JsonConvert.SerializeObject(new { serverResponse, courses });
        }

        // grades update
        public static IList<Score> GetCourseGradesUpdateFromJson(
            string jsonRequestText)
        {
            JObject jsonRequest = JObject.Parse(jsonRequestText);
            string jsonScoresText = jsonRequest["grades"].ToString();
            IList<Score> scores = JsonConvert.
                DeserializeObject<IList<Score>>(jsonScoresText);
            return scores;
        }

    }
}

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

        // rooms
        public static string GetRoomsResponseJson(ServerResponse serverResponse,
            IList<Room> rooms)
        {
            return JsonConvert.SerializeObject(new { serverResponse, rooms });
        }

        // student courses
        public static string GetStudentCoursesResponseJson(
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

        // teacher add course/update course
        public static string GetTeacherCourseModifyResponseJson(
            ServerResponse serverResponse)
        {
            return JsonConvert.SerializeObject(new { serverResponse });
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
            ServerResponse serverResponse, IList<Score> scores)
        {
            return JsonConvert.SerializeObject(new { serverResponse, scores });
        }

        // grades update
        public static IList<Score> GetCourseGradesUpdateFromJson(
            string jsonRequestText)
        {
            JObject jsonRequest = JObject.Parse(jsonRequestText);
            string jsonScoresText = jsonRequest["scores"].ToString();
            IList<Score> scores = JsonConvert.
                DeserializeObject<IList<Score>>(jsonScoresText);
            return scores;
        }

    }
}

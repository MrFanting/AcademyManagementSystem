using AcademyManagementSystem.Object;
using AcademyManagementSystem.Tool;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementSystem
{
    class Server
    {
        SessionManager sessionManager;
        DataHandler dataHandler;
        public Server()
        {
            sessionManager = new SessionManager();
            dataHandler = new DataHandler();
        }
        public void StartListening()
        {
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ipAddress, 6666);

            listener.Start();

            while (true)
            {
                Console.Write("Waiting for connection...");
                TcpClient client = listener.AcceptTcpClient();

                Console.WriteLine("Connection accepted.");
                NetworkStream ns = client.GetStream();
                StreamReader sr = new StreamReader(ns);
                StreamWriter sw = new StreamWriter(ns);

                string request = sr.ReadLine();
                ConnectionInfo connectionInfo = ServerJsonConverter.
                    GetConnInfoFromJson(request);
                if (connectionInfo.Type == ConnectionInfo.login)
                {
                    HandleLogin(request, sw);
                }
                else
                {
                    HandleServiceRequest(connectionInfo, request, sw);
                }
                sw.Flush();
                ns.Close();
                client.Close();
            }
        }
        public void HandleLogin(string requestJson, StreamWriter sw)
        {
            UserAccount userAccount = ServerJsonConverter.
                GetUserAccountFromJson(requestJson);
            ConnectionInfo connectionInfo = null;
            bool valid = false;
            if (dataHandler.VerifyStudent(userAccount))
            {
                int session = sessionManager.AddOnlineUser(userAccount);
                connectionInfo = new ConnectionInfo(session, 
                    ConnectionInfo.login);
                valid = true;
            }
            string responseJson = ServerJsonConverter.
                    GetLoginResponseJson(ServerResponse.GetServerResponse(valid),
                    connectionInfo);
            sw.WriteLine(responseJson);
        }
        public void HandleServiceRequest(ConnectionInfo connectionInfo, 
            string requestJson, StreamWriter sw)
        {
            string account;
            if (sessionManager.
                GetUserId(connectionInfo.Session, out account) == false)
            {
                sw.WriteLine(ServerJsonConverter.GetGeneralResponseJson(
                    ServerResponse.GetServerResponse(false)));
                return;
            }
            switch (connectionInfo.Type)
            {
                case ConnectionInfo.studentGetPersonalInfo:
                    HandleStudentPersonalInfo(account, sw);
                    break;
                case ConnectionInfo.studentGetGrades:
                    HandleStudentGetGrades(requestJson, sw);
                    break;
                case ConnectionInfo.studentGetCourseInfo:
                    HandleGetCourseInfo(requestJson, sw);
                    break;
                case ConnectionInfo.getRoom:
                    HandleRoom(requestJson, sw);
                    break;
                case ConnectionInfo.getMajorCourses:
                    HandleMajorCourse(account, sw);
                    break;
                case ConnectionInfo.teacherGetPersonalInfo:
                    HandleTeacherPersonalInfo(account, sw);
                    break;
                case ConnectionInfo.teacherGetCourses:
                    HandleTeacherCoursesInfo(account, sw);
                    break;
                case ConnectionInfo.teacherGetCourseGrades:
                    HandleStudentGetGrades(account, sw);
                    break;
                case ConnectionInfo.teacherUpdateCourseGrades:
                    HandleTeacherUpdateGrades(requestJson, sw);
                    break;
            }
        }

        public void HandleStudentPersonalInfo(string account, StreamWriter sw)
        {
            sw.WriteLine(dataHandler.QueryStudentById(account));
            return;
        }

        public void HandleTeacherPersonalInfo(string account, StreamWriter sw)
        {
            sw.WriteLine(dataHandler.QueryTeacherById(account));
            return;
        }

        public void HandlePasswordUpdate(string request, StreamWriter sw)
        {
            UserAccount userAccount = ServerJsonConverter.GetUserAccountFromJson(
                request);

            bool isSuccess = dataHandler.UpdateUserCode(userAccount);
            sw.WriteLine(ServerResponse.GetServerResponse(isSuccess));
            return;
        }
        public void HandleStudentGetGrades(string account, StreamWriter sw)
        {
            IList<Score> grades = dataHandler.StudengQueryScore(account);
            bool isSuccess = grades != null;
            sw.WriteLine(ServerJsonConverter.GetGradesResponseJson(
                ServerResponse.GetServerResponse(isSuccess), grades));
            return;
        }

        public void HandleGetCourseInfo(string request, StreamWriter sw)
        {
            Course course = ServerJsonConverter.GetCourseFromJson(request);
            Course resultCourse = dataHandler.QueryCourseById(course.Id);
            bool found = resultCourse != null;
            sw.WriteLine(ServerJsonConverter.GetCourseReponseJson(
                ServerResponse.GetServerResponse(found), resultCourse));
            return;
        }

        public void HandleRoom(string request, StreamWriter sw)
        {
            Room room = ServerJsonConverter.GetRoomFromJson(request);
            Room resultRoom = dataHandler.QueryRoom(room);
            bool found = resultRoom != null;
            sw.WriteLine(ServerJsonConverter.GetRoomResponseJson(
                ServerResponse.GetServerResponse(found), resultRoom));
            return;
        }

        public void HandleMajorCourse(string account, StreamWriter sw)
        {
            IList<Course> courses = dataHandler.QueryTrainingProgram(account);
            bool found = courses != null;
            sw.WriteLine(ServerJsonConverter.GetMajorCoursesResponseJson(
                ServerResponse.GetServerResponse(found), courses));
            return;
        }

        public void HandleTeacherCoursesInfo(string account, StreamWriter sw)
        {
            IList<Course> courses = dataHandler.QueryCourseByTeacherId(account);
            bool found = courses != null;
            sw.WriteLine(ServerJsonConverter.GetMajorCoursesResponseJson(
                ServerResponse.GetServerResponse(found), courses));
            return;
        }

        public void HandleTeacherUpdateGrades(string request, StreamWriter sw)
        {
            IList<Score> grades = ServerJsonConverter.GetCourseGradesUpdateFromJson(
                request);
            bool isSuccess = dataHandler.UpdateScore((List<Score>) grades);
            sw.WriteLine(ServerJsonConverter.GetGeneralResponseJson(
                ServerResponse.GetServerResponse(isSuccess)));
            return;
        }


    }
}

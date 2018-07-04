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
            if (dataHandler.verifyStudent(userAccount))
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
                    break;
            }
        }

        public void HandleStudentPersonalInfo(string account, StreamWriter sw)
        {
            sw.WriteLine(dataHandler.queryStudentById(account));
            return;
        }

        public void HandleTeacherPersonalInfo(string account, StreamWriter sw)
        {
            sw.WriteLine(dataHandler.queryTeacherById(account));
            return;
        }

        public void HandlePasswordUpdate(string request, StreamWriter sw)
        {
            UserAccount userAccount = ServerJsonConverter.GetUserAccountFromJson(
                request);

            bool isSuccess = dataHandler.updateUserCode(userAccount);
            sw.WriteLine(ServerResponse.GetServerResponse(isSuccess));
            return;
        }
        public void HandleStudentGetGrades(string account, StreamWriter sw)
        {
            // IList<Score> grades = dataHandler.queryScore(account, );
            // sw.WriteLine(dataHandler.);
            return;
        }
    }
}

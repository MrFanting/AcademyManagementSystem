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
    class Program
    {
        public static void StartListening()
        {
            SortedDictionary<int, int> sessionPool = new SortedDictionary<int, int>();
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
                ConnectionInfo connectionInfo = ServerJsonConverter.GetConnInfoFromJson(request);
                if (connectionInfo.Type == ConnectionInfo.login)
                {

                }
            }
        }

        static void Main(string[] args)
        {
            StartListening();
            //Console.Write(ServerJsonConverter.GetUserAccountJson(new UserAccount("2015", "pw", UserAccount.student)));
            Console.ReadKey();
        }
    }
}

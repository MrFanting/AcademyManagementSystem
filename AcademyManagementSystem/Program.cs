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
    class Program
    {
        

        static void Main(string[] args)
        {
            Server server = new Server();
            server.StartListening();
        }
    }
}

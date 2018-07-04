using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementSystem
{
    class ServerResponse
    {
        public static readonly string success = "success", failure = "failure";
        public string Result { get; set; }
        public static ServerResponse GetServerResponse(bool isSuccess)
        {
            string result = isSuccess ? success : failure;
            ServerResponse serverResponse = new ServerResponse()
            {
                Result = result
            };
            return serverResponse;
        }
    }
}

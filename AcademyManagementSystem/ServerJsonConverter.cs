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
        public static string ParseJsonType(string jsonRequestText)
        {
            JObject jsonRequest = JObject.Parse(jsonRequestText);
            JToken jToken = jsonRequest["connectionInfo"]["Type"];
            return jToken.ToString();
        }
        public static UserAccount ParseJsonUserAccount(string jsonRequestText)
        {
            JObject jsonRequest = JObject.Parse(jsonRequestText);
            string jsonUserAccountText = jsonRequest["userAccount"].ToString();
            UserAccount userAccount = JsonConvert.DeserializeObject<UserAccount>(jsonUserAccountText);
            return userAccount;
        }
        public static string GetLoginResponseJson(UserAccount userAccount)
        {

        }
        /*
                 public static UserAccount GetUserAccountJson(string jsonString)
        {
            var jsonMessage = new { type = login, data = userAccount };
            return JsonConvert.SerializeObject(jsonMessage);
        }
         */
    }
}

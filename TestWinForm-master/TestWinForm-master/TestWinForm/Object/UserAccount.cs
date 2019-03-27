using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWinForm.Object
{
    public class UserAccount
    {
        public static string teacher = "teacher", student = "student";
        public string Account { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public UserAccount(string account, string password, string type)
        {
            Account = account;
            Password = password;
            Type = type;
        }
        /* 
         User user = new User("abc", "123", User.student);
            string output = JsonConvert.SerializeObject(user);
            Console.WriteLine(output);
         */
    }
}

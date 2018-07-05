using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementSystem
{
    class SessionManager
    {
        private SortedDictionary<int, string> SessionPool;
        private Random Random;
        public SessionManager()
        {
            SessionPool = new SortedDictionary<int, string>();
            Random = new Random();
        }
        public int AddOnlineUser(UserAccount userAccount)
        {
            while (true)
            {
                int session = Random.Next(int.MaxValue);
                if (SessionPool.ContainsKey(session) == false)
                {
                    SessionPool.Add(session, userAccount.Account);   
                    return session;
                }
            }
        }
        public bool GetUserId(int session, out string userId)
        {
            bool found = SessionPool.ContainsKey(session);
            if (found)
            {
                userId = SessionPool[session];
            }
            else
            {
                userId = null;
            }
            return found;
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace UserClass
{
    public class User
    {
        private static List<string> _users = new List<string>();

        public void Add(string userName)
        {
            _users.Add(userName);
        }

        public int GetUsersCount()
        {
            return _users.Count;
        }
    }
}
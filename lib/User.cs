using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class AdminM
    {
        private List<User> users = new List<User>();

        public AdminM()
        {
            users.Add(new User { Username = "aysen", Password = "1234" });
            users.Add(new User { Username = "demet" , Password = "9876" });
        }

        public bool Login(string userName, string password)
        {
            foreach(var user in users)
            {
                if(user.Username == userName &&  user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public void UpdatePassword(string userName, string newPassword)
        {
            var user = users.Find(u => u.Username == userName);
            if (user != null)
            {
                user.Password = newPassword;
            }
        }
    }
}

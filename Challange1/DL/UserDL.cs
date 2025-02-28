using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange1.BL;

namespace Challange1.DL
{
    internal class UserDL
    {
        public static List<User> User = new List<User>()
        {
            new User{UserName="Ahmad", UserPassword="1234"}
        };
        public static void AddPassword(User userValue)
        {
            User.Add(userValue);
        }
    }
}

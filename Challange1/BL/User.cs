using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange1.DL;

namespace Challange1.BL
{
    internal class User
    {
        public string UserName, UserPassword;
        public static bool ValidateUser(string name, string password)
        {
            bool isTrue=false;
            User user = new User();
            int x = 0, y = 0;
            foreach (var item in UserDL.User)
            {
                if (name == user.UserName && password == user.UserPassword)
                {
                    isTrue = true;
                    break;
                }
            }
            return isTrue;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange1.DL;

namespace Challange1.BL
{
    internal class Admin
    {
        public string AdminName, AdminPassword;
        public static bool ValidateAdmin(string name, string password)
        {
            bool isTrue = false;
            Admin admin = new Admin();
            foreach (var item in AdminDL.Admin)
            {
                if (name == admin.AdminName && password == admin.AdminPassword)
                {
                    isTrue = true;
                    break;
                }
            }
                return isTrue;
        }
    }
}

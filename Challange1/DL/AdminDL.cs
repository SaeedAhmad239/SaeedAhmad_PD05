using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange1.BL;

namespace Challange1.DL
{
    internal class AdminDL
    {
        public static List<Admin> Admin = new List<Admin>();
        public static void AddNewAdmin(Admin adminValue)
        {
            Admin.Add(adminValue);
            
        }
    }
}

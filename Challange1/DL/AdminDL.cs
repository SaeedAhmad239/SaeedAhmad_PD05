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
        public static List<BL.Admin> Admin = new List<BL.Admin>()
        {
            new BL.Admin { AdminName = "Saeed", AdminPassword = "1234" }
        };
        public static void AddNewAdmin(BL.Admin adminValue)
        {
            Admin.Add(adminValue);
        }
    }
}

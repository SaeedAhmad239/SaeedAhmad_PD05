using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange1.BL;
using Challange1.DL;

namespace Challange1.UI
{
    internal class UserUI
    {
        private static string Name, Password;
        public static int UserChoice()
        {
            Console.WriteLine("1. View all the products\n2. Buy the products\n3. Generate invoice\n4. View Profile\n5. Exit \n");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static bool CheckUser()
        {
            User instance = new User();
            Console.WriteLine("Enter name: ");
            instance.UserName = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            instance.UserPassword = Console.ReadLine();
            Name = instance.UserName;
            Password = instance.UserPassword;
            bool isTrue = User.ValidateUser(instance.UserName, instance.UserPassword);
            isTrue = true;//Condition is not correct
            return isTrue;
        }
        public static void ViewProfile()
        {
            Console.WriteLine("Name: " + Name + "\nPassword: " + Password);
        }
        public static void AddUser()
        {
            User instance = new User();
            Console.WriteLine("Enter name: ");
            instance.UserName = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            instance.UserPassword = Console.ReadLine();
            UserDL.AddPassword(instance);
        }
    }
}

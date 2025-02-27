using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange1.BL;

namespace Challange1.UI
{
    internal class AdminUI
    {
        public static string Name, Password;
        public static int AdminChoice()
        {
            Console.WriteLine("1. Add Product.\n2. View All Products.\n3. Find Product with Highest Unit Price.\n4. View Sales Tax of All Products.\n5. Products to be Ordered.\n6. View Profile\n7. Exit ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static bool CheckAdmin()
        {
            Admin instance = new Admin();
            Console.WriteLine("Enter name: ");
            instance.AdminName = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            instance.AdminPassword = Console.ReadLine();
            Name = instance.AdminName;
            Password = instance.AdminPassword;
            bool isTrue = Admin.ValidateAdmin(instance.AdminName, instance.AdminPassword);
            return isTrue;
        }
        public static Products AddProduct()
        {
            Products instance = new Products();
            Console.WriteLine("Enter Name: ");
            instance.ProductName = Console.ReadLine();
            Console.WriteLine("Enter Product category: ");
            instance.ProductCategory = Console.ReadLine();
            Console.WriteLine("Enter Product Price: ");
            instance.ProductPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Quantity: ");
            instance.Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Minimum Threshold for product: ");
            instance.MinimumStockThreshold = int.Parse(Console.ReadLine());
            return instance;
        }
        public static void ViewProfile()
        {
            Console.WriteLine("Name: " + Name + "\n Password: " + Password);
        }
    }
}

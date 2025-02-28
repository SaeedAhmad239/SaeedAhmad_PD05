using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange1.BL;
using Challange1.DL;
using Challange1.UI;

namespace Challange1
{
    internal class Program
    {
        static int Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("1. SignIn\n2. SignUp\n3. Exit");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)// SignIn
                {
                    Console.WriteLine("1.Admin \n2.User");
                    int c = int.Parse(Console.ReadLine());
                    if (c == 1) //Admin
                    {
                        bool isTrue = AdminUI.CheckAdmin();
                        if (isTrue) // Admin is valis or not
                        {
                            while (isTrue)
                            {
                                int adminChoice = AdminUI.AdminChoice();
                                if (adminChoice == 1)//Add Products
                                {
                                    Products instance = new Products();
                                    instance = AdminUI.AddProduct();
                                    ProductsDL.AddProduct(instance);
                                }
                                else if (adminChoice == 2)// View all products
                                {
                                    ProductsUI.ViewProducts();
                                }
                                else if (adminChoice == 3) //Product with highest unit price
                                {

                                }
                                else if (adminChoice == 4)//View Sales tax of all products
                                {

                                }
                                else if (adminChoice == 5)//Products to be orderd
                                {
                                    ProductsUI.ProductsToOrder();
                                }
                                else if (adminChoice == 6)//View Profile
                                {
                                    AdminUI.ViewProfile();
                                }
                                else if (adminChoice == 7)//Exit
                                    return 0;
                                //Console.Clear();
                            }
                        }
                        else
                            Console.WriteLine("Please enter correct data!");
                    }
                    else if (c == 2)//User
                    {
                        bool IsTrue = UserUI.CheckUser();
                        if (IsTrue)
                        {
                            while (IsTrue)
                            {
                                int userChoice = UserUI.UserChoice();
                                if (userChoice == 1)//View all products
                                {
                                    ProductsUI.ViewProducts();
                                }
                                else if (userChoice == 2)//Buy Products
                                {
                                    ProductsUI.ViewProducts();
                                    Console.WriteLine("Want to buy: (Y/N)");
                                    string WantToBuy = Console.ReadLine();
                                    //if(WantToBuy =="Y")

                                }
                                else if (userChoice == 3)//Generate Invoice
                                {
                                    Console.WriteLine("Please select products Invoice will automatically generated at end");
                                }
                                else if (userChoice == 4)//View Profile
                                {
                                    UserUI.ViewProfile();
                                }
                                else if (userChoice == 5)//Exit
                                    return 0;
                            }

                        }
                        else
                            Console.WriteLine("Please enter correct data!");
                    }
                }
                else if (choice == 2)// SignUp
                {
                    UserUI.AddUser();
                }
                else if (choice == 3)//exit
                    return 0;
            }
        }
        }
    }
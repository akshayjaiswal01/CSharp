using LoginApp.Dal;
using System.Xml.Serialization;

namespace LoginApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginDBContext loginDBContext = new LoginDBContext();
            int choice = 0;

            do
            {
                Console.WriteLine("1. Login \n" +
                              "2. Register \n" +
                              "3. Forgot Password \n" +
                              "4. Exit");

                Console.WriteLine("Enter Your Choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:

                        Console.WriteLine("Enter Username: ");
                        string loginusername = Console.ReadLine();

                        Console.WriteLine("Enter Password: ");
                        string loginpassword = Console.ReadLine();

                        bool validate = loginDBContext.validateUser(loginusername, loginpassword);
                        if(validate)
                        {
                            Console.WriteLine("Login Successfully...");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Invalid Credentials!!!");
                            Console.WriteLine();
                        }

                    break;

                    case 2:

                        Console.WriteLine("Enter Username: ");
                        string registerusername = Console.ReadLine();

                        Console.WriteLine("Enter Password: ");
                        string registerpassword = Console.ReadLine();

                        bool register = loginDBContext.registerUser(registerusername, registerpassword);
                        if(register)
                        {
                            Console.WriteLine("Register Successfully...");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Registration Failed...");
                            Console.WriteLine();
                        }

                    break;

                    case 3:

                        Console.WriteLine("Enter Username: ");
                        string username = Console.ReadLine();

                        bool checkUsername = loginDBContext.checkUsername(username);
                        if(checkUsername)
                        {
                            Console.WriteLine("Enter New Password: ");
                            string newPassword = Console.ReadLine();

                            bool updatePassword = loginDBContext.updatePassword(username, newPassword);
                            if(updatePassword)
                            {
                                Console.WriteLine("Password Updated Successfully...");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Failed To Update Password!!!");
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Username");
                            Console.WriteLine();
                        }

                    break;

                    case 4:
                        Console.WriteLine("Thank You for visiting");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }
            while (choice != 4);
            


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forTestHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string password;
            bool isLoggedIn = true;
            string userChoose;

            while (isLoggedIn)
            {
                Console.WriteLine("Menu commands: \nset name \nset password \nwrite name \nset background \nset font \nexit");
                userChoose = Console.ReadLine();

                switch (userChoose)
                {
                    case "set name":
                        Console.Write("Write name: ");
                        userName = Console.ReadLine();
                        break;

                    case "set password":
                        if password
                        Console.Write("new password");
                        break;

                    case "write name":
                        break;

                    case "set background":
                        Console.WriteLine("Choose color: \nWhite \nGreen \nRed \nBlack \nBlue \nreset");
                        userChoose = Console.ReadLine();

                        if (userChoose == "white")
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                        }
                        else if (userChoose == "green")
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                        }
                        else if (userChoose == "red")
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        else if (userChoose == "black")
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        else if (userChoose == "blue")
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                        }
                        else if (userChoose == "reset")
                        {
                            Console.ResetColor();
                        }
                        break;

                    case "set font":
                        Console.WriteLine("Choose color: \nWhite \nGreen \nRed \nBlack \nBlue \nreset");
                        userChoose = Console.ReadLine();

                        if (userChoose == "white")
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (userChoose == "green")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (userChoose == "red")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else if (userChoose == "black")
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        else if (userChoose =="blue")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (userChoose == "reset")
                        {
                            Console.ResetColor();
                        }

                        break;

                    case "exit":
                        Console.WriteLine("Exit is processing...");
                        isLoggedIn = false;
                        break;
                }
            }
        }
    }
}

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
            const string MenuSetName = "1";
            const string MenuSetPassword = "2";
            const string MenuWriteName = "3";
            const string MenuSetBackground = "4";
            const string MenuSetFont = "5";
            const string MenuExit = "6";

            const string ColorWhite = "1";
            const string ColorGreen = "2";
            const string ColorRed = "3";
            const string ColorBlack = "4";
            const string ColorBlue = "5";
            const string ColorReset = "6";

            const string PasswordExit = "exit";

            string userName = "";
            string password = "";
            string userInput;
            bool isLoggedIn = true;
            bool tryPassword = true;
            string userChoose;

            while (isLoggedIn)
            {
                Console.WriteLine($"Menu commands: \n{MenuSetName} - set name \n{MenuSetPassword} - set password \n{MenuWriteName} - write name \n{MenuSetBackground} - set background \n{MenuSetFont} - set font \n{MenuExit} - exit");;
                userChoose = Console.ReadLine();

                switch (userChoose)
                {
                    case MenuSetName:
                        Console.Write("Write name: ");
                        userName = Console.ReadLine();

                        break;

                    case MenuSetPassword:
                        tryPassword = true;

                        if (password == "")
                        {
                            Console.Write("Введите новый пароль: ");
                            password = Console.ReadLine();
                            Console.WriteLine("Пароль установлен!");
                        }

                        else
                        {
                            while (tryPassword)
                            {
                                Console.Write("Введите пароль: ");
                                userInput = Console.ReadLine();

                                if (userInput == password)
                                {
                                    Console.WriteLine("Пароль верный!");
                                    tryPassword = false;
                                }

                                else if (userInput == PasswordExit)
                                {
                                    tryPassword = false;
                                }

                                else
                                {
                                    Console.WriteLine("Пароль неверный!");
                                    Console.WriteLine($"Если хотите оставить попытку ввести пароль введите {PasswordExit}");
                                }
                            }
                        }

                        break;

                    case MenuWriteName:

                        Console.WriteLine("Введите пароль: ");
                        userInput = Console.ReadLine();

                        if (password == userInput && userName != "")
                        {
                            Console.WriteLine(userName);
                        }

                        else if (password == "")
                        {
                            Console.WriteLine("Для начала нужно установить пароль!");
                        }

                        else if (password != userInput)
                        {
                            Console.WriteLine("Пароль неверный!");
                        }

                        else if (userName == "")
                        {
                            Console.WriteLine("Для начала нужно установить имя!");
                        }

                        break;

                    case MenuSetBackground:
                        Console.WriteLine($"Choose color: \n{ColorWhite} - White \n{ColorGreen} - Green \n{ColorRed} - Red \n{ColorBlack} - Black \n{ColorBlue} - Blue \n{ColorReset} - reset");
                        userChoose = Console.ReadLine();

                        if (userChoose == ColorWhite)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                        }

                        else if (userChoose == ColorGreen)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                        }

                        else if (userChoose == ColorRed)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }

                        else if (userChoose == ColorBlack)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                        }

                        else if (userChoose == ColorBlue)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                        }

                        else if (userChoose == ColorReset)
                        {
                            Console.ResetColor();
                        }

                        break;

                    case MenuSetFont:
                        Console.WriteLine($"Choose color: \n{ColorWhite} - White \n{ColorGreen} - Green \n{ColorRed} - Red \n{ColorBlack} - Black \n{ColorBlue} - Blue \n{ColorReset} - reset");
                        userChoose = Console.ReadLine();

                        if (userChoose == ColorWhite)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        else if (userChoose == ColorGreen)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                        else if (userChoose == ColorRed)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }

                        else if (userChoose == ColorBlack)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                        }

                        else if (userChoose == ColorBlue)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }

                        else if (userChoose == ColorReset)
                        {
                            Console.ResetColor();
                        }

                        break;

                    case MenuExit:
                        Console.WriteLine("Exit is processing...");
                        isLoggedIn = false;

                        break;
                }
            }
        }
    }
}

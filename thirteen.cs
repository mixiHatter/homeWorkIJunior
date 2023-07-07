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

            const string MenuColorWhite = "1";
            const string MenuColorGreen = "2";
            const string MenuColorRed = "3";
            const string MenuColorBlack = "4";
            const string MenuColorBlue = "5";
            const string MenuColorReset = "6";
            
            string passwordExit = "exit";
            string userName = "";
            string password = "";
            string userInput;
            string userChoose;
            bool isLoggedIn = true;
            bool haveTryPassword = true;
            
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
                        haveTryPassword = true;

                        if (password == "")
                        {
                            Console.Write("Введите новый пароль: ");
                            password = Console.ReadLine();
                            Console.WriteLine("Пароль установлен!");
                        }
                        else
                        {
                            while (haveTryPassword)
                            {
                                Console.Write("Введите пароль: ");
                                userInput = Console.ReadLine();

                                if (userInput == password)
                                {
                                    Console.WriteLine("Пароль верный!");
                                    haveTryPassword = false;
                                }

                                else if (userInput == passwordExit)
                                {
                                    haveTryPassword = false;
                                }
                                else
                                {
                                    Console.WriteLine("Пароль неверный!");
                                    Console.WriteLine($"Если хотите оставить попытку ввести пароль введите {passwordExit}");
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
                        Console.WriteLine($"Choose color: \n{MenuColorWhite} - White \n{MenuColorGreen} - Green \n{MenuColorRed} - Red \n{MenuColorBlack} - Black \n{MenuColorBlue} - Blue \n{MenuColorReset} - reset");
                        userChoose = Console.ReadLine();

                        if (userChoose == MenuColorWhite)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                        }

                        else if (userChoose == MenuColorGreen)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                        }

                        else if (userChoose == MenuColorRed)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }

                        else if (userChoose == MenuColorBlack)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                        }

                        else if (userChoose == MenuColorBlue)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                        }

                        else if (userChoose == MenuColorReset)
                        {
                            Console.ResetColor();
                        }
                        break;

                    case MenuSetFont:
                        Console.WriteLine($"Choose color: \n{MenuColorWhite} - White \n{MenuColorGreen} - Green \n{MenuColorRed} - Red \n{MenuColorBlack} - Black \n{MenuColorBlue} - Blue \n{MenuColorReset} - reset");
                        userChoose = Console.ReadLine();

                        if (userChoose == MenuColorWhite)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        else if (userChoose == MenuColorGreen)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                        else if (userChoose == MenuColorRed)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }

                        else if (userChoose == MenuColorBlack)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                        }

                        else if (userChoose == MenuColorBlue)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }

                        else if (userChoose == MenuColorReset)
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

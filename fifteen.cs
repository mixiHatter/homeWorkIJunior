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
            string password = "Valera";
            string secretMessage = "Ты самый лучший! У тебя всё получиться!";
            string userInput;
            int numberOfTries = 2;
            bool IsLoggin = true;

            while (IsLoggin)
            {
                Console.WriteLine("Введите пароль: ");
                userInput = Console.ReadLine();

                if (userInput != password && numberOfTries > 0) 
                {
                    numberOfTries--;
                    Console.WriteLine("Пароль неверный!");
                }

                else if (userInput == password)
                {
                    Console.WriteLine(secretMessage);
                    IsLoggin = false;
                }

                else if (numberOfTries == 0)
                {
                    IsLoggin = false;
                }
            }
        }
    }
}

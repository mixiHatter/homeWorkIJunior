using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace forTestHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string symbol;
            string rowOfSybols = "";
            int numbersOfSymbols;

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            numbersOfSymbols = name.Length + 2;
            Console.Write("Введите символ: ");
            symbol = Console.ReadLine();

            for (int i = 0; i < numbersOfSymbols; i++)
            {
                rowOfSybols += symbol;
            }

            Console.WriteLine(rowOfSybols);
            Console.WriteLine($"{symbol}{name}{symbol}");
            Console.WriteLine(rowOfSybols);
        }
    }
}

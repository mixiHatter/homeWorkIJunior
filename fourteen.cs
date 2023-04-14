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
            int numbersOfSymbols;

            Console.Write("Введите имя: ");
            name = Convert.ToString(Console.ReadLine());
            numbersOfSymbols = name.Length + 2;
            Console.Write("Введите символ: ");
            symbol = Convert.ToString(Console.ReadLine());

            for(int i = 0; i < numbersOfSymbols; i++) 
            {
                Console.Write(symbol);
            }

            Console.WriteLine();
            Console.WriteLine($"{symbol}{name}{symbol}");

            for (int i = 0; i < numbersOfSymbols; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }
}

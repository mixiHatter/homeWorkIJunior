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
            string rowOfSymbols = "";
            string middleLine;

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите символ: ");
            symbol = Console.ReadLine();
            middleLine = symbol + name + symbol;

            for (int i = 0; i < middleLine.Length; i++)
            {
                rowOfSymbols += symbol;
            }

            Console.WriteLine($"{rowOfSymbols}\n{middleLine}\n{rowOfSymbols}");
        }
    }
}

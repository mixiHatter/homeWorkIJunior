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
            int edging = 2;

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите символ: ");
            symbol = Console.ReadLine();

            for (int i = 0; i < name.Length + edging; i++)
            {
                rowOfSymbols += symbol;
            }

            Console.WriteLine($"{rowOfSymbols}\n{symbol}{name}{symbol}\n{rowOfSymbols}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forTestHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;
            int countOfRepetitions;

            Console.Write("Введите сообщение: ");
            text = Console.ReadLine();
            Console.Write("Введите количество повторений сообщения: ");
            countOfRepetitions = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < countOfRepetitions;i++)
            {
                Console.WriteLine(text);
            }
        }    
    }
}

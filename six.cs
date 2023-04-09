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
            int gold;
            int crystalPrice = 5;
            int crystals;
            int remaindGold;

            Console.WriteLine("Добро пожаловать в магазин! Сколько у вас золота?");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Кристалл стоит {crystalPrice} голды, какое количество ты хочешь купить?");

            crystals = Convert.ToInt32(Console.ReadLine());
            remaindGold = gold - crystals * crystalPrice;
            
            Console.WriteLine($"Теперь у тебя {remaindGold} золото и {crystals} кристалла.");
        }
    }
}

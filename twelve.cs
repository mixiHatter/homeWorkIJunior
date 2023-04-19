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
            const string СommandUsdToRub = "1";
            const string СommandUsdToJpy = "2";
            const string СommandRubToUsd = "3";
            const string СommandRubToJpy = "4";
            const string СommandJpyToUsd = "5";
            const string СommandJpyToRub = "6";
            const string CommandExit = "7";

            float moneyDollarBalance = 100.0F;
            float moneyRubleBalance = 100.0F;
            float moneyYenBalance = 100.0F;
            float commandUsdToRub = 81.51F;
            float commandUsdToJpy = 132.50F;
            float commandRubToUsd = 0.012F;
            float commandRubToJpy = 1.63F;
            float commandJpyToUsd = 0.0075F;
            float commandJpyToRub = 0.62F;
            float convertNumber;
            bool isOpen = true;
            string userChoose;

            while (isOpen)
            {
                Console.WriteLine($"Ваш баланс: {moneyDollarBalance} dollars, {moneyRubleBalance} rubles, {moneyYenBalance} yens.");
                Console.WriteLine($"Меню: \n{СommandUsdToRub} - конвертировать USD в RUB \n{СommandUsdToJpy} - конвертировать USD в JPY \n{СommandRubToUsd} - конвертировать RUB в USD  \n{СommandRubToJpy} - конвертировать RUB в JPY \n{СommandJpyToUsd} - конвертировать RUB в JPY \n{СommandJpyToRub} - конвертировать JPY в RUB \n{CommandExit} - выйти.");
                userChoose = Console.ReadLine();

                switch (userChoose)
                {
                    case СommandUsdToRub:
                        Console.WriteLine($"Сколько долларов вы хотите перевести в рубли? Доступно: {moneyDollarBalance}");
                        convertNumber = Convert.ToSingle(Console.ReadLine());
                        moneyDollarBalance -= convertNumber;
                        moneyRubleBalance += convertNumber * commandUsdToRub;
                        break;

                    case СommandRubToUsd:
                        Console.WriteLine($"Сколько рублей вы хотите перевести в доллары? Доступно: {moneyRubleBalance}");
                        convertNumber = Convert.ToSingle(Console.ReadLine());
                        moneyRubleBalance -= convertNumber;
                        moneyDollarBalance += convertNumber * commandRubToUsd;
                        break;

                    case СommandUsdToJpy:
                        Console.WriteLine($"Сколько долларов вы хотите перевести в йены? Доступно: {moneyDollarBalance}");
                        convertNumber = Convert.ToSingle(Console.ReadLine());
                        moneyDollarBalance -= convertNumber;
                        moneyYenBalance += convertNumber * commandUsdToJpy;
                        break;

                    case СommandJpyToUsd:
                        Console.WriteLine($"Сколько йен вы хотите перевести в доллары? Доступно: {moneyYenBalance}");
                        convertNumber = Convert.ToSingle(Console.ReadLine());
                        moneyYenBalance -= convertNumber;
                        moneyDollarBalance += convertNumber * commandJpyToUsd;
                        break;

                    case СommandJpyToRub:
                        Console.WriteLine($"Сколько йен вы хотите перевести в рубли? Доступно: {moneyYenBalance}");
                        convertNumber = Convert.ToSingle(Console.ReadLine());
                        moneyYenBalance -= convertNumber;
                        moneyRubleBalance += convertNumber * commandJpyToRub;
                        break;

                    case СommandRubToJpy:
                        Console.WriteLine($"Сколько рублей вы хотите перевести в йены? Доступно: {moneyRubleBalance}");
                        convertNumber = Convert.ToSingle(Console.ReadLine());
                        moneyRubleBalance -= convertNumber;
                        moneyYenBalance += convertNumber * commandRubToJpy;
                        break;

                    case CommandExit:
                        isOpen = false;
                        break;
                }
            }
        }
    }
}

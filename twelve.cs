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
                Console.WriteLine("Меню: \ncommandUsdToRub - конвертировать USD в RUB \ncommandRubToUsd - конвертировать RUB в USD \ncommandUsdToJpy - конвертировать USD в JPY \ncommandRubToJpy - конвертировать RUB в JPY \ncommandJpyToUsd - конвертировать RUB в JPY \ncommandJpyToRub - конвертировать JPY в RUB \nexit - выйти.");
                userChoose = Console.ReadLine();

                switch (userChoose)
                {
                    case "commandUsdToRub":
                        Console.WriteLine($"Сколько долларов вы хотите перевести в рубли? Доступно: {moneyDollarBalance}");
                        convertNumber = Convert.ToSingle(Console.ReadLine());
                        moneyDollarBalance -= convertNumber;
                        moneyRubleBalance += convertNumber * commandUsdToRub;
                        Console.WriteLine($"Теперь у вас: {moneyDollarBalance} долларов и {moneyRubleBalance} рублей");
                        break;

                    case "commandRubToUsd":
                        Console.WriteLine($"Сколько рублей вы хотите перевести в доллары? Доступно: {moneyRubleBalance}");
                        convertNumber = Convert.ToSingle(Console.ReadLine());
                        moneyRubleBalance -= convertNumber;
                        moneyDollarBalance += convertNumber * commandRubToUsd;
                        Console.WriteLine($"Теперь у вас: {moneyRubleBalance} рублей и {moneyDollarBalance} долларов ");
                        break;

                    case "commandUsdToJpy":
                        Console.WriteLine($"Сколько долларов вы хотите перевести в йены? Доступно: {moneyDollarBalance}");
                        convertNumber = Convert.ToSingle(Console.ReadLine());
                        moneyDollarBalance -= convertNumber;
                        moneyYenBalance += convertNumber * commandUsdToJpy;
                        Console.WriteLine($"Теперь у вас: {moneyDollarBalance} долларов и {moneyYenBalance} йен");
                        break;

                    case "commandJpyToUsd":
                        Console.WriteLine($"Сколько йен вы хотите перевести в доллары? Доступно: {moneyYenBalance}");
                        convertNumber = Convert.ToSingle(Console.ReadLine());
                        moneyYenBalance -= convertNumber;
                        moneyDollarBalance += convertNumber * commandJpyToUsd;
                        Console.WriteLine($"Теперь у вас: {moneyYenBalance} йен и {moneyDollarBalance} долларов");
                        break;

                    case "commandJpyToRub":
                        Console.WriteLine($"Сколько йен вы хотите перевести в рубли? Доступно: {moneyYenBalance}");
                        convertNumber = Convert.ToSingle(Console.ReadLine());
                        moneyYenBalance -= convertNumber;
                        moneyRubleBalance += convertNumber * commandJpyToRub;
                        Console.WriteLine($"Теперь у вас: {moneyYenBalance} йен и {moneyRubleBalance} рублей");
                        break;

                    case "commandRubToJpy":
                        Console.WriteLine($"Сколько рублей вы хотите перевести в йены? Доступно: {moneyRubleBalance}");
                        convertNumber = Convert.ToSingle(Console.ReadLine());
                        moneyRubleBalance -= convertNumber;
                        moneyYenBalance += convertNumber * commandRubToJpy;
                        Console.WriteLine($"Теперь у вас: {moneyRubleBalance} и {moneyYenBalance}");
                        break;

                    case "exit":
                        isOpen = false;
                        break;
                }
            }
        }
    }
}

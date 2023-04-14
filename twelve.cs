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
            float convertDollarToRubles = 81.51F;
            float convertDollarToYens = 132.50F;
            float convertRubleToDollars = 0.012F;
            float convertRubleToYens = 1.63F;
            float convertYenToDollars = 0.0075F;
            float convertYenToRubles = 0.62F;
            float convertNumber;
            bool isOpen = true;
            string userChoose;

            while (isOpen)
            {
                Console.WriteLine($"Ваш баланс: {moneyDollarBalance} dollars, {moneyRubleBalance} rubles, {moneyYenBalance} yens.");
                Console.WriteLine("Меню: введите \"конвертировать валюту в валюту\" что бы обменять валюту. Введите \"выход\" что бы выйти.");
                userChoose = Convert.ToString(Console.ReadLine());

                switch (userChoose)
                {
                    case "конвертировать доллары в рубли":
                        Console.WriteLine($"Сколько долларов вы хотите перевести в рубли? Доступно: {moneyDollarBalance}");
                        convertNumber = Convert.ToSingle(Console.ReadLine());
                        moneyDollarBalance -= convertNumber;
                        moneyRubleBalance += convertNumber * convertDollarToRubles;
                        Console.WriteLine($"Теперь у вас: {moneyDollarBalance} долларов и {moneyRubleBalance} рублей");
                        break;
                    case "конвертировать рубли в доллары":
                        Console.WriteLine($"Сколько рублей вы хотите перевести в доллары? Доступно: {moneyRubleBalance}");
                        convertNumber = Convert.ToSingle(Console.ReadLine());
                        moneyRubleBalance -= convertNumber;
                        moneyDollarBalance += convertNumber * convertRubleToDollars;
                        Console.WriteLine($"Теперь у вас: {moneyRubleBalance} рублей и {moneyDollarBalance} долларов ");
                        break;
                    case "конвертировать доллар в йены":
                        Console.WriteLine($"Сколько долларов вы хотите перевести в йены? Доступно: {moneyDollarBalance}");
                        convertNumber = Convert.ToSingle(Console.ReadLine());
                        moneyDollarBalance -= convertNumber;
                        moneyYenBalance += convertNumber * convertDollarToYens;
                        Console.WriteLine($"Теперь у вас: {moneyDollarBalance} долларов и {moneyYenBalance} йен");
                        break;
                    case "конвертировать йены в доллары":
                        Console.WriteLine($"Сколько йен вы хотите перевести в доллары? Доступно: {moneyYenBalance}");
                        convertNumber = Convert.ToSingle(Console.ReadLine());
                        moneyYenBalance -= convertNumber;
                        moneyDollarBalance += convertNumber * convertYenToDollars;
                        Console.WriteLine($"Теперь у вас: {moneyYenBalance} йен и {moneyDollarBalance} долларов");
                        break;
                    case "конвертировать йены в рубли":
                        Console.WriteLine($"Сколько йен вы хотите перевести в рубли? Доступно: {moneyYenBalance}");
                        convertNumber = Convert.ToSingle(Console.ReadLine());
                        moneyYenBalance -= convertNumber;
                        moneyRubleBalance += convertNumber * convertYenToRubles;
                        Console.WriteLine($"Теперь у вас: {moneyYenBalance} йен и {moneyRubleBalance} рублей");
                        break;
                    case "конвертировать рубли в йены":
                        Console.WriteLine($"Сколько рублей вы хотите перевести в йены? Доступно: {moneyRubleBalance}");
                        convertNumber = Convert.ToSingle(Console.ReadLine());
                        moneyRubleBalance -= convertNumber;
                        moneyYenBalance += convertNumber * convertRubleToYens;
                        Console.WriteLine($"Теперь у вас: {moneyRubleBalance} и {moneyYenBalance}");
                        break;
                    case "выход":
                        isOpen = false;
                        break;
                }
            }
        }
    }
}

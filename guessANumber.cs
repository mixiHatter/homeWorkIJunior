// делаем игру угадай число (по тутору)
class program
{
    static void Main(string[] args)
    {
        int number, lower, larger;
        int tryCount = 5;
        Random rand = new Random();
        int userInput;

        number = rand.Next(0, 101);
        lower = rand.Next(number - 10, number);
        larger = rand.Next(number + 1, number + 10);

        Console.WriteLine($"Мы загадали число от 0 до 100, оно больше, чем {lower}, но меньше, чем {larger}");
        Console.WriteLine("Что это за число?");

        while(tryCount-- > 0)
        {
            Console.WriteLine("Это число:");
            userInput = Convert.ToInt32(Console.ReadLine());

            if(userInput == number)
            {
                Console.WriteLine($"Верно! это было - {number}");
                break;
            }
            else
            {
                Console.WriteLine("Не верно, попробуйте ещё раз");
            }
        }

        if(tryCount < 0)
        {
            Console.WriteLine($"Вы проиграли, я загадывал число - {number}");
        }
    }
}
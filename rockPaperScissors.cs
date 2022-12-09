// делаем игру камень ножницы бумага
class program
{
    static void Main(string[] args)
    {
        string answer;
        int choose;

        Console.WriteLine("Давай сыграем в камень ножницы бумага?  y/n");
        answer = Convert.ToString(Console.ReadLine());

        Random rand = new Random();
        while (answer == "y")
        {
            int i = rand.Next(1, 4);
            Console.WriteLine("Камень, ножницы, бумага!? 1,2,3...");
            choose = Convert.ToInt32(Console.ReadLine());

            if (choose == i)
            {
                Console.WriteLine("Ничья");
            }
            else if (choose == 1 && i == 2)
            {
                Console.WriteLine("Победа!");
            }
            else if (choose == 1 && i == 3)
            {
                Console.WriteLine("Поражение...");
            }
            else if (choose == 2 && i == 3)
            {
                Console.WriteLine("Победа!");
            }
            else if (choose == 2 && i == 1)
            {
                Console.WriteLine("Поражение...");
            }
            else if (choose == 3 && i == 1)
            {
                Console.WriteLine("Победа!");
            }
            else if (choose == 3 && i == 2)
            {
                Console.WriteLine("Поражение...");
            }
            else
            {
                Console.WriteLine("Продолжим?  y/n");
                answer = Convert.ToString(Console.ReadLine());
            }
        }
        Console.WriteLine("спасибо за игру");
    }
}
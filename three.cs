//task Вы задаете вопросы пользователю, по типу "как вас зовут", "какой ваш знак зодиака" и тд,
//после чего, по данным, которые он ввел, формируете небольшой текст о пользователе.
//"Вас зовут Алексей, вам 21 год, вы водолей и работаете на заводе."

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Как Вас зовут?");
        var name = Console.ReadLine();
        Console.WriteLine("Сколько Вам лет?");
        var age = Console.ReadLine();
        Console.WriteLine("Какой у вас вес?");
        var weight = Console.ReadLine();
        Console.WriteLine("Какой у вас рост?");
        var height = Console.ReadLine();
        Console.WriteLine("Кем вы работаете?");
        var profession = Console.ReadLine();

        Console.WriteLine($"Вас зовут {name}, вам {age} лет. Ваш вес {weight}кг на рост {height}см. Вы работаете {profession}, всё верно?");
    }
}
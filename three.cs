//task Вы задаете вопросы пользователю, по типу "как вас зовут", "какой ваш знак зодиака" и тд,
//после чего, по данным, которые он ввел, формируете небольшой текст о пользователе.
//"Вас зовут Алексей, вам 21 год, вы водолей и работаете на заводе."

internal partial class Program
{
    private static void Main(string[] args)
    {
        string name;
        int age;
        float weight;
        float height;
        string profession;

        Console.WriteLine("Как Вас зовут?");
        name = Console.ReadLine();
        Console.WriteLine("Сколько Вам лет?");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Какой у вас вес?");
        weight = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Какой у вас рост?");
        height = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Кем вы работаете?");
        profession = Console.ReadLine();

        Console.WriteLine($"Вас зовут {name}, вам {age} лет. Ваш вес {weight}кг на рост {height}см. Вы работаете {profession}, всё верно?");
    }
}
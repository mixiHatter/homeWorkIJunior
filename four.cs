namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int allPicture = 52;
            int row = 3;
            int filledRow = 0;
            int remainder = 0;

            filledRow = allPicture / row;
            remainder = filledRow % row;

            Console.WriteLine($"Полностью заполненных рядов - {filledRow} \nКартинок сверх меры - {remainder}");
        }

    }
}
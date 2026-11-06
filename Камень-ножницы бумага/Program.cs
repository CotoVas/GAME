
class Program
{
    static void Main()
    {
        Console.WriteLine("Камень-ножницы-бумага!");
        Console.WriteLine("Нажми любую кнопку, чтобы сыграть:");
        Console.ReadKey();
        Console.WriteLine();

        int roll = new Random().Next(100);


        if (roll < 50)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ты победил!)))");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("   /\\_/\\  ");
            Console.WriteLine("  ( ^.^ )  ");
            Console.WriteLine("   > ^ <   ");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ты проиграл...(((");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine("   /\\_/\\  ");
            Console.WriteLine("  ( -.- )  ");
            Console.WriteLine("   > ^ <   ");
        }
        Console.ReadLine();
    }
}
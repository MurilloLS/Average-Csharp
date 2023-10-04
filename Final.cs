using System;

namespace Average
{
    public class Final
    {
        public static void Finalization(string name)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Até mais {name}!");
            Console.ReadKey();
            Show.Apresentation();
        }        
    }
}        
using System;

namespace Average
{
    public class Show
    {
        public static void Apresentation()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("OLÁ, Seja bem vindo!");
            Console.WriteLine("--------------------");
            Console.WriteLine("1 - Iniciar");
            Console.WriteLine("2 - Sair");
            short res = short.Parse(Console.ReadLine());
            switch(res)
            {
                case 1: Menu.Start();break;
                case 2: Environment.Exit(0);break;
            }
            }
        }
}        
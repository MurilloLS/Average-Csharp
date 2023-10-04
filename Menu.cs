using System;

namespace Average
{
    public class Menu
    {
        public static void Start() 
        {
            Console.Clear();  
            Console.WriteLine("OLÁ, Digite o seu nome:");
            string name = Console.ReadLine();  
            Console.Clear();
            Console.WriteLine("Digite um conjunto de números separados por vírgulas:");
            string entrada = Console.ReadLine();

            // Divida a entrada em números com base nas vírgulas
            string[] numerosComoStrings = entrada.Split(',');
            double soma = 0;
            int totalNumeros = 0;
            Calc.Calculator(soma, totalNumeros, numerosComoStrings, name);    
        }

    }
}